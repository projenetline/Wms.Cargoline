using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Decompositions;
using Wms.Integration.Entities.Dtos.Slip;

namespace Wms.Integration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlipController : ControllerBase
    {
        private readonly ILoggerService loggerService;
        private readonly ISlipService slipService;
        private readonly IMapper objectMapper;
        public SlipController(ISlipService slipService, ILoggerService loggerService, IMapper objectMapper)
        {
            this.objectMapper = objectMapper;
            this.loggerService = loggerService;
            this.slipService = slipService;
        }
        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] ListSlipDto dto)
        {
            IDataResult<IList<Slip>> dataResult = await slipService.GetListAsync(dto);
            if (dataResult.Success)
            {
                return Ok(dataResult.Data);
            }
            return BadRequest(dataResult.Message);
        }
        [HttpGet("GetPagedList")]
        public async Task<IActionResult> GetPagedList([FromQuery] ListSlipDto dto)
        {
            IDataResult<PagedResult<Slip>> dataResult = await slipService.GetPagedListAsync(dto);
            if (dataResult.Success)
            {
                return Ok(dataResult.Data);
            }
            return BadRequest(dataResult.Message);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            IDataResult<Slip> dataResult = await slipService.GetAsync(id);
            if (dataResult.Success)
            {
                return Ok(dataResult.Data);
            }
            return BadRequest(dataResult.Message);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Slip slip)
        {
            IDataResult<Slip> dataResult = await slipService.CreateAsync(slip);
            if (dataResult.Success)
            {
                return Ok(dataResult.Data);
            }
            return BadRequest(dataResult.Message);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] Slip slip)
        {
            IDataResult<Slip> dataResult = await slipService.UpdateAsync(slip);
            if (dataResult.Success)
            {
                return Ok(dataResult.Data);
            }
            return BadRequest(dataResult.Message);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteDecompositionShelf([FromQuery] int id)
        {
            IDataResult<Slip> dataResult = await slipService.GetAsync(id);
            if (dataResult.Success)
            {
                IDataResult<Slip> result = await slipService.DeleteAsync(dataResult.Data);
                if (result.Success)
                {
                    return Ok(result.Data);
                }
                return BadRequest(result.Message);
            }
            return BadRequest(dataResult.Message);
        }
    }
}
