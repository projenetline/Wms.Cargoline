using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.OrderSlip;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class OrderSlipManager : IOrderSlipService
    {
        private readonly IOrderSlipDal orderSlipDal;
        private readonly ILoggerDal loggerDal;
        private readonly ISysErpIntegrationDal sysErpIntegrationDal;
        private readonly ISysErpFirmDal sysErpFirmDal;
        public OrderSlipManager(IOrderSlipDal orderSlipDal, ILoggerDal loggerDal, ISysErpIntegrationDal sysErpIntegrationDal,ISysErpFirmDal sysErpFirmDal)
        {
            this.orderSlipDal = orderSlipDal;
            this.loggerDal = loggerDal;
            this.sysErpIntegrationDal = sysErpIntegrationDal;
            this.sysErpFirmDal = sysErpFirmDal;
        }
        public async Task<IDataResult<OrderSlip>> CreateAsync(OrderSlip entity)
        {
            try
            {
                return new SuccessDataResult<OrderSlip>(await orderSlipDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "OrderSlipManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<OrderSlip>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<OrderSlip>> DeleteAsync(OrderSlip entity)
        {
            try
            {
                return new SuccessDataResult<OrderSlip>(await orderSlipDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "OrderSlipManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<OrderSlip>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<OrderSlip>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<OrderSlip>(await orderSlipDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "OrderSlipManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<OrderSlip>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<IList<OrderSlip>>> GetListAsync(OrderSlipListParameterDto dto)
        {
            try
            {
                SysErpFirm erpfirm=await  sysErpFirmDal.GetAsync(s=>s.ErpFirmNumber==int.Parse(dto.FirmNr));
               // IList<OrderSlip> orderSlip=await orderSlipDal.GetListAsync(s =>dto.StateId2==0? s.StateId == dto.StateId : s.StateId == dto.StateId,s=>s.SlipNumber,false);
                IList<int> integration=(await sysErpIntegrationDal.GetListAsync(s => s.RecordType == 153 && s.ErpFirmId==erpfirm.Id,s=>s.RecordId,false)).Select(s=>s.Id).ToList();
                return new SuccessDataResult<IList<OrderSlip>>(await orderSlipDal.GetListAsync(s => dto.StateId2 == 0 ? s.StateId == dto.StateId && integration.Contains(s.Id): s.StateId == dto.StateId && s.StateId==dto.StateId2 && integration.Contains(s.Id), s => s.SlipNumber, false,s=>s.Arp), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "OrderSlipManager.GetListAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<IList<OrderSlip>>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public Task<IDataResult<OrderSlip>> UpdateAsync(OrderSlip entity)
        {
            throw new NotImplementedException();
        }
    }
}
