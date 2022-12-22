using Microsoft.AspNetCore.Mvc;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly ISysAddressService addressService;
        private readonly ILoggerService loggerService;
        public AddressController(ISysAddressService addressService, ILoggerService loggerService)
        {
            this.addressService = addressService;
            this.loggerService = loggerService;
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromQuery] string address)
        {
            IDataResult<SysAddress> dataResult = await addressService.CreateAsync(new SysAddress
            {
                Address = address,
                WarehouseId = 1,
                FloorId = 1,
                ZoneId = null,
                BlockId = null,
                AddressType = 8,
                GroupCode = null,
                Aisle = null,
                LineNumber = 0,
                Shelf = 0,
                Xcoord = 0,
                Ycoord = 0,
                Zcoord = 0,
                Width = null,
                Height = null,
                Length = null,
                Depth = null,
                Weight = null,
                Volume = null,
                CustomCode = null,
                ShipmentPriority = 0,
                PlacementPriority = 0,
                RfId = null,
                Latitude = null,
                Longitude = null,
                GpsAddress = null,
                Active = 1,
                AuthCode = null,
                CreatedDate = DateTime.Parse("2022-11-09 09:07:09.247"),
                CreatedBy = 2,
                ModifiedDate = null,
                ModifiedBy = null
            });
            if (dataResult.Success)
            {
                return Ok(new SuccessResult());
            }
            return BadRequest(dataResult.Message);
        }
        /*
         exec sp_executesql N'INSERT INTO [SysAddress]
        (Address, WarehouseId, FloorId, ZoneId, BlockId, AddressType, GroupCode, Aisle, LineNumber, Shelf, XCoord, YCoord, ZCoord, Width, Height, Length, Depth, Weight,
        Volume, CustomCode, ShipmentPriority, PlacementPriority, RfId, Latitude, Longitude, GpsAddress, Active, AuthCode, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
        
        VALUES(@Address, @WarehouseId, @FloorId, @ZoneId, @BlockId, @AddressType, @GroupCode, @Aisle, @LineNumber, @Shelf, @XCoord, @YCoord, @ZCoord, @Width, @Height, @Length, @Depth, @Weight, @Volume, 
        @CustomCode, @ShipmentPriority, @PlacementPriority, @RfId, @Latitude, @Longitude, @GpsAddress, @Active, @AuthCode, @CreatedDate, @CreatedBy, @ModifiedDate, @ModifiedBy) 
        SELECT CAST(scope_identity() AS int)',N'@Address nvarchar(4000),@WarehouseId int,@FloorId int,@ZoneId nvarchar(4000),@BlockId nvarchar(4000),@AddressType smallint,@GroupCode nvarchar(4000),
        @Aisle nvarchar(4000),@LineNumber int,@Shelf smallint,@XCoord smallint,@YCoord smallint,@ZCoord smallint,@Width nvarchar(4000),@Height nvarchar(4000),@Length nvarchar(4000),@Depth nvarchar(4000),
        @Weight nvarchar(4000),@Volume nvarchar(4000),@CustomCode nvarchar(4000),@ShipmentPriority smallint,@PlacementPriority smallint,@RfId nvarchar(4000),@Latitude nvarchar(4000),@Longitude nvarchar(4000),
        @GpsAddress nvarchar(4000),@Active smallint,@AuthCode nvarchar(4000),@CreatedDate datetime,@CreatedBy int,@ModifiedDate nvarchar(4000),@ModifiedBy nvarchar(4000)',
        
        @Address=N'A1',
        @WarehouseId=1,
        @FloorId=1,
        @ZoneId=NULL,
        @BlockId=NULL,
        @AddressType=8,
        @GroupCode=NULL,
        @Aisle=NULL,
        @LineNumber=0,
        @Shelf=0,
        @XCoord=0,
        @YCoord=0,
        @ZCoord=0,
        @Width=NULL,
        @Height=NULL,
        @Length=NULL,
        @Depth=NULL,
        @Weight=NULL,
        @Volume=NULL,
        @CustomCode=NULL,
        @ShipmentPriority=0,
        @PlacementPriority=0,
        @RfId=NULL,
        @Latitude=NULL,
        @Longitude=NULL,
        @GpsAddress=NULL,
        @Active=1,
        @AuthCode=NULL,
        @CreatedDate='2022-11-09 09:07:09.247',
        @CreatedBy=2,
        @ModifiedDate=NULL,
        @ModifiedBy=NULL
         */
    }
}
