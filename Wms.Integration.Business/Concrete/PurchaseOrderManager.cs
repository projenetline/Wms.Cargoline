using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Business.Messages;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class PurchaseOrderManager : IPurchaseService
    {
        private readonly ILoggerDal loggerDal;
        public PurchaseOrderManager(ILoggerDal loggerDal)
        {
            this.loggerDal = loggerDal;
        }
        public string Connection="Server=192.168.16.3;Database=OCAK2023;user id=sa;password=Deneme123";
        public async Task<IDataResult<WorkOrder>> CreateWorkOrderIAsync(WorkOrder workOrder)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection))
                {
                    connection.Open();
                    SqlCommand command= connection.CreateCommand();
                    command.CommandText = @$"INSERT INTO [dbo].[WorkOrder] ([SlipType],[SlipDate] ,[SlipNumber] ,[ArpId] ,[WarehouseId] ,[Description1]  ,[Description2] ,[Description3],
                    [Description4] ,[DocumentNumber] ,[CustomCode] ,[CompletedDate] ,[CompletedBy]  ,[DepartmentId] ,[DivisionId],[FactoryId],[DocumentDate],[Priority],[PrintCount] ,[StateId] ,
                    [AuthCode] ,[Active],[CreatedDate] ,[CreatedBy] ,[ModifiedDate],[ModifiedBy])  
                    VALUES(1,GETDATE(),'{workOrder.SlipNumber}',{workOrder.ArpId},{workOrder.WarehouseId},'{workOrder.Description1}', '{workOrder.Description2}','{workOrder.Description3}', '{workOrder.Description4}',
                  '{workOrder.DocumentNumber}', '{workOrder.CustomCode}',GetDate() , {workOrder.CompletedBy}, {workOrder.DepartmentId}, {workOrder.DivisionId}, {workOrder.FactoryId},  GetDate() ,
                    0,0,14, '{workOrder.AuthCode}',  1, GetDate(), 1,GetDate(), 1) GO  SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY]; "; /* '{workOrder.CompletedDate}*/ /*'{workOrder.DocumentDate}'*/
                    int Id=Convert.ToInt32(await command.ExecuteScalarAsync());
                    if (Id > 0)
                    {
                        workOrder.Id = Id;
                    }
                    return new SuccessDataResult<WorkOrder>(workOrder, "Satın alma fatura emri oluşturuldu!");
                }
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelfManager.GetAnyAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<WorkOrder>(null, "Satın alma Fatura emri oluşturulamadı!");
            }
        }
    }
}
