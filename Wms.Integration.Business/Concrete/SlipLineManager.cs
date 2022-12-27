using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Slip;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SlipLineManager : ISlipLineService
    {
        private readonly ISlipLineDal slipDal;
        private readonly ILoggerDal loggerDal;
        public SlipLineManager(ISlipLineDal slipDal, ILoggerDal loggerDal)
        {
            this.slipDal = slipDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<IList<SlipLine>>> GetListAsync(ListSlipDto dto)
        {
            try
            {
                return new SuccessDataResult<IList<SlipLine>>(await slipDal.GetListAsync(s => s.StateId == dto.StateId, s => s.Id, false, s => s.OrderSlipLineId, s => s.Arp), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SlipLineManager.GetListAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<IList<SlipLine>>(null, CustomJObject.Instance.General.Get);
            }
        }

        public async Task<IDataResult<PagedResult<SlipLine>>> GetPagedListAsync(ListSlipDto dto)
        {
            try
            {
                return new SuccessDataResult<PagedResult<SlipLine>>(new PagedResult<SlipLine>
                {
                    Items = await slipDal.GetPagedListAsync(dto.SkipCount, dto.MaxResultCount, s => s.StateId == dto.StateId, s => s.Id, false, s => s.OrderSlipLine, s => s.Arp),
                    TotalCount = await slipDal.CountAsync(s => s.StateId == dto.StateId)
                }, CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SlipLineManager.GetPagedListAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PagedResult<SlipLine>>(null, CustomJObject.Instance.General.Get);
            }
        }

        public async Task<IDataResult<SlipLine>> CreateAsync(SlipLine entity)
        {
            try
            {
                return new SuccessDataResult<SlipLine>(await slipDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SlipLineManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SlipLine>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SlipLine>> DeleteAsync(SlipLine entity)
        {
            try
            {
                return new SuccessDataResult<SlipLine>(await slipDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SlipLineManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SlipLine>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SlipLine>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SlipLine>(await slipDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SlipLineManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SlipLine>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SlipLine>> UpdateAsync(SlipLine entity)
        {
            try
            {
                return new SuccessDataResult<SlipLine>(await slipDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SlipLineManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SlipLine>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
