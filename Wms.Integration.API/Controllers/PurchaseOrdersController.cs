using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Business.Extensions;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.PurchaseOrders;

namespace Wms.Integration.API.Controllers
{
    [Route("netlineapi/wms/[controller]")]
    [ApiController]
    public class PurchaseOrdersController : ControllerBase
    {
        private readonly IOrderSlipService orderSlipService;
        private readonly ISysWarehouseService warehouseService;
        private readonly IArpService arpService;
        private readonly ISysFactoryService factoryService;
        private readonly ISysDivisionService divisionService;
        private readonly ISysDepartmentService departmentService;
        private readonly IItemService itemService;
        private readonly IItemUnitService itemUnitService;
        private readonly IMapper objectMapper;
        private readonly ILoggerService loggerService;
        private readonly IOrderSlipLineService orderSlipLineService;
        private readonly IWorkOrderService workOrderService;
        private readonly IWorkOrderLineService workOrderLineService;
        private readonly ISlipLineService slipLineService;
        private readonly ISysAddressService addressService;
        private readonly IPurchaseService purchaseService;
        private readonly ISlipService slipService;
        private readonly ITransactionDetailService transactionDetailService;
        public PurchaseOrdersController(IOrderSlipService orderSlipService, ISysWarehouseService warehouseService, IArpService arpService,
                                        IItemService itemService, ISysFactoryService factoryService, ISysDivisionService divisionService,
                                        ISysDepartmentService departmentService, IMapper objectMapper, ILoggerService loggerService,
                                        IItemUnitService itemUnitService,IOrderSlipLineService orderSlipLineService,IWorkOrderService workOrderService,
                                        ISysAddressService addressService,ISlipService slipService,IWorkOrderLineService workOrderLineService,
                                        ITransactionDetailService transactionDetailService,ISlipLineService slipLineService,IPurchaseService purchaseService)
        {
            this.purchaseService = purchaseService;
            this.workOrderLineService = workOrderLineService;
            this.workOrderService = workOrderService;
            this.orderSlipLineService = orderSlipLineService;
            this.itemUnitService = itemUnitService;
            this.itemService = itemService;
            this.factoryService = factoryService;
            this.orderSlipService = orderSlipService;
            this.warehouseService = warehouseService;
            this.arpService = arpService;
            this.divisionService = divisionService;
            this.departmentService = departmentService;
            this.objectMapper = objectMapper;
            this.loggerService = loggerService;
            this.addressService = addressService;
            this.slipService = slipService;
            this.transactionDetailService = transactionDetailService;
            this.slipLineService= slipLineService;
        }
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] CreatePurchaseOrdersDto dto)
        {
            try
            {
                IDataResult<SysWarehouse> warehouseResult = await warehouseService.GetCodeAsync(dto.WareHouseCode);
                if (warehouseResult.Success)
                {
                    IDataResult<Arp> arpResult = await arpService.GetCodeAsync(dto.ArpCode);
                    if (arpResult.Success)
                    {
                        IDataResult<SysFactory> factoryResult = await factoryService.GetCodeAsync(dto.FactoryCode);
                        if (factoryResult.Success)
                        {
                            IDataResult<SysDivision> divisionResult = await divisionService.GetCodeAsync(dto.DivisionCode);
                            if (divisionResult.Success)
                            {
                                IDataResult<SysDepartment> departmentResult = await departmentService.GetCodeAsync(dto.DepartmentCode);
                                if (departmentResult.Success)
                                {
                                    OrderSlip slip = objectMapper.Map<CreatePurchaseOrdersDto, OrderSlip>(dto);
                                    slip.Warehouse = warehouseResult.Data;
                                    slip.WarehouseId = warehouseResult.Data.Id;
                                    slip.Arp = arpResult.Data;
                                    slip.ArpId = arpResult.Data.Id;
                                    slip.Factory = factoryResult.Data;
                                    slip.FactoryId = factoryResult.Data.Id;
                                    slip.Division = divisionResult.Data;
                                    slip.DivisionId = divisionResult.Data.Id;
                                    slip.Department = departmentResult.Data;
                                    slip.DepartmentId = departmentResult.Data.Id;
                                    IDataResult<OrderSlip> slipResult = await orderSlipService.CreateAsync(slip);
                                    if (slipResult.Success)
                                    {
                                        IDataResult<Item> itemResult;
                                        IDataResult<ItemUnit> itemUnitResult;
                                        foreach (CreatePurchaseOrdersLineDto item in dto.createPurchaseOrdersLineDtos)
                                        {
                                            itemResult = await itemService.GetCodeAsync(item.ItemCode);
                                            if (itemResult.Success)
                                            {
                                                itemUnitResult = await itemUnitService.GetItemIdAsync(itemResult.Data.Id);
                                                if (itemUnitResult.Success)
                                                {
                                                    factoryResult = await factoryService.GetCodeAsync(dto.FactoryCode);
                                                    if (factoryResult.Success)
                                                    {
                                                        divisionResult = await divisionService.GetCodeAsync(dto.DivisionCode);
                                                        if (divisionResult.Success)
                                                        {
                                                            departmentResult = await departmentService.GetCodeAsync(dto.DepartmentCode);
                                                            if (departmentResult.Success)
                                                            {
                                                                warehouseResult = await warehouseService.GetCodeAsync(dto.WareHouseCode);
                                                                if (warehouseResult.Success)
                                                                {
                                                                    arpResult = await arpService.GetCodeAsync(dto.ArpCode);
                                                                    if (arpResult.Success)
                                                                    {
                                                                        OrderSlipLine line = objectMapper.Map<CreatePurchaseOrdersLineDto, OrderSlipLine>(item);
                                                                        line.Arp = arpResult.Data;
                                                                        line.ArpId = arpResult.Data.Id;
                                                                        line.Slip = slipResult.Data;
                                                                        line.SlipId = slipResult.Data.Id;
                                                                        line.Warehouse = warehouseResult.Data;
                                                                        line.WarehouseId = warehouseResult.Data.Id;
                                                                        line.Department = departmentResult.Data;
                                                                        line.DepartmentId = departmentResult.Data.Id;
                                                                        line.FactoryId = factoryResult.Data.Id;
                                                                        line.DivisionId = divisionResult.Data.Id;
                                                                        line.Item = itemResult.Data;
                                                                        line.ItemId = itemResult.Data.Id;
                                                                        line.Unit = itemUnitResult.Data;
                                                                        line.UnitId = itemUnitResult.Data.Id;
                                                                        IDataResult<OrderSlipLine> lineResult = await orderSlipLineService.CreateAsync(line);
                                                                        if (lineResult.Success)
                                                                        {
                                                                            slip.OrderSlipLines.Add(lineResult.Data);
                                                                        }
                                                                        return BadRequest(lineResult.Message);
                                                                    }
                                                                    return BadRequest(arpResult.Message);
                                                                }
                                                                return BadRequest(warehouseResult.Message);
                                                            }
                                                            return BadRequest(departmentResult.Message);
                                                        }
                                                        return BadRequest(factoryResult.Message);
                                                    }
                                                    return BadRequest(factoryResult.Message);
                                                }
                                                return BadRequest(itemUnitResult.Message);
                                            }
                                            return BadRequest(itemResult.Message);
                                        }
                                        return Ok(slip);
                                    }
                                    return BadRequest(slipResult.Message);
                                }
                                return BadRequest(departmentResult.Message);
                            }
                            return BadRequest(divisionResult.Message);
                        }
                        return BadRequest(factoryResult.Message);
                    }
                    return BadRequest(arpResult.Message);
                }
                return BadRequest(warehouseResult.Message);
            }
            catch (Exception ex)
            {
                Logger logger = await loggerService.CreateAsync(new Logger
                {
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ?"":ex.InnerException.Message,
                    CreatedDate = DateTime.Now,
                    MethodName= " PurchaseOrdersController.CreateOrder",
                    ProjectName= "Wms.Integration.API",
                    Statu="Error"
                }) ;
                return BadRequest($"İstenilmeyen bir hata ile karşılaşıldı! Error Id:{logger.Id} "); 
            }
        }

        [HttpPost("CreateMovement")]
        public async Task<IActionResult> CreateHareket([FromBody] CreatePurchaseWorkOrderDto dto)
        {
            try
            {
                IDataResult<SysWarehouse> dataResult=await warehouseService.GetCodeAsync(dto.WarehouseCode);
                if (!dataResult.Success)
                {
                    return BadRequest(dataResult.Message);
                }
                IDataResult<Arp> dataResult1=await arpService.GetCodeAsync(dto.ArpCode);
                if (!dataResult1.Success)
                {
                    return BadRequest(dataResult1.Message);
                }
                IDataResult<Item> itemResult;
                IDataResult<ItemUnit> itemUnitResult;
                IDataResult<SysAddress> addressResult;
                for (int i =0;i<dto.lines.Count;i++)
                {
                    itemResult = await itemService.GetCodeAsync(dto.lines[i].ItemCode);
                    if (!itemResult.Success)
                    {
                        return BadRequest(itemResult.Message + " Code : " + dto.lines[i].ItemCode);
                    }
                    dto.lines[i].ItemId = itemResult.Data.Id;
                    itemUnitResult = await itemUnitService.GetItemIdAsync(dto.lines[i].ItemId);
                    if (!itemUnitResult.Success)
                    {
                        return BadRequest(itemUnitResult.Message + " Code : " + dto.lines[i].ItemCode);
                    }
                    dto.lines[i].UnitId= itemUnitResult.Data.Id;
                    addressResult = await addressService.GetAddressAsync(dto.lines[i].AddresCode);
                    if (!addressResult.Success)
                    {
                        return BadRequest(addressResult.Message + " Code : " + dto.lines[i].AddresCode);
                    }
                    dto.lines[i].AddressId = addressResult.Data.Id;
                }

                IDataResult<WorkOrder>  workOrder =await purchaseService.CreateWorkOrderIAsync( new WorkOrder
                {
                    Id=0,
                    SlipType=1,
                    CustomSlipTypeId=null,
                    CarrierId=null,
                    SlipDate=DateTime.Now,
                    SlipNumber=dto.FaturaNo,//
                    ArpId=dataResult1.Data.Id,
                    DeliveryArpId=null,
                    ShipmentAddressId=null,
                    WarehouseId=dataResult.Data.Id,
                    Warehouse=dataResult.Data,
                    Warehouse2Id=null,
                    Warehouse2=null,
                    OrderSlipId=null,
                    PlanningSlipId=null,
                    ProductionOrderId=null,
                    ProdOrderLineId=null,
                    ParentWorkOrderId=null,
                    Description1 = dto.FaturaNo,
                    Description2 = dto.DocumentNumber,
                    Description3 = dto.DocTrackingNumber,
                    Description4 = "",
                    DocumentNumber = "Ismail Satin Alma",
                    DispatchNumber =null,
                    CustomCode=dto.SpeCode,
                    VehicleId=null,
                    DriverId=null,
                    DeclarationNumber=null,
                    ShipmentNumber=null,
                    CompletedDate=dto.CompletedDate,
                    CompletedBy=1,
                    DepartmentId=1,
                    DivisionId=1,
                    FactoryId=2,
                    Department2Id=null,
                    Division2Id=null,
                    Factory2Id=null,
                    SalesPersonId=null,
                    DocumentDate=DateTime.Now,
                    ProjectId=null,
                    Priority=0,
                    PrintCount=0,
                    StateId=14,
                    AuthCode=dto.SpeCode2,
                    Active=1,
                    CreatedDate=DateTime.Now,
                    CreatedBy=1,
                    ModifiedDate=DateTime.Now,
                    ModifiedBy=1,
                });
                if (!workOrder.Success)
                {
                    return  BadRequest(workOrder.Message);
                }
                IDataResult<Slip> slip=await slipService.CreateAsync(new Slip
                {
                    Id = 0,
                    SlipType = 1,
                    CustomSlipTypeId = null,
                    CarrierId = null,
                    SlipDate = DateTime.Now,
                    SlipNumber = dto.SlipNumber,
                    ArpId = dataResult1.Data.Id,
                    Arp=dataResult1.Data,
                    DeliveryArpId = null,
                    ShipmentAddressId = null,
                    WarehouseId = dataResult.Data.Id,
                    Warehouse = dataResult.Data,
                    Warehouse2Id = null,
                    OrderSlipId = null,
                    OrderSlip = null,
                    PlanningSlipId = null,
                    ProductionOrderId = null,
                    WorkOrderId = workOrder.Data.Id,
                    Description1 = dto.FaturaNo,
                    Description2 = dto.DocumentNumber,
                    Description3 = dto.DocTrackingNumber,
                    Description4 = "",
                    DispatchNumber = null,
                    DocumentNumber = "Ismail Satin Alma",
                    CustomCode = dto.SpeCode,
                    SlipSerialNumber="",
                    VehicleId=null,
                    DriverId=null,
                    DeclarationNumber=null,
                    ShipmentNumber=null,
                    CompletedDate=dto.CompletedDate,
                    CompletedBy=1,
                    DepartmentId=1,
                    DivisionId=1,
                    FactoryId=2,
                    Department2Id=null,
                    Division2Id=null,
                    Factory2Id=null,
                    SalesPersonId=null,
                    DocumentDate=DateTime.Now,
                    ProjectId=null,
                    Priority=0,
                    PrintCount=0,
                    StateId=18,
                    AuthCode=dto.SpeCode2,
                    Active=1,
                    CreatedDate=DateTime.Now,
                    CreatedBy=1,
                    ModifiedDate=DateTime.Now,
                    ModifiedBy=1,
                });
                if (!slip.Success)
                {
                    return BadRequest(slip.Message);
                }

                for (int i = 0; i < dto.lines.Count; i++)
                {
                    IDataResult<WorkOrderLine> workOrderLine= await workOrderLineService.CreateAsync(new WorkOrderLine
                    {
                        Id = 0,
                        SlipId = workOrder.Data.Id,
                        LineDate = DateTime.Now,
                        LineNumber = i + 1,
                        OrderSlipLineId=null,
                        PlanningSlipLineId=null,
                        ProdOrderLineId=null,
                        WarehouseId=dataResult.Data.Id,
                        Warehouse2Id=null,
                        DepartmentId=1,
                        DivisionId=1,
                        FactoryId=2,
                        Department2Id=null,
                        Division2Id=null,
                        Factory2Id=null,
                        ArpId=dataResult1.Data.Id,
                        Arp=dataResult1.Data,
                        ItemId = dto.lines[i].ItemId,
                        VariantId=null,
                        UnitId = dto.lines[i].UnitId,
                        ShipmentAddressId=null,
                        AssignedTo=null,
                        Description = dto.lines[i].Description,
                        Quantity= dto.lines[i].Quantity,
                        AddressId=dto.lines[i].AddressId,
                        Address2Id=null,
                        PropertyBarcode=null,
                        ConvFactor1=1,
                        ConvFactor2=1,
                        CustomCode=null,
                        ProjectId=null,
                        ContainerId=null,
                        ChildContainerId=null,
                        Container2Id=null,
                        ChildContainer2Id=null,
                        Priority=0,
                        StateId=14,
                        Closed=0,
                        AuthCode=dto.lines[i].AuthCode,
                        ParentLineId=null,
                        Active=1,
                        CreatedDate=DateTime.Now,
                        CreatedBy=1,
                        ModifiedDate=null,
                        ModifiedBy=null
                    });
                    if (!workOrderLine.Success)
                    {
                        return BadRequest(workOrderLine.Message);
                    }
                    IDataResult<TransactionDetail> transactionDetail=await transactionDetailService.CreateAsync(new TransactionDetail
                    {
                        Id = 0,
                        IoCode = 1,
                        LineType = 4,
                        TrCode = 1,
                        ParentLineId = 1,
                        OrderSlipId = null,
                        PlanningSlipId = null,
                        ProductionOrderId = null,
                        WorkOrderId = workOrder.Data.Id,
                        SlipId = null,
                        ReservationSlipId = null,
                        OrderSlipLineId = null,
                        PlanningSlipLineId = null,
                        ProdOrderLineId = null,
                        WorkOrderLineId = workOrderLine.Data.Id,
                        SlipLineId = null,
                        ReservationLineId = null,
                        LineDate = DateTime.Now,
                        LineDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        WarehouseId = dataResult.Data.Id,
                        ArpId = dataResult1.Data.Id,
                        ItemId = dto.lines[i].ItemId,
                        VariantId = null,
                        UnitId = dto.lines[i].UnitId,
                        Quantity = dto.lines[i].Quantity,
                        AddressId = dto.lines[i].AddressId,
                        ConvFactor1=1,
                        ConvFactor2= 1,
                        ExpirationDate = dto.lines[i].ExpirationDate,
                        ProductionDate=null,
                        TrackingNumber = dto.lines[i].TrackingNumber,
                        ContainerId=null,
                        ChildContainerId=null,
                        Active=1
                    });
                    if (!transactionDetail.Success)
                    {
                        return BadRequest(transactionDetail.Message);
                    }
                    IDataResult<SlipLine> slipLine= await slipLineService.CreateAsync( new SlipLine
                    {
                        Id=0,
                        SlipType=1,
                        SlipId=slip.Data.Id,
                        LineNumber=i+1,
                        OrderSlipLine=null,
                        PlanningSlipLineId=null,
                        ProdOrderLineId=null,
                        WorkOrderLineId=workOrderLine.Data.Id,
                        WarehouseId=dataResult.Data.Id,
                        Warehouse2Id=null,
                        DepartmentId=1,
                        DivisionId=1,
                        FactoryId=2,
                        Department2Id=null,
                        Division2Id=null,
                        Factory2Id=null,
                        ArpId=dataResult1.Data.Id,
                        ItemId=dto.lines[i].ItemId,
                        VariantId=null,
                        UnitId=dto.lines[i].UnitId,
                        ShipmentAddressId=null,
                        AssignedTo=null,
                        Description=dto.lines[i].Description,
                        Quantity=dto.lines[i].Quantity,
                        AddressId=dto.lines[i].AddressId,
                        Address2Id=null,
                        PropertyBarcode=null,
                        ConvFactor1=1,
                        ConvFactor2=1,
                        CustomCode="",
                        ProjectId=null,
                        ContainerId=null,
                        ChildContainerId=null,
                        Container2Id=null,
                        ChildContainer2Id=null,
                        InsuranceDuration=null,
                        InsuranceExpDate=null,
                        StateId=18,
                        Approval=1,
                        AuthCode=dto.lines[i].AuthCode,
                        Active=1,
                        CreatedDate=DateTime.Now,
                        CreatedBy=1,
                        ModifiedDate=null,
                        ModifiedBy=null
                    });
                    if (!slipLine.Success)
                    {
                        return BadRequest(slipLine.Message);
                    }
                    IDataResult<TransactionDetail> transactionDetail2=await transactionDetailService.CreateAsync(new TransactionDetail
                    {
                        Id = 0,
                        IoCode = 1,
                        LineType = 5,
                        TrCode = 1,
                        ParentLineId = 1,
                        OrderSlipId = 0,
                        PlanningSlipId = null,
                        ProductionOrderId = null,
                        WorkOrderId = workOrder.Data.Id,
                        SlipId = slip.Data.Id,
                        ReservationSlipId = null,
                        OrderSlipLineId = null,
                        PlanningSlipLineId = null,
                        ProdOrderLineId = null,
                        WorkOrderLineId = workOrderLine.Data.Id,
                        SlipLineId = slipLine.Data.Id,
                        ReservationLineId = null,
                        LineDate = DateTime.Now,
                        LineDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day),
                        WarehouseId = dataResult.Data.Id,
                        ArpId = dataResult1.Data.Id,
                        ItemId = dto.lines[i].ItemId,
                        VariantId = null,
                        UnitId = dto.lines[i].UnitId,
                        Quantity = dto.lines[i].Quantity,
                        AddressId = dto.lines[i].AddressId,
                        ConvFactor1=1,
                        ConvFactor2= 1,
                        ExpirationDate = dto.lines[i].ExpirationDate,
                        ProductionDate=null,
                        TrackingNumber = dto.lines[i].TrackingNumber,
                        ContainerId=null,
                        ChildContainerId=null,
                        Active=1
                    });
                    if (!transactionDetail2.Success)
                    {
                        return BadRequest(transactionDetail2.Message);
                    }
                }
                return Ok("Kaydetme İşlemi başarılı");
            }
            catch (Exception ex)
            {
                Logger logger = await loggerService.CreateAsync(new Logger
                {
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ?"":ex.InnerException.Message,
                    CreatedDate = DateTime.Now,
                    MethodName= "PurchaseOrdersController.CreateOrder",
                    ProjectName= "Wms.Integration.API",
                    Statu="Error"
                }) ;
                return BadRequest($"İstenilmeyen bir hata ile karşılaşıldı! Error Id:{logger.Id}");
            }
        }
    }
}
