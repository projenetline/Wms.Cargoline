using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wms.Integration.Business.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Shipments;

namespace Wms.Integration.Business.Concrete
{
    public class ShipmentManager:IShipmentService
    {
        private readonly IItemTotalsReportViewDal itemtotalsReportviewDal;
        private readonly ILoggerDal loggerDal;
        private readonly ILabelBodyDal labelBodyDal;
        private readonly ILabelHeaderDal labelHeaderDal;
        public ShipmentManager(IItemTotalsReportViewDal itemtotalsReportviewDal, ILoggerDal loggerDal, ILabelBodyDal labelBodyDal, ILabelHeaderDal labelHeaderDal)
        {
            this.itemtotalsReportviewDal = itemtotalsReportviewDal;
            this.loggerDal = loggerDal;
            this.labelBodyDal = labelBodyDal;
            this.labelHeaderDal = labelHeaderDal;
        }

        public async Task<ShippingModel> GetOrder(string orderId)
        {
            ShippingModel shippingModel=new ShippingModel();
            using (SqlConnection connection = new SqlConnection("Server=192.168.7.252;Database=OCAK2023;user id=sa;password=net_123"))
            {
                SqlCommand command= connection.CreateCommand();
                command.CommandText = "select *from IsmailKapama1 where Id in ("+orderId+")";
                connection.Open();
                SqlDataReader dataReader=await command.ExecuteReaderAsync();
                if(dataReader.Read())
                {
                   shippingModel=new ShippingModel
                    {
                        OrderNr=dataReader.GetString(1),
                        Date=dataReader.GetDateTime(2).ToString(),
                        Address1=dataReader.GetString(3),
                        Address2=dataReader.GetString(4),
                        City=dataReader.GetString(5),
                        Town=dataReader.GetString(6),
                        Barcode=dataReader.GetString(7),
                        Amount=dataReader.GetString(8),
                        ClCode=dataReader.GetString(9),
                        ClDefintion=dataReader.GetString(10),
                       
                    };
                }
                dataReader.Close();
                connection.Close();
                command.CommandText = "select *from IsmailKapama1 where Id in (" + orderId + ")";
                connection.Open();
                dataReader=await command.ExecuteReaderAsync();
                while (dataReader.Read())
                {
                    shippingModel.Items.Add(new ShippingItem
                    {
                        ItemName=dataReader.GetString(1),
                        Barcode=dataReader.GetString(2),
                        ItemCode=dataReader.GetString(3),
                        LeftAmount=Convert.ToDouble( dataReader.GetDecimal(4)),
                        OrderAmount= Convert.ToDouble(dataReader.GetDecimal(5)),
                        Shipped=0,
                        UnitCode=dataReader.GetString(6),
                        LotNr=dataReader.GetString(7),
                    });
                }
                dataReader.Close();
                connection.Close();
                LabelHeader header=await labelHeaderDal.GetAsync(s=>s.OrderNr==orderId.Replace(',','-'),false,s=>s.labelBodies);
                if (header != null)
                {
                    shippingModel.LabelInfo = new LabelInfoModel
                    {
                        Address1 = header.Address1,
                        Address2 = header.Address2,
                        BoxCount = header.BoxCount,
                        City = header.City,
                        ClDefintion = header.ClDefintion,
                        InvoiceCount = header.InvoiceCount,
                        LabelCount = header.LabelCount,
                        Date = header.Date,
                        Desi = header.Desi,
                        OrderNr = header.OrderNr,
                        PaletNr = header.PaletNr,
                        Town = header.Town,
                        Transporter = header.Transporter,
                    };
                    foreach (LabelBody item in header.labelBodies)
                    {
                        shippingModel.LabelInfo.OrderIdList.Add(item.OrderId.ToString());
                    }

                }
                else
                {
                    shippingModel.LabelInfo = new LabelInfoModel();
                }
                
            }
            return shippingModel;
        }

        public async Task<bool> GetShipping(string sql)
        {
            using (SqlConnection connection = new SqlConnection("Server=192.168.7.252;Database=OCAK2023;user id=sa;password=net_123"))
            {
                SqlCommand command= connection.CreateCommand();
                command.CommandText = sql;
                connection.Open();
                await command.ExecuteNonQueryAsync();
                connection.Close();
            }
            return true;
        }

        public async Task<bool> LabelCreate(LabelInfoModel labelInfoModel)
        {
            try
            {
                LabelHeader labelHeader=new LabelHeader
                {
                    Id=Guid.NewGuid(),
                    LabelCount=labelInfoModel.LabelCount,
                    Address1=labelInfoModel.Address1,
                    Address2=labelInfoModel.Address2,
                    BoxCount=labelInfoModel.BoxCount,
                    City=labelInfoModel.City,
                    ClDefintion=labelInfoModel.ClDefintion,
                    Date=labelInfoModel.Date,
                    Desi=labelInfoModel.Desi,
                    InvoiceCount=labelInfoModel.InvoiceCount,
                    OrderNr=labelInfoModel.OrderNr,
                    PaletNr=labelInfoModel.PaletNr,
                    Town=labelInfoModel.Town,
                    Transporter=labelInfoModel.Transporter,
                    labelBodies=new List<LabelBody>()
                };
                LabelHeader header=await labelHeaderDal.CreateAsync(labelHeader);
                foreach (string item in labelInfoModel.OrderIdList)
                {
                    labelHeader.labelBodies.Add(new LabelBody
                    {
                        Id = Guid.NewGuid(),
                        LabelHeader = header,
                        LabelHeaderId = header.Id,
                        OrderId = int.Parse(item)
                    });
                }
                foreach (LabelBody body in labelHeader.labelBodies)
                {
                    LabelBody body1=await labelBodyDal.CreateAsync(body);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
