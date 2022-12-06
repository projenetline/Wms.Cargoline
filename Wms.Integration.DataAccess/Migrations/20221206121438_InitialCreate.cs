using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wms.Integration.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Arp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Address1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Address2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Town = table.Column<string>(type: "nvarchar(51)", maxLength: 51, nullable: true),
            //        City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PostCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PhoneNumber1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PhoneNumber2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        FaxNumber1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        FaxNumber2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TaxOffice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TaxCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Contact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Url = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
            //        CityCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CardType = table.Column<short>(type: "smallint", nullable: false),
            //        Distance = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Arp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Carrier",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Address1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Address2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PhoneNumber1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PhoneNumber2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        FaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Carrier", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DecompositionShelf",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: false),
            //        Capacity = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DecompositionShelf", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Document",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        RecordType = table.Column<short>(type: "smallint", nullable: false),
            //        RecordId = table.Column<int>(type: "int", nullable: true),
            //        DocumentType = table.Column<short>(type: "smallint", nullable: false),
            //        DocumentNumber = table.Column<short>(type: "smallint", nullable: false),
            //        MimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        DocumentData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //        Thumbnail = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Document", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ERPInvTotal",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        STOCKREF = table.Column<int>(type: "int", nullable: true),
            //        CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        VARIANTREF = table.Column<int>(type: "int", nullable: true),
            //        VARIANTCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        SERILOTN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        EXPDATE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        LINEEXP = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
            //        UNITCODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CONVFACT1 = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        CONVFACT2 = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        UNITREF = table.Column<int>(type: "int", nullable: true),
            //        ONHAND = table.Column<decimal>(type: "numeric(28,8)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ERPInvTotal", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "History",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ActionType = table.Column<short>(type: "smallint", nullable: false),
            //        RecordType = table.Column<short>(type: "smallint", nullable: false),
            //        RecordId = table.Column<int>(type: "int", nullable: false),
            //        TransactionGuid = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        RecordContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_History", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HistoryDetail",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        HistoryId = table.Column<int>(type: "int", nullable: false),
            //        FieldName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        FieldValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_HistoryDetail", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "HttpLogger",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        FullUrl = table.Column<string>(type: "NVarChar(max)", nullable: true),
            //        Body = table.Column<string>(type: "NVarChar(max)", nullable: true),
            //        LocalIp = table.Column<string>(type: "NVarChar(max)", nullable: true),
            //        RemoteIp = table.Column<string>(type: "NVarChar(max)", nullable: true),
            //        LocalPort = table.Column<int>(type: "Int", nullable: false),
            //        RemotePort = table.Column<int>(type: "Int", nullable: false),
            //        ResponseStatu = table.Column<int>(type: "Int", nullable: false),
            //        Response = table.Column<string>(type: "NVarChar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_HttpLogger", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Item",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(160)", maxLength: 160, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        ItemGroupCode = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
            //        Name2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        WarrantyPeriod = table.Column<short>(type: "smallint", nullable: false),
            //        TrackingType = table.Column<short>(type: "smallint", nullable: false),
            //        VatRate = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        ShelfLife = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        IsoNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        GroupCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ManufacturerCode = table.Column<string>(type: "nvarchar(101)", maxLength: 101, nullable: true),
            //        SuppWarrantyPeriod = table.Column<int>(type: "int", nullable: true),
            //        CardType = table.Column<short>(type: "smallint", nullable: false),
            //        CriticalShelfLife = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
            //        AbcClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        QualityControl = table.Column<short>(type: "smallint", nullable: false),
            //        ColdStorage = table.Column<short>(type: "smallint", nullable: false),
            //        CustomCode1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CustomCode2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CustomCode3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CustomCode4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CustomCode5 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ShipmentLife = table.Column<short>(type: "smallint", nullable: false),
            //        CriticalShipLife = table.Column<short>(type: "smallint", nullable: false),
            //        SupplyPeriod = table.Column<short>(type: "smallint", nullable: false),
            //        TrackingMethod = table.Column<short>(type: "smallint", nullable: false),
            //        NearTracking = table.Column<short>(type: "smallint", nullable: false),
            //        NearTrackingDay = table.Column<short>(type: "smallint", nullable: false),
            //        ParentItemId = table.Column<int>(type: "int", nullable: true),
            //        ExportClassNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ErpTrackingType = table.Column<short>(type: "smallint", nullable: false),
            //        CanConfigure = table.Column<short>(type: "smallint", nullable: false),
            //        InputOverageType = table.Column<short>(type: "smallint", nullable: false),
            //        InputOverageLimit = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        OutputOverageType = table.Column<short>(type: "smallint", nullable: false),
            //        OutputOverageLimit = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true),
            //        CanDeduct = table.Column<short>(type: "smallint", nullable: false),
            //        DeductCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
            //        SaleDeductionPart1 = table.Column<short>(type: "smallint", nullable: false),
            //        SaleDeductionPart2 = table.Column<short>(type: "smallint", nullable: false),
            //        PurchDeductionPart1 = table.Column<short>(type: "smallint", nullable: false),
            //        PurchDeductionPart2 = table.Column<short>(type: "smallint", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Item", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_Item_ParentItemId",
            //            column: x => x.ParentItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ItemExtra",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "Int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Skt = table.Column<DateTime>(type: "DateTime", nullable: false),
            //        Description = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
            //        Description2 = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ItemExtra", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Logger",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "DateTime", nullable: false),
            //        MethodName = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
            //        ProjectName = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
            //        Message1 = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
            //        Message2 = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
            //        Statu = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Logger", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "LoginHistory",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Application = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        IsSuccess = table.Column<short>(type: "smallint", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_LoginHistory", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Project",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Responsible = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CustomCode2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CustomCode3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CustomCode4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CustomCode5 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Project", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SalesPerson",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SalesPerson", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ShiftPeriod",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ShiftId = table.Column<int>(type: "int", nullable: false),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ShiftPeriod", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ShipmentAddress",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TradingGroupCode = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
            //        Address1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Address2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CityCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CountryCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Town = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TownCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        District = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DistrictCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PostCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PhoneNumber1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PhoneNumber2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        FaxNumber1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        FaxNumber2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TaxOffice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TaxCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Url = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ShipmentAddress", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysBlockingType",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysBlockingType", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysContainerType",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        ItemId = table.Column<int>(type: "int", nullable: true),
            //        LPNPrefix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        LPNLength = table.Column<short>(type: "smallint", nullable: false),
            //        LPNContainsDate = table.Column<short>(type: "smallint", nullable: false),
            //        Width = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Height = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Length = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Weight = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Volume = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        DimensionWeight = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        ItemsFilter = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysContainerType", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysCustomCode",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        CodeType = table.Column<short>(type: "smallint", nullable: false),
            //        ParentId = table.Column<int>(type: "int", nullable: true),
            //        ForegroundColor = table.Column<int>(type: "int", nullable: true),
            //        Backgroundcolor = table.Column<int>(type: "int", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysCustomCode", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysCustomReport",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ReportType = table.Column<short>(type: "smallint", nullable: false),
            //        QueryContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DesignContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        TemplateNumber = table.Column<short>(type: "smallint", nullable: false),
            //        MenuNumber = table.Column<int>(type: "int", nullable: false),
            //        IsDefault = table.Column<short>(type: "smallint", nullable: false),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysCustomReport", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysCustomRule",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        AutoRun = table.Column<short>(type: "smallint", nullable: false),
            //        AutoRunObject = table.Column<short>(type: "smallint", nullable: false),
            //        AutoRunAction = table.Column<short>(type: "smallint", nullable: false),
            //        AutoRunEvent = table.Column<short>(type: "smallint", nullable: false),
            //        MenuBound = table.Column<short>(type: "smallint", nullable: false),
            //        MenuContext = table.Column<short>(type: "smallint", nullable: false),
            //        Scheduled = table.Column<short>(type: "smallint", nullable: false),
            //        ScheduleType = table.Column<short>(type: "smallint", nullable: false),
            //        ScheduleInterval = table.Column<short>(type: "smallint", nullable: false),
            //        SchedulePeriod = table.Column<short>(type: "smallint", nullable: false),
            //        ScheduleTime = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
            //        ScheduleWeekDay = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
            //        ScheduleDay = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true),
            //        ScheduleMonth = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysCustomRule", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysCustomSlipType",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        ErpIntegration = table.Column<short>(type: "smallint", nullable: false),
            //        ErpRecordType = table.Column<short>(type: "smallint", nullable: false),
            //        ErpRecordTrCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ErpSlipType = table.Column<short>(type: "smallint", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysCustomSlipType", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysCustomState",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RecordType = table.Column<short>(type: "smallint", nullable: false),
            //        StateNumber = table.Column<short>(type: "smallint", nullable: false),
            //        StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        SystemEvent = table.Column<short>(type: "smallint", nullable: false),
            //        IsDefault = table.Column<short>(type: "smallint", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysCustomState", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysCustomTable",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RecordType = table.Column<short>(type: "smallint", nullable: false),
            //        TableName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        TableDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysCustomTable", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysDepartment",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysDepartment", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysDivision",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysDivision", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysErp",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ErpType = table.Column<short>(type: "smallint", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        ConnectionType = table.Column<short>(type: "smallint", nullable: false),
            //        EndpointUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        ApiUrl1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        ApiUrl2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        ApiUrl3 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Port = table.Column<int>(type: "int", nullable: false),
            //        TimeOut = table.Column<int>(type: "int", nullable: false),
            //        Language = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        FirmNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DbType = table.Column<short>(type: "smallint", nullable: false),
            //        DbName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DbUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DbPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        LCNPort = table.Column<int>(type: "int", nullable: false),
            //        LCNApiUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        LCNVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysErp", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysLog",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        LogDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ThreadId = table.Column<int>(type: "int", nullable: false),
            //        LogLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Logger = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        LogMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Exception = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //        StackTrace = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Arguments = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
            //        CustomerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        IpAddressPort = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        MethodName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        TaskGuid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ProcessGroup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ProductVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        UserId = table.Column<int>(type: "int", nullable: true),
            //        UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: true),
            //        RecordType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        RecordId = table.Column<int>(type: "int", nullable: true),
            //        ErpId = table.Column<int>(type: "int", nullable: true),
            //        ErpDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        ErpFirmNumber = table.Column<int>(type: "int", nullable: true),
            //        ErpPeriodBranch = table.Column<int>(type: "int", nullable: true),
            //        ErpRecordType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ErpRecordId = table.Column<int>(type: "int", nullable: true),
            //        ErpRecordParameters = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysLog", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysParameter",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ParameterType = table.Column<short>(type: "smallint", nullable: false),
            //        ParameterTypeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ParameterNumber = table.Column<int>(type: "int", nullable: false),
            //        ParameterValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysParameter", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysPasswordPolicy",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        PasswordExpression = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        FailedAttempts = table.Column<short>(type: "smallint", nullable: false),
            //        RememberCount = table.Column<short>(type: "smallint", nullable: false),
            //        MinimumAge = table.Column<short>(type: "smallint", nullable: false),
            //        MaximumAge = table.Column<short>(type: "smallint", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysPasswordPolicy", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysPrinter",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        GroupCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        LineNumber = table.Column<int>(type: "int", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysPrinter", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysScript",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ScriptType = table.Column<short>(type: "smallint", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //        Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysScript", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Decomposition",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: false),
            //        DecompositionShelfId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        IsCompleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Decomposition", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Decomposition_DecompositionShelf_DecompositionShelfId",
            //            column: x => x.DecompositionShelfId,
            //            principalTable: "DecompositionShelf",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DecompositionShelves",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: false),
            //        Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DecompositionShelfId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DecompositionShelves", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_DecompositionShelves_DecompositionShelf_DecompositionShelfId",
            //            column: x => x.DecompositionShelfId,
            //            principalTable: "DecompositionShelf",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ItemClassRelation",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ClassId = table.Column<int>(type: "int", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ItemClassRelation", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_ItemClassRelation_ClassId",
            //            column: x => x.ClassId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ItemClassRelation_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ItemUnit",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //        IsMasterUnit = table.Column<short>(type: "smallint", nullable: false),
            //        ConvFactor1 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        ConvFactor2 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        OldBarcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        UnitNumber = table.Column<short>(type: "smallint", nullable: false),
            //        Width = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        GrossWeight = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Height = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Length = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Weight = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Volume = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        GrossVolume = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        SlipPriority = table.Column<short>(type: "smallint", nullable: false),
            //        ReceivePriority = table.Column<short>(type: "smallint", nullable: false),
            //        ShipmentPriority = table.Column<short>(type: "smallint", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ItemUnit", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_ItemUnit_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ShipmentDay",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        ShipmentAddressId = table.Column<int>(type: "int", nullable: true),
            //        ShipmentDay = table.Column<short>(type: "smallint", nullable: false),
            //        StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        FinishTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ShipmentDay", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_ShipmentDay_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_ShipmentDay_ShipmentAddressId",
            //            column: x => x.ShipmentAddressId,
            //            principalTable: "ShipmentAddress",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysBlockingException",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        BlockingTypeId = table.Column<int>(type: "int", nullable: false),
            //        CustomSlipTypeId = table.Column<int>(type: "int", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysBlockingException", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysBlockingException_Type",
            //            column: x => x.BlockingTypeId,
            //            principalTable: "SysBlockingType",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Container",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ContainerTypeId = table.Column<int>(type: "int", nullable: false),
            //        LPN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        PrintCount = table.Column<int>(type: "int", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Container", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_Container_ContainerTypeId",
            //            column: x => x.ContainerTypeId,
            //            principalTable: "SysContainerType",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysContainerRelation",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ParentId = table.Column<int>(type: "int", nullable: false),
            //        ChildId = table.Column<int>(type: "int", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysContainerRelation", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysContainerRelation_ChildId",
            //            column: x => x.ChildId,
            //            principalTable: "SysContainerType",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysContainerRelation_ParentId",
            //            column: x => x.ParentId,
            //            principalTable: "SysContainerType",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysCustomListColumn",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        MenuNumber = table.Column<int>(type: "int", nullable: false),
            //        ReportId = table.Column<int>(type: "int", nullable: true),
            //        ReportColumns = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ReportParameters = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysCustomListColumn", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysCustomListColumn_ReportId",
            //            column: x => x.ReportId,
            //            principalTable: "SysCustomReport",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysCustomRuleAction",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RuleId = table.Column<int>(type: "int", nullable: false),
            //        ActionNumber = table.Column<short>(type: "smallint", nullable: false),
            //        ActionType = table.Column<short>(type: "smallint", nullable: false),
            //        PreAction = table.Column<short>(type: "smallint", nullable: false),
            //        PreCondition = table.Column<short>(type: "smallint", nullable: false),
            //        IsRuleResult = table.Column<short>(type: "smallint", nullable: false),
            //        Template = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysCustomRuleAction", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysCustomRuleAction_RuleId",
            //            column: x => x.RuleId,
            //            principalTable: "SysCustomRule",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysFactory",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysFactory", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysFactory_DivisionId",
            //            column: x => x.DivisionId,
            //            principalTable: "SysDivision",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysErpFirm",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ErpId = table.Column<int>(type: "int", nullable: false),
            //        ParentFirmId = table.Column<int>(type: "int", nullable: true),
            //        ErpFirmNumber = table.Column<int>(type: "int", nullable: false),
            //        ErpFirmName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        ErpBranchNumber = table.Column<int>(type: "int", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysErpFirm", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysErpFirm_ErpId",
            //            column: x => x.ErpId,
            //            principalTable: "SysErp",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysRole",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        PasswordPolicyId = table.Column<int>(type: "int", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysRole", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysRole_PolicyId",
            //            column: x => x.PasswordPolicyId,
            //            principalTable: "SysPasswordPolicy",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ItemContent",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ParentItemId = table.Column<int>(type: "int", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        Quantity = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        UnitId = table.Column<int>(type: "int", nullable: false),
            //        LineNumber = table.Column<int>(type: "int", nullable: false),
            //        Percentage = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        RateOfWaste = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ItemContent", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_ItemContent_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_ItemContent_ParentItemId",
            //            column: x => x.ParentItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ItemContent_UnitId",
            //            column: x => x.UnitId,
            //            principalTable: "ItemUnit",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UnitBarcode",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        UnitId = table.Column<int>(type: "int", nullable: false),
            //        Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        BarcodeType = table.Column<short>(type: "smallint", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UnitBarcode", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_UnitBarcode_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_UnitBarcode_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_UnitBarcode_UnitId",
            //            column: x => x.UnitId,
            //            principalTable: "ItemUnit",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductionOrder",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        SlipNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        SlipDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Description1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        MaterialPull = table.Column<short>(type: "smallint", nullable: false),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        VariantId = table.Column<int>(type: "int", nullable: true),
            //        UnitId = table.Column<int>(type: "int", nullable: false),
            //        ConvFactor1 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        ConvFactor2 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        Quantity = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DueDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PauseDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PlannedStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PlannedEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PlannedTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ProductionStatus = table.Column<short>(type: "smallint", nullable: false),
            //        Approval = table.Column<short>(type: "smallint", nullable: false),
            //        ProjectId = table.Column<int>(type: "int", nullable: true),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductionOrder", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_ProductionOrder_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ProductionOrder_FactoryId",
            //            column: x => x.FactoryId,
            //            principalTable: "SysFactory",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ProductionOrder_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ProductionOrder_ProjectId",
            //            column: x => x.ProjectId,
            //            principalTable: "Project",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ProductionOrder_UnitId",
            //            column: x => x.UnitId,
            //            principalTable: "ItemUnit",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysWarehouse",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        CostGroup = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Width = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Depth = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Height = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysWarehouse", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysWarehouse_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "SysDepartment",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysWarehouse_DivisionId",
            //            column: x => x.DivisionId,
            //            principalTable: "SysDivision",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysWarehouse_FactoryId",
            //            column: x => x.FactoryId,
            //            principalTable: "SysFactory",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysErpIntegration",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ErpId = table.Column<int>(type: "int", nullable: false),
            //        ErpFirmId = table.Column<int>(type: "int", nullable: false),
            //        RecordType = table.Column<short>(type: "smallint", nullable: false),
            //        RecordId = table.Column<int>(type: "int", nullable: false),
            //        ErpRecordType = table.Column<short>(type: "smallint", nullable: false),
            //        ErpRecordTrCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ErpRecordId = table.Column<int>(type: "int", nullable: true),
            //        ErpRelatedTransId = table.Column<int>(type: "int", nullable: true),
            //        ErpRelatedLineId = table.Column<int>(type: "int", nullable: true),
            //        ErpRecordCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ErpRecordParameters = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        ErpPeriodNumber = table.Column<int>(type: "int", nullable: true),
            //        ErpModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        IsMasterRecord = table.Column<short>(type: "smallint", nullable: false),
            //        IntegrationStatus = table.Column<short>(type: "smallint", nullable: false),
            //        IntegrationDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysErpIntegration", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysErpIntegration_ErpId",
            //            column: x => x.ErpId,
            //            principalTable: "SysErp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysErpIntegration_FirmId",
            //            column: x => x.ErpFirmId,
            //            principalTable: "SysErpFirm",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysMenuRight",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleId = table.Column<int>(type: "int", nullable: false),
            //        MenuId = table.Column<int>(type: "int", nullable: false),
            //        OperationType = table.Column<short>(type: "smallint", nullable: false),
            //        OnlyOwnItems = table.Column<short>(type: "smallint", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysMenuRight", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysMenuRight_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "SysRole",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ProductionOrderLine",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipId = table.Column<int>(type: "int", nullable: false),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        LineNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        VariantId = table.Column<int>(type: "int", nullable: true),
            //        UnitId = table.Column<int>(type: "int", nullable: false),
            //        ConvFactor1 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        ConvFactor2 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        ProjectId = table.Column<int>(type: "int", nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PlannedQuantity = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        PlannedStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PlannedEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PlannedTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ActualStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ActualEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ActualTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ProductionStatus = table.Column<short>(type: "smallint", nullable: false),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProductionOrderLine", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_ProductionOrderLine_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ProductionOrderLine_FactoryId",
            //            column: x => x.FactoryId,
            //            principalTable: "SysFactory",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ProductionOrderLine_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ProductionOrderLine_ProjectId",
            //            column: x => x.ProjectId,
            //            principalTable: "Project",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ProductionOrderLine_SlipId",
            //            column: x => x.SlipId,
            //            principalTable: "ProductionOrder",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_ProductionOrderLine_UnitId",
            //            column: x => x.UnitId,
            //            principalTable: "ItemUnit",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ProductionOrderLine_VariantId",
            //            column: x => x.VariantId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ItemParameter",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        MinQuantity = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        MaxQuantity = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        SafeQuantity = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        AbcCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        MinLevelAction = table.Column<short>(type: "smallint", nullable: false),
            //        MaxLevelAction = table.Column<short>(type: "smallint", nullable: false),
            //        SafeLevelAction = table.Column<short>(type: "smallint", nullable: false),
            //        NegativeLevelAction = table.Column<short>(type: "smallint", nullable: false),
            //        InputAction = table.Column<short>(type: "smallint", nullable: false),
            //        OutputAction = table.Column<short>(type: "smallint", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ItemParameter", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_ItemParameter_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_ItemParameter_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Shift",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: true),
            //        ShiftDay = table.Column<short>(type: "smallint", nullable: false),
            //        StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        FinishTime = table.Column<DateTime>(type: "datetime", nullable: true),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Shift", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_Shift_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysUser",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        IDMUsername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        EnabledMenuCodes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
            //        DisabledMenuCodes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
            //        RoleId = table.Column<int>(type: "int", nullable: false),
            //        PrinterId = table.Column<int>(type: "int", nullable: true),
            //        ScriptId = table.Column<int>(type: "int", nullable: true),
            //        BossId = table.Column<int>(type: "int", nullable: true),
            //        PhoneNumber1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PhoneNumber2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
            //        TerminalLanguage = table.Column<short>(type: "smallint", nullable: true),
            //        DefaultErpId = table.Column<int>(type: "int", nullable: true),
            //        DefaultErpFirmId = table.Column<int>(type: "int", nullable: true),
            //        DefaultWarehouseId = table.Column<int>(type: "int", nullable: true),
            //        PasswordPolicyId = table.Column<int>(type: "int", nullable: true),
            //        SSO = table.Column<short>(type: "smallint", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysUser", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysUser_BossId",
            //            column: x => x.BossId,
            //            principalTable: "SysUser",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysUser_ErpId",
            //            column: x => x.DefaultErpId,
            //            principalTable: "SysErp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysUser_FirmId",
            //            column: x => x.DefaultErpFirmId,
            //            principalTable: "SysErpFirm",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysUser_PolicyId",
            //            column: x => x.PasswordPolicyId,
            //            principalTable: "SysPasswordPolicy",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysUser_PrinterId",
            //            column: x => x.PrinterId,
            //            principalTable: "SysPrinter",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.SetNull);
            //        table.ForeignKey(
            //            name: "fk_SysUser_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "SysRole",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysUser_ScriptId",
            //            column: x => x.ScriptId,
            //            principalTable: "SysScript",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysUser_WarehouseId",
            //            column: x => x.DefaultWarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysWarehouseFloor",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysWarehouseFloor", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysWarehouseFloor_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vehicle",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        PlateNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        PlateNumber2 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        PlateNumber3 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        Model = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
            //        Year = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Owner = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Volume = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Weight = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Area = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Width = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Depth = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Height = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vehicle", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_Vehicle_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Driver",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        UserId = table.Column<int>(type: "int", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        LicenseType = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
            //        IdNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PhoneNumber1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PhoneNumber2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Driver", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_Driver_UserId",
            //            column: x => x.UserId,
            //            principalTable: "SysUser",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "FormLayout",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleId = table.Column<int>(type: "int", nullable: true),
            //        UserId = table.Column<int>(type: "int", nullable: true),
            //        FormId = table.Column<int>(type: "int", nullable: true),
            //        ComponentId = table.Column<int>(type: "int", nullable: true),
            //        LayoutType = table.Column<short>(type: "smallint", nullable: false),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Settings = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_FormLayout", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_FormLayout_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "SysRole",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_FormLayout_UserId",
            //            column: x => x.UserId,
            //            principalTable: "SysUser",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysAuthCode",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleId = table.Column<int>(type: "int", nullable: true),
            //        UserId = table.Column<int>(type: "int", nullable: true),
            //        RecordType = table.Column<short>(type: "smallint", nullable: false),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Permission = table.Column<short>(type: "smallint", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysAuthCode", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysAuthCode_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "SysRole",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_SysAuthCode_UserId",
            //            column: x => x.UserId,
            //            principalTable: "SysUser",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysNetLock",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FormName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
            //        RecordId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        SessionCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysNetLock", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysNetLock_CreatedBy",
            //            column: x => x.CreatedBy,
            //            principalTable: "SysUser",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysPasswordHistory",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysPasswordHistory", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysPasswordHistory_UserId",
            //            column: x => x.UserId,
            //            principalTable: "SysUser",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysSession",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        SessionCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        SpId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysSession", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysSession_UserId",
            //            column: x => x.UserId,
            //            principalTable: "SysUser",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysUserWarehouse",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        ErpId = table.Column<int>(type: "int", nullable: false),
            //        ErpFirmId = table.Column<int>(type: "int", nullable: false),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        IsDefault = table.Column<short>(type: "smallint", nullable: false),
            //        InputOutputRight = table.Column<short>(type: "smallint", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysUserWarehouse", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysUserWarehouse_FirmId",
            //            column: x => x.ErpFirmId,
            //            principalTable: "SysErpFirm",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysUserWarehouse_UserId",
            //            column: x => x.UserId,
            //            principalTable: "SysUser",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_SysUserWarehouse_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysWarehouseBlock",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        FloorId = table.Column<int>(type: "int", nullable: false),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        BlockType = table.Column<short>(type: "smallint", nullable: false),
            //        LocationZ = table.Column<short>(type: "smallint", nullable: false),
            //        LocationX = table.Column<short>(type: "smallint", nullable: false),
            //        LocationY = table.Column<short>(type: "smallint", nullable: false),
            //        Direction = table.Column<short>(type: "smallint", nullable: false),
            //        Height = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Width = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Depth = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        BlockCount = table.Column<short>(type: "smallint", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysWarehouseBlock", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysWarehouseBlock_FloorId",
            //            column: x => x.FloorId,
            //            principalTable: "SysWarehouseFloor",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysWarehouseBlock_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysWarehouseZone",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        FloorId = table.Column<int>(type: "int", nullable: false),
            //        SecurityLevel = table.Column<short>(type: "smallint", nullable: true, defaultValueSql: "((0))"),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('')"),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CreatedBy = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysWarehouseZone", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysWarehouseZone_FloorId",
            //            column: x => x.FloorId,
            //            principalTable: "SysWarehouseFloor",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysWarehouseZone_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OrderSlip",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        SlipNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        SlipDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        DeliveryArpId = table.Column<int>(type: "int", nullable: true),
            //        ShipmentAddressId = table.Column<int>(type: "int", nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: true),
            //        Warehouse2Id = table.Column<int>(type: "int", nullable: true),
            //        DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        Department2Id = table.Column<int>(type: "int", nullable: true),
            //        Division2Id = table.Column<int>(type: "int", nullable: true),
            //        Factory2Id = table.Column<int>(type: "int", nullable: true),
            //        DeliveryDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        DeliveryType = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
            //        CarrierId = table.Column<int>(type: "int", nullable: true),
            //        TradingGroupCode = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
            //        Priority = table.Column<short>(type: "smallint", nullable: false),
            //        SalesPersonId = table.Column<int>(type: "int", nullable: true),
            //        VehicleId = table.Column<int>(type: "int", nullable: true),
            //        DocTrackingNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        PrintCount = table.Column<int>(type: "int", nullable: false),
            //        CustomerOrderNumber = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
            //        ShipmentStatus = table.Column<short>(type: "smallint", nullable: false),
            //        StateId = table.Column<int>(type: "int", nullable: false),
            //        ProjectId = table.Column<int>(type: "int", nullable: true),
            //        ProductionOrderId = table.Column<int>(type: "int", nullable: true),
            //        ProdOrderLineId = table.Column<int>(type: "int", nullable: true),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CreatedBy = table.Column<int>(type: "int", nullable: true),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrderSlip", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_CarrierId",
            //            column: x => x.CarrierId,
            //            principalTable: "Carrier",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_DeliveryArpId",
            //            column: x => x.DeliveryArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "SysDepartment",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_DivisionId",
            //            column: x => x.DivisionId,
            //            principalTable: "SysDivision",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_FactoryId",
            //            column: x => x.FactoryId,
            //            principalTable: "SysFactory",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_ProjectId",
            //            column: x => x.ProjectId,
            //            principalTable: "Project",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_SalesPersonId",
            //            column: x => x.SalesPersonId,
            //            principalTable: "SalesPerson",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_ShipmentAddressId",
            //            column: x => x.ShipmentAddressId,
            //            principalTable: "ShipmentAddress",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_StateId",
            //            column: x => x.StateId,
            //            principalTable: "SysCustomState",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicle",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_Warehouse2Id",
            //            column: x => x.Warehouse2Id,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlip_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PlanningSlip",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        SlipNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        SlipDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ShipmentDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: true),
            //        Warehouse2Id = table.Column<int>(type: "int", nullable: true),
            //        CarrierId = table.Column<int>(type: "int", nullable: true),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        DeliveryArpId = table.Column<int>(type: "int", nullable: true),
            //        ShipmentAddressId = table.Column<int>(type: "int", nullable: true),
            //        Description1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Priority = table.Column<short>(type: "smallint", nullable: false),
            //        VehicleId = table.Column<int>(type: "int", nullable: true),
            //        DriverId = table.Column<int>(type: "int", nullable: true),
            //        ShipmentStatus = table.Column<short>(type: "smallint", nullable: false),
            //        StateId = table.Column<int>(type: "int", nullable: false),
            //        SalesPersonId = table.Column<int>(type: "int", nullable: true),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        Department2Id = table.Column<int>(type: "int", nullable: true),
            //        Division2Id = table.Column<int>(type: "int", nullable: true),
            //        Factory2Id = table.Column<int>(type: "int", nullable: true),
            //        PrintCount = table.Column<int>(type: "int", nullable: false),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PlanningSlip", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_DeliveryArpId",
            //            column: x => x.DeliveryArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "SysDepartment",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_DivisionId",
            //            column: x => x.DivisionId,
            //            principalTable: "SysDivision",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_DriverId",
            //            column: x => x.DriverId,
            //            principalTable: "Driver",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_FactoryId",
            //            column: x => x.FactoryId,
            //            principalTable: "SysFactory",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_SalesPersonId",
            //            column: x => x.SalesPersonId,
            //            principalTable: "SalesPerson",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_ShipmentAddressId",
            //            column: x => x.ShipmentAddressId,
            //            principalTable: "ShipmentAddress",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_StateId",
            //            column: x => x.StateId,
            //            principalTable: "SysCustomState",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicle",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_Warehouse2Id",
            //            column: x => x.Warehouse2Id,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlip_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SysAddress",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        FloorId = table.Column<int>(type: "int", nullable: true),
            //        ZoneId = table.Column<int>(type: "int", nullable: true),
            //        BlockId = table.Column<int>(type: "int", nullable: true),
            //        AddressType = table.Column<short>(type: "smallint", nullable: false),
            //        GroupCode = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
            //        Aisle = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        LineNumber = table.Column<int>(type: "int", nullable: false),
            //        Shelf = table.Column<short>(type: "smallint", nullable: false),
            //        XCoord = table.Column<short>(type: "smallint", nullable: false),
            //        YCoord = table.Column<short>(type: "smallint", nullable: false),
            //        ZCoord = table.Column<short>(type: "smallint", nullable: false),
            //        Width = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Height = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Length = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Depth = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Weight = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Volume = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ShipmentPriority = table.Column<short>(type: "smallint", nullable: false),
            //        PlacementPriority = table.Column<short>(type: "smallint", nullable: false),
            //        RfId = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
            //        Latitude = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Longitude = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        GpsAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SysAddress", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SysAddress_FloorId",
            //            column: x => x.FloorId,
            //            principalTable: "SysWarehouseFloor",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysAddress_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SysAddress_ZoneId",
            //            column: x => x.ZoneId,
            //            principalTable: "SysWarehouseZone",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "OrderSlipLine",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        SlipId = table.Column<int>(type: "int", nullable: false),
            //        LineNumber = table.Column<int>(type: "int", nullable: false),
            //        LineDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        VariantId = table.Column<int>(type: "int", nullable: true),
            //        UnitId = table.Column<int>(type: "int", nullable: false),
            //        ShipmentAddressId = table.Column<int>(type: "int", nullable: true),
            //        Quantity = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DeliveryDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        PropertyBarcode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        ProjectId = table.Column<int>(type: "int", nullable: true),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        Department2Id = table.Column<int>(type: "int", nullable: true),
            //        Division2Id = table.Column<int>(type: "int", nullable: true),
            //        Factory2Id = table.Column<int>(type: "int", nullable: true),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        Warehouse2Id = table.Column<int>(type: "int", nullable: true),
            //        AssignedTo = table.Column<int>(type: "int", nullable: true),
            //        DocumentType = table.Column<short>(type: "smallint", nullable: false),
            //        ConvFactor1 = table.Column<decimal>(type: "numeric(28,8)", nullable: true, defaultValueSql: "((1))"),
            //        ConvFactor2 = table.Column<decimal>(type: "numeric(28,8)", nullable: true, defaultValueSql: "((1))"),
            //        Priority = table.Column<short>(type: "smallint", nullable: false),
            //        Closed = table.Column<short>(type: "smallint", nullable: false),
            //        ShipmentStatus = table.Column<short>(type: "smallint", nullable: false),
            //        StateId = table.Column<int>(type: "int", nullable: false),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrderSlipLine", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_OrderSlipLine_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlipLine_AssignedTo",
            //            column: x => x.AssignedTo,
            //            principalTable: "SysUser",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlipLine_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "SysDepartment",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlipLine_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlipLine_ProjectId",
            //            column: x => x.ProjectId,
            //            principalTable: "Project",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlipLine_SlipId",
            //            column: x => x.SlipId,
            //            principalTable: "OrderSlip",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_OrderSlipLine_StateId",
            //            column: x => x.StateId,
            //            principalTable: "SysCustomState",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlipLine_UnitId",
            //            column: x => x.UnitId,
            //            principalTable: "ItemUnit",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlipLine_VariantId",
            //            column: x => x.VariantId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlipLine_Warehouse2Id",
            //            column: x => x.Warehouse2Id,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_OrderSlipLine_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "WorkOrder",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        CustomSlipTypeId = table.Column<int>(type: "int", nullable: true),
            //        CarrierId = table.Column<int>(type: "int", nullable: true),
            //        SlipDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        SlipNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        DeliveryArpId = table.Column<int>(type: "int", nullable: true),
            //        ShipmentAddressId = table.Column<int>(type: "int", nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        Warehouse2Id = table.Column<int>(type: "int", nullable: true),
            //        OrderSlipId = table.Column<int>(type: "int", nullable: true),
            //        PlanningSlipId = table.Column<int>(type: "int", nullable: true),
            //        ProductionOrderId = table.Column<int>(type: "int", nullable: true),
            //        ProdOrderLineId = table.Column<int>(type: "int", nullable: true),
            //        ParentWorkOrderId = table.Column<int>(type: "int", nullable: true),
            //        Description1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DispatchNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        VehicleId = table.Column<int>(type: "int", nullable: true),
            //        DriverId = table.Column<int>(type: "int", nullable: true),
            //        DeclarationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        ShipmentNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        CompletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CompletedBy = table.Column<int>(type: "int", nullable: true),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        Department2Id = table.Column<int>(type: "int", nullable: true),
            //        Division2Id = table.Column<int>(type: "int", nullable: true),
            //        Factory2Id = table.Column<int>(type: "int", nullable: true),
            //        SalesPersonId = table.Column<int>(type: "int", nullable: true),
            //        DocumentDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ProjectId = table.Column<int>(type: "int", nullable: true),
            //        Priority = table.Column<short>(type: "smallint", nullable: false),
            //        PrintCount = table.Column<int>(type: "int", nullable: false),
            //        StateId = table.Column<int>(type: "int", nullable: false),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_WorkOrder", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_CustomSlipTypeId",
            //            column: x => x.CustomSlipTypeId,
            //            principalTable: "SysCustomSlipType",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_DeliveryArpId",
            //            column: x => x.DeliveryArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "SysDepartment",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_DivisionId",
            //            column: x => x.DivisionId,
            //            principalTable: "SysDivision",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_DriverId",
            //            column: x => x.DriverId,
            //            principalTable: "Driver",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_FactoryId",
            //            column: x => x.FactoryId,
            //            principalTable: "SysFactory",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_OrderSlipId",
            //            column: x => x.OrderSlipId,
            //            principalTable: "OrderSlip",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_PlanningSlipId",
            //            column: x => x.PlanningSlipId,
            //            principalTable: "PlanningSlip",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_ProdOrderLineId",
            //            column: x => x.ProdOrderLineId,
            //            principalTable: "ProductionOrderLine",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_ProductionOrderId",
            //            column: x => x.ProductionOrderId,
            //            principalTable: "ProductionOrder",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_ProjectId",
            //            column: x => x.ProjectId,
            //            principalTable: "Project",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_SalesPersonId",
            //            column: x => x.SalesPersonId,
            //            principalTable: "SalesPerson",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_ShipmentAddressId",
            //            column: x => x.ShipmentAddressId,
            //            principalTable: "ShipmentAddress",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_StateId",
            //            column: x => x.StateId,
            //            principalTable: "SysCustomState",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicle",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_Warehouse2Id",
            //            column: x => x.Warehouse2Id,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrder_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AddressItem",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        AddressId = table.Column<int>(type: "int", nullable: false),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        UnitId = table.Column<int>(type: "int", nullable: false),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        MinQuantity = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        MaxQuantity = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        ShipmentPriority = table.Column<short>(type: "smallint", nullable: false),
            //        PlacementPriority = table.Column<short>(type: "smallint", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AddressItem", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_AddressItem_AddressId",
            //            column: x => x.AddressId,
            //            principalTable: "SysAddress",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_AddressItem_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_AddressItem_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PlanningSlipLine",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        SlipId = table.Column<int>(type: "int", nullable: false),
            //        OrderSlipId = table.Column<int>(type: "int", nullable: true),
            //        OrderSlipLineId = table.Column<int>(type: "int", nullable: true),
            //        ArpId = table.Column<int>(type: "int", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        VariantId = table.Column<int>(type: "int", nullable: true),
            //        UnitId = table.Column<int>(type: "int", nullable: false),
            //        ShipmentAddressId = table.Column<int>(type: "int", nullable: true),
            //        AddressId = table.Column<int>(type: "int", nullable: true),
            //        Address2Id = table.Column<int>(type: "int", nullable: true),
            //        Quantity = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        Warehouse2Id = table.Column<int>(type: "int", nullable: true),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        Department2Id = table.Column<int>(type: "int", nullable: true),
            //        Division2Id = table.Column<int>(type: "int", nullable: true),
            //        Factory2Id = table.Column<int>(type: "int", nullable: true),
            //        LineDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        Closed = table.Column<short>(type: "smallint", nullable: false),
            //        ShipmentStatus = table.Column<short>(type: "smallint", nullable: false),
            //        StateId = table.Column<int>(type: "int", nullable: false),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        AssignedTo = table.Column<int>(type: "int", nullable: true),
            //        Priority = table.Column<short>(type: "smallint", nullable: false),
            //        ConvFactor1 = table.Column<decimal>(type: "numeric(28,8)", nullable: true, defaultValueSql: "((1))"),
            //        ConvFactor2 = table.Column<decimal>(type: "numeric(28,8)", nullable: true, defaultValueSql: "((1))"),
            //        LineNumber = table.Column<int>(type: "int", nullable: false),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PlanningSlipLine", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_PlanningSlipLine_Address2Id",
            //            column: x => x.Address2Id,
            //            principalTable: "SysAddress",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlipLine_AddressId",
            //            column: x => x.AddressId,
            //            principalTable: "SysAddress",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlipLine_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlipLine_AssignedTo",
            //            column: x => x.AssignedTo,
            //            principalTable: "SysUser",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlipLine_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlipLine_SlipId",
            //            column: x => x.SlipId,
            //            principalTable: "PlanningSlip",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_PlanningSlipLine_StateId",
            //            column: x => x.StateId,
            //            principalTable: "SysCustomState",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlipLine_UnitId",
            //            column: x => x.UnitId,
            //            principalTable: "ItemUnit",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlipLine_VariantId",
            //            column: x => x.VariantId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlipLine_Warehouse2Id",
            //            column: x => x.Warehouse2Id,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_PlanningSlipLine_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DecompositionLine",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: false),
            //        Amount = table.Column<int>(type: "int", nullable: false),
            //        SlipLineId = table.Column<int>(type: "int", nullable: false),
            //        DecompositionShelvesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        OrderSlipLineId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DecompositionLine", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_DecompositionLine_DecompositionShelves_DecompositionShelvesId",
            //            column: x => x.DecompositionShelvesId,
            //            principalTable: "DecompositionShelves",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_DecompositionLine_OrderSlipLine_OrderSlipLineId",
            //            column: x => x.OrderSlipLineId,
            //            principalTable: "OrderSlipLine",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ReservationSlip",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        SlipDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        SlipNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        OrderSlipId = table.Column<int>(type: "int", nullable: true),
            //        PlanningSlipId = table.Column<int>(type: "int", nullable: true),
            //        ProductionOrderId = table.Column<int>(type: "int", nullable: true),
            //        WorkOrderId = table.Column<int>(type: "int", nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        Description1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        StateId = table.Column<int>(type: "int", nullable: false),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ReservationSlip", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_ReservationSlip_OrderSlipId",
            //            column: x => x.OrderSlipId,
            //            principalTable: "OrderSlip",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlip_PlanningSlipId",
            //            column: x => x.PlanningSlipId,
            //            principalTable: "PlanningSlip",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlip_ProductionOrderId",
            //            column: x => x.ProductionOrderId,
            //            principalTable: "ProductionOrder",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlip_StateId",
            //            column: x => x.StateId,
            //            principalTable: "SysCustomState",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlip_WorkOrderId",
            //            column: x => x.WorkOrderId,
            //            principalTable: "WorkOrder",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Slip",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        CustomSlipTypeId = table.Column<int>(type: "int", nullable: true),
            //        CarrierId = table.Column<int>(type: "int", nullable: true),
            //        SlipDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        SlipNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        DeliveryArpId = table.Column<int>(type: "int", nullable: true),
            //        ShipmentAddressId = table.Column<int>(type: "int", nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        Warehouse2Id = table.Column<int>(type: "int", nullable: true),
            //        OrderSlipId = table.Column<int>(type: "int", nullable: true),
            //        PlanningSlipId = table.Column<int>(type: "int", nullable: true),
            //        ProductionOrderId = table.Column<int>(type: "int", nullable: true),
            //        WorkOrderId = table.Column<int>(type: "int", nullable: false),
            //        Description1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Description4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        DispatchNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        SlipSerialNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        VehicleId = table.Column<int>(type: "int", nullable: true),
            //        DriverId = table.Column<int>(type: "int", nullable: true),
            //        DeclarationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        ShipmentNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
            //        CompletedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        CompletedBy = table.Column<int>(type: "int", nullable: true),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        Department2Id = table.Column<int>(type: "int", nullable: true),
            //        Division2Id = table.Column<int>(type: "int", nullable: true),
            //        Factory2Id = table.Column<int>(type: "int", nullable: true),
            //        SalesPersonId = table.Column<int>(type: "int", nullable: true),
            //        DocumentDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ProjectId = table.Column<int>(type: "int", nullable: true),
            //        Priority = table.Column<short>(type: "smallint", nullable: false),
            //        PrintCount = table.Column<int>(type: "int", nullable: false),
            //        StateId = table.Column<int>(type: "int", nullable: false),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Slip", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_Slip_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_CustomSlipTypeId",
            //            column: x => x.CustomSlipTypeId,
            //            principalTable: "SysCustomSlipType",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_DeliveryArpId",
            //            column: x => x.DeliveryArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_DepartmentId",
            //            column: x => x.DepartmentId,
            //            principalTable: "SysDepartment",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_DivisionId",
            //            column: x => x.DivisionId,
            //            principalTable: "SysDivision",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_DriverId",
            //            column: x => x.DriverId,
            //            principalTable: "Driver",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_FactoryId",
            //            column: x => x.FactoryId,
            //            principalTable: "SysFactory",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_OrderSlipId",
            //            column: x => x.OrderSlipId,
            //            principalTable: "OrderSlip",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_PlanningSlipId",
            //            column: x => x.PlanningSlipId,
            //            principalTable: "PlanningSlip",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_ProductionOrderId",
            //            column: x => x.ProductionOrderId,
            //            principalTable: "ProductionOrder",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_ProjectId",
            //            column: x => x.ProjectId,
            //            principalTable: "Project",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_SalesPersonId",
            //            column: x => x.SalesPersonId,
            //            principalTable: "SalesPerson",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_ShipmentAddressId",
            //            column: x => x.ShipmentAddressId,
            //            principalTable: "ShipmentAddress",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_StateId",
            //            column: x => x.StateId,
            //            principalTable: "SysCustomState",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicle",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_Warehouse2Id",
            //            column: x => x.Warehouse2Id,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_Slip_WorkOrderId",
            //            column: x => x.WorkOrderId,
            //            principalTable: "WorkOrder",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "WorkOrderLine",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        SlipId = table.Column<int>(type: "int", nullable: false),
            //        LineDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        LineNumber = table.Column<int>(type: "int", nullable: false),
            //        OrderSlipLineId = table.Column<int>(type: "int", nullable: true),
            //        PlanningSlipLineId = table.Column<int>(type: "int", nullable: true),
            //        ProdOrderLineId = table.Column<int>(type: "int", nullable: true),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        Warehouse2Id = table.Column<int>(type: "int", nullable: true),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        Department2Id = table.Column<int>(type: "int", nullable: true),
            //        Division2Id = table.Column<int>(type: "int", nullable: true),
            //        Factory2Id = table.Column<int>(type: "int", nullable: true),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        ItemId = table.Column<int>(type: "int", nullable: true),
            //        VariantId = table.Column<int>(type: "int", nullable: true),
            //        UnitId = table.Column<int>(type: "int", nullable: true),
            //        ShipmentAddressId = table.Column<int>(type: "int", nullable: true),
            //        AssignedTo = table.Column<int>(type: "int", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Quantity = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        AddressId = table.Column<int>(type: "int", nullable: true),
            //        Address2Id = table.Column<int>(type: "int", nullable: true),
            //        PropertyBarcode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        ConvFactor1 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        ConvFactor2 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ProjectId = table.Column<int>(type: "int", nullable: true),
            //        ContainerId = table.Column<int>(type: "int", nullable: true),
            //        ChildContainerId = table.Column<int>(type: "int", nullable: true),
            //        Container2Id = table.Column<int>(type: "int", nullable: true),
            //        ChildContainer2Id = table.Column<int>(type: "int", nullable: true),
            //        Priority = table.Column<short>(type: "smallint", nullable: false),
            //        StateId = table.Column<int>(type: "int", nullable: false),
            //        Closed = table.Column<short>(type: "smallint", nullable: false),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ParentLineId = table.Column<int>(type: "int", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_WorkOrderLine", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_Address2Id",
            //            column: x => x.Address2Id,
            //            principalTable: "SysAddress",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_AddressId",
            //            column: x => x.AddressId,
            //            principalTable: "SysAddress",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_AssignedTo",
            //            column: x => x.AssignedTo,
            //            principalTable: "SysUser",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_ChildContainer2Id",
            //            column: x => x.ChildContainer2Id,
            //            principalTable: "Container",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_ChildContainerId",
            //            column: x => x.ChildContainerId,
            //            principalTable: "Container",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_Container2Id",
            //            column: x => x.Container2Id,
            //            principalTable: "Container",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_ContainerId",
            //            column: x => x.ContainerId,
            //            principalTable: "Container",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_OrderSlipLineId",
            //            column: x => x.OrderSlipLineId,
            //            principalTable: "OrderSlipLine",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_PlanningSlipLineId",
            //            column: x => x.PlanningSlipLineId,
            //            principalTable: "PlanningSlipLine",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_ProdOrderLineId",
            //            column: x => x.ProdOrderLineId,
            //            principalTable: "ProductionOrderLine",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_ProjectId",
            //            column: x => x.ProjectId,
            //            principalTable: "Project",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_SlipId",
            //            column: x => x.SlipId,
            //            principalTable: "WorkOrder",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_StateId",
            //            column: x => x.StateId,
            //            principalTable: "SysCustomState",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_UnitId",
            //            column: x => x.UnitId,
            //            principalTable: "ItemUnit",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_VariantId",
            //            column: x => x.VariantId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_Warehouse2Id",
            //            column: x => x.Warehouse2Id,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_WorkOrderLine_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ReservationSlipLine",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        SlipId = table.Column<int>(type: "int", nullable: false),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        LineNumber = table.Column<int>(type: "int", nullable: false),
            //        LineDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        OrderSlipLineId = table.Column<int>(type: "int", nullable: true),
            //        PlanningSlipLineId = table.Column<int>(type: "int", nullable: true),
            //        WorkOrderLineId = table.Column<int>(type: "int", nullable: true),
            //        ProdOrderLineId = table.Column<int>(type: "int", nullable: true),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        ItemId = table.Column<int>(type: "int", nullable: true),
            //        VariantId = table.Column<int>(type: "int", nullable: true),
            //        UnitId = table.Column<int>(type: "int", nullable: true),
            //        Quantity = table.Column<decimal>(type: "numeric(28,8)", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        AddressId = table.Column<int>(type: "int", nullable: true),
            //        ContainerId = table.Column<int>(type: "int", nullable: true),
            //        ChildContainerId = table.Column<int>(type: "int", nullable: true),
            //        ConvFactor1 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        ConvFactor2 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        StateId = table.Column<int>(type: "int", nullable: false),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        BlockingTypeId = table.Column<int>(type: "int", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ReservationSlipLine", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_AddressId",
            //            column: x => x.AddressId,
            //            principalTable: "SysAddress",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_BlockingTypeId",
            //            column: x => x.BlockingTypeId,
            //            principalTable: "SysBlockingType",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_ChildContainerId",
            //            column: x => x.ChildContainerId,
            //            principalTable: "Container",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_ContainerId",
            //            column: x => x.ContainerId,
            //            principalTable: "Container",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_OrderSlipLineId",
            //            column: x => x.OrderSlipLineId,
            //            principalTable: "OrderSlipLine",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_PlanningSlipLineId",
            //            column: x => x.PlanningSlipLineId,
            //            principalTable: "PlanningSlipLine",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_ProdOrderLineId",
            //            column: x => x.ProdOrderLineId,
            //            principalTable: "ProductionOrderLine",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_SlipId",
            //            column: x => x.SlipId,
            //            principalTable: "ReservationSlip",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_StateId",
            //            column: x => x.StateId,
            //            principalTable: "SysCustomState",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_UnitId",
            //            column: x => x.UnitId,
            //            principalTable: "ItemUnit",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_VariantId",
            //            column: x => x.VariantId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_ReservationSlipLine_WorkOrderLineId",
            //            column: x => x.WorkOrderLineId,
            //            principalTable: "WorkOrderLine",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "SlipLine",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        SlipType = table.Column<short>(type: "smallint", nullable: false),
            //        SlipId = table.Column<int>(type: "int", nullable: false),
            //        LineDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        LineNumber = table.Column<int>(type: "int", nullable: false),
            //        OrderSlipLineId = table.Column<int>(type: "int", nullable: true),
            //        PlanningSlipLineId = table.Column<int>(type: "int", nullable: true),
            //        ProdOrderLineId = table.Column<int>(type: "int", nullable: true),
            //        WorkOrderLineId = table.Column<int>(type: "int", nullable: false),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        Warehouse2Id = table.Column<int>(type: "int", nullable: true),
            //        DepartmentId = table.Column<int>(type: "int", nullable: true),
            //        DivisionId = table.Column<int>(type: "int", nullable: true),
            //        FactoryId = table.Column<int>(type: "int", nullable: true),
            //        Department2Id = table.Column<int>(type: "int", nullable: true),
            //        Division2Id = table.Column<int>(type: "int", nullable: true),
            //        Factory2Id = table.Column<int>(type: "int", nullable: true),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        ItemId = table.Column<int>(type: "int", nullable: true),
            //        VariantId = table.Column<int>(type: "int", nullable: true),
            //        UnitId = table.Column<int>(type: "int", nullable: true),
            //        ShipmentAddressId = table.Column<int>(type: "int", nullable: true),
            //        AssignedTo = table.Column<int>(type: "int", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        Quantity = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        AddressId = table.Column<int>(type: "int", nullable: false),
            //        Address2Id = table.Column<int>(type: "int", nullable: true),
            //        PropertyBarcode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //        ConvFactor1 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        ConvFactor2 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        CustomCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        ProjectId = table.Column<int>(type: "int", nullable: true),
            //        ContainerId = table.Column<int>(type: "int", nullable: true),
            //        ChildContainerId = table.Column<int>(type: "int", nullable: true),
            //        Container2Id = table.Column<int>(type: "int", nullable: true),
            //        ChildContainer2Id = table.Column<int>(type: "int", nullable: true),
            //        InsuranceDuration = table.Column<int>(type: "int", nullable: true),
            //        InsuranceExpDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        StateId = table.Column<int>(type: "int", nullable: false),
            //        Approval = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        AuthCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        CreatedBy = table.Column<int>(type: "int", nullable: false),
            //        ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ModifiedBy = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_SlipLine", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_SlipLine_Address2Id",
            //            column: x => x.Address2Id,
            //            principalTable: "SysAddress",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_AddressId",
            //            column: x => x.AddressId,
            //            principalTable: "SysAddress",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_ArpId",
            //            column: x => x.ArpId,
            //            principalTable: "Arp",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_AssignedTo",
            //            column: x => x.AssignedTo,
            //            principalTable: "SysUser",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_ChildContainer2Id",
            //            column: x => x.ChildContainer2Id,
            //            principalTable: "Container",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_ChildContainerId",
            //            column: x => x.ChildContainerId,
            //            principalTable: "Container",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_Container2Id",
            //            column: x => x.Container2Id,
            //            principalTable: "Container",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_ContainerId",
            //            column: x => x.ContainerId,
            //            principalTable: "Container",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_OrderSlipLineId",
            //            column: x => x.OrderSlipLineId,
            //            principalTable: "OrderSlipLine",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_PlanningSlipLineId",
            //            column: x => x.PlanningSlipLineId,
            //            principalTable: "PlanningSlipLine",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_ProdOrderLineId",
            //            column: x => x.ProdOrderLineId,
            //            principalTable: "ProductionOrderLine",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_ProjectId",
            //            column: x => x.ProjectId,
            //            principalTable: "Project",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_SlipId",
            //            column: x => x.SlipId,
            //            principalTable: "Slip",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_SlipLine_StateId",
            //            column: x => x.StateId,
            //            principalTable: "SysCustomState",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_UnitId",
            //            column: x => x.UnitId,
            //            principalTable: "ItemUnit",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_VariantId",
            //            column: x => x.VariantId,
            //            principalTable: "Item",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_Warehouse2Id",
            //            column: x => x.Warehouse2Id,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_WarehouseId",
            //            column: x => x.WarehouseId,
            //            principalTable: "SysWarehouse",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "fk_SlipLine_WorkOrderLineId",
            //            column: x => x.WorkOrderLineId,
            //            principalTable: "WorkOrderLine",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TransactionDetail",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IoCode = table.Column<short>(type: "smallint", nullable: false),
            //        LineType = table.Column<short>(type: "smallint", nullable: false),
            //        TrCode = table.Column<short>(type: "smallint", nullable: false),
            //        ParentLineId = table.Column<int>(type: "int", nullable: true),
            //        OrderSlipId = table.Column<int>(type: "int", nullable: true),
            //        PlanningSlipId = table.Column<int>(type: "int", nullable: true),
            //        ProductionOrderId = table.Column<int>(type: "int", nullable: true),
            //        WorkOrderId = table.Column<int>(type: "int", nullable: true),
            //        SlipId = table.Column<int>(type: "int", nullable: true),
            //        ReservationSlipId = table.Column<int>(type: "int", nullable: true),
            //        OrderSlipLineId = table.Column<int>(type: "int", nullable: true),
            //        PlanningSlipLineId = table.Column<int>(type: "int", nullable: true),
            //        ProdOrderLineId = table.Column<int>(type: "int", nullable: true),
            //        WorkOrderLineId = table.Column<int>(type: "int", nullable: true),
            //        SlipLineId = table.Column<int>(type: "int", nullable: true),
            //        ReservationLineId = table.Column<int>(type: "int", nullable: true),
            //        LineDate = table.Column<DateTime>(type: "datetime", nullable: false),
            //        LineDay = table.Column<DateTime>(type: "datetime", nullable: false),
            //        WarehouseId = table.Column<int>(type: "int", nullable: false),
            //        ArpId = table.Column<int>(type: "int", nullable: true),
            //        ItemId = table.Column<int>(type: "int", nullable: false),
            //        VariantId = table.Column<int>(type: "int", nullable: true),
            //        UnitId = table.Column<int>(type: "int", nullable: false),
            //        Quantity = table.Column<decimal>(type: "numeric(28,8)", nullable: false),
            //        AddressId = table.Column<int>(type: "int", nullable: true),
            //        ConvFactor1 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        ConvFactor2 = table.Column<decimal>(type: "numeric(28,8)", nullable: false, defaultValueSql: "((1))"),
            //        ExpirationDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        ProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
            //        TrackingNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
            //        ContainerId = table.Column<int>(type: "int", nullable: true),
            //        ChildContainerId = table.Column<int>(type: "int", nullable: true),
            //        Active = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TransactionDetail", x => x.Id);
            //        table.ForeignKey(
            //            name: "fk_TransactionDetail_OrderSlipLineId",
            //            column: x => x.OrderSlipLineId,
            //            principalTable: "OrderSlipLine",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_TransactionDetail_PlanningSlipLineId",
            //            column: x => x.PlanningSlipLineId,
            //            principalTable: "PlanningSlipLine",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_TransactionDetail_ProdOrderLineId",
            //            column: x => x.ProdOrderLineId,
            //            principalTable: "ProductionOrderLine",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_TransactionDetail_ReservationLineId",
            //            column: x => x.ReservationLineId,
            //            principalTable: "ReservationSlipLine",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_TransactionDetail_SlipLineId",
            //            column: x => x.SlipLineId,
            //            principalTable: "SlipLine",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "fk_TransactionDetail_WorkOrderLineId",
            //            column: x => x.WorkOrderLineId,
            //            principalTable: "WorkOrderLine",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_AddressItem_ItemId",
            //    table: "AddressItem",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AddressItem_WarehouseId",
            //    table: "AddressItem",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_AddressItem_Active",
            //    table: "AddressItem",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_AddressItem_Item",
            //    table: "AddressItem",
            //    columns: new[] { "AddressId", "ItemId" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_Arp_Active",
            //    table: "Arp",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Arp_Code",
            //    table: "Arp",
            //    column: "Code");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Arp_Title",
            //    table: "Arp",
            //    columns: new[] { "Code", "Title" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_Carrier_Active",
            //    table: "Carrier",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Carrier_Description",
            //    table: "Carrier",
            //    columns: new[] { "Code", "Description" });

            //migrationBuilder.CreateIndex(
            //    name: "uk_Carrier_Code",
            //    table: "Carrier",
            //    column: "Code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_Container_Active",
            //    table: "Container",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Container_Type",
            //    table: "Container",
            //    column: "ContainerTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "uk_Container_LPN",
            //    table: "Container",
            //    column: "LPN",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Decomposition_DecompositionShelfId",
            //    table: "Decomposition",
            //    column: "DecompositionShelfId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DecompositionLine_DecompositionShelvesId",
            //    table: "DecompositionLine",
            //    column: "DecompositionShelvesId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DecompositionLine_OrderSlipLineId",
            //    table: "DecompositionLine",
            //    column: "OrderSlipLineId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DecompositionShelves_DecompositionShelfId",
            //    table: "DecompositionShelves",
            //    column: "DecompositionShelfId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Document_TypeId",
            //    table: "Document",
            //    columns: new[] { "RecordType", "RecordId", "DocumentType" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Driver_UserId",
            //    table: "Driver",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Driver_Active",
            //    table: "Driver",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Driver_Name",
            //    table: "Driver",
            //    columns: new[] { "Name", "Surname", "UserId" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_FormLayout_UserId",
            //    table: "FormLayout",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "uk_FormLayout_RoleUser",
            //    table: "FormLayout",
            //    columns: new[] { "RoleId", "UserId", "FormId", "ComponentId" },
            //    unique: true,
            //    filter: "[RoleId] IS NOT NULL AND [UserId] IS NOT NULL AND [FormId] IS NOT NULL AND [ComponentId] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "idx_History_TypeId",
            //    table: "History",
            //    columns: new[] { "ActionType", "RecordType", "RecordId" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_HistoryDetail_TypeId",
            //    table: "HistoryDetail",
            //    columns: new[] { "HistoryId", "FieldName" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_Item_Active",
            //    table: "Item",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Item_Code",
            //    table: "Item",
            //    columns: new[] { "Code", "Name" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_Item_Parent",
            //    table: "Item",
            //    column: "ParentItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ItemClassRelation_ItemId",
            //    table: "ItemClassRelation",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ItemClassRelation_Active",
            //    table: "ItemClassRelation",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_ItemClassRelation_ClassItem",
            //    table: "ItemClassRelation",
            //    columns: new[] { "ClassId", "ItemId" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_ItemContent_Active",
            //    table: "ItemContent",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ItemContent_Item",
            //    table: "ItemContent",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ItemContent_Parent",
            //    table: "ItemContent",
            //    column: "ParentItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ItemContent_Unit",
            //    table: "ItemContent",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ItemParameter_ItemId",
            //    table: "ItemParameter",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "uk_ItemParameter_WhItem",
            //    table: "ItemParameter",
            //    columns: new[] { "WarehouseId", "ItemId" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_ItemUnit_Active",
            //    table: "ItemUnit",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ItemUnit_Code",
            //    table: "ItemUnit",
            //    columns: new[] { "ItemId", "Code" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_LoginHistory_UserName",
            //    table: "LoginHistory",
            //    column: "UserName");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_Active",
            //    table: "OrderSlip",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_Address",
            //    table: "OrderSlip",
            //    column: "ShipmentAddressId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_Arp",
            //    table: "OrderSlip",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_Carrier",
            //    table: "OrderSlip",
            //    column: "CarrierId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_DeliveryArp",
            //    table: "OrderSlip",
            //    column: "DeliveryArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_Department",
            //    table: "OrderSlip",
            //    column: "DepartmentId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_Division",
            //    table: "OrderSlip",
            //    column: "DivisionId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_Factory",
            //    table: "OrderSlip",
            //    column: "FactoryId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_Project",
            //    table: "OrderSlip",
            //    column: "ProjectId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_SalesPerson",
            //    table: "OrderSlip",
            //    column: "SalesPersonId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_State",
            //    table: "OrderSlip",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_TypeNumber",
            //    table: "OrderSlip",
            //    columns: new[] { "SlipType", "SlipNumber", "SlipDate" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_Vehicle",
            //    table: "OrderSlip",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_Warehouse",
            //    table: "OrderSlip",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlip_Warehouse2",
            //    table: "OrderSlip",
            //    column: "Warehouse2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_Active",
            //    table: "OrderSlipLine",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_Arp",
            //    table: "OrderSlipLine",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_Department",
            //    table: "OrderSlipLine",
            //    column: "DepartmentId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_Item",
            //    table: "OrderSlipLine",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_Project",
            //    table: "OrderSlipLine",
            //    column: "ProjectId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_SlipId",
            //    table: "OrderSlipLine",
            //    column: "SlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_State",
            //    table: "OrderSlipLine",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_TypeDate",
            //    table: "OrderSlipLine",
            //    columns: new[] { "SlipType", "LineDate" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_Unit",
            //    table: "OrderSlipLine",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_User",
            //    table: "OrderSlipLine",
            //    column: "AssignedTo");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_Variant",
            //    table: "OrderSlipLine",
            //    column: "VariantId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_Warehouse",
            //    table: "OrderSlipLine",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_OrderSlipLine_Warehouse2",
            //    table: "OrderSlipLine",
            //    column: "Warehouse2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_Active",
            //    table: "PlanningSlip",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_Address",
            //    table: "PlanningSlip",
            //    column: "ShipmentAddressId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_Arp",
            //    table: "PlanningSlip",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_DeliveryArp",
            //    table: "PlanningSlip",
            //    column: "DeliveryArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_Department",
            //    table: "PlanningSlip",
            //    column: "DepartmentId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_Division",
            //    table: "PlanningSlip",
            //    column: "DivisionId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_Driver",
            //    table: "PlanningSlip",
            //    column: "DriverId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_Factory",
            //    table: "PlanningSlip",
            //    column: "FactoryId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_SalesPerson",
            //    table: "PlanningSlip",
            //    column: "SalesPersonId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_State",
            //    table: "PlanningSlip",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_TypeNumber",
            //    table: "PlanningSlip",
            //    columns: new[] { "SlipType", "SlipNumber", "SlipDate" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_Vehicle",
            //    table: "PlanningSlip",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_Warehouse",
            //    table: "PlanningSlip",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlip_Warehouse2",
            //    table: "PlanningSlip",
            //    column: "Warehouse2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_Active",
            //    table: "PlanningSlipLine",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_Address",
            //    table: "PlanningSlipLine",
            //    column: "AddressId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_Address2",
            //    table: "PlanningSlipLine",
            //    column: "Address2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_Arp",
            //    table: "PlanningSlipLine",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_Item",
            //    table: "PlanningSlipLine",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_SlipId",
            //    table: "PlanningSlipLine",
            //    column: "SlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_State",
            //    table: "PlanningSlipLine",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_TypeDate",
            //    table: "PlanningSlipLine",
            //    columns: new[] { "SlipType", "LineDate" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_Unit",
            //    table: "PlanningSlipLine",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_User",
            //    table: "PlanningSlipLine",
            //    column: "AssignedTo");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_Variant",
            //    table: "PlanningSlipLine",
            //    column: "VariantId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_Warehouse",
            //    table: "PlanningSlipLine",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_PlanningSlipLine_Warehouse2",
            //    table: "PlanningSlipLine",
            //    column: "Warehouse2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrder_Active",
            //    table: "ProductionOrder",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrder_Arp",
            //    table: "ProductionOrder",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrder_Factory",
            //    table: "ProductionOrder",
            //    column: "FactoryId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrder_Item",
            //    table: "ProductionOrder",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrder_Project",
            //    table: "ProductionOrder",
            //    column: "ProjectId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrder_TypeNumber",
            //    table: "ProductionOrder",
            //    columns: new[] { "SlipType", "SlipNumber", "SlipDate" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrder_Unit",
            //    table: "ProductionOrder",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductionOrderLine_ArpId",
            //    table: "ProductionOrderLine",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProductionOrderLine_ProjectId",
            //    table: "ProductionOrderLine",
            //    column: "ProjectId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrderLine_Active",
            //    table: "ProductionOrderLine",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrderLine_Actual",
            //    table: "ProductionOrderLine",
            //    columns: new[] { "ActualStartDate", "SlipType" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrderLine_Factory",
            //    table: "ProductionOrderLine",
            //    column: "FactoryId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrderLine_Item",
            //    table: "ProductionOrderLine",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrderLine_Planned",
            //    table: "ProductionOrderLine",
            //    columns: new[] { "PlannedStartDate", "SlipType" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrderLine_SlipId",
            //    table: "ProductionOrderLine",
            //    column: "SlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrderLine_Unit",
            //    table: "ProductionOrderLine",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrderLine_Variant",
            //    table: "ProductionOrderLine",
            //    column: "VariantId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ProductionOrderLine1",
            //    table: "ProductionOrderLine",
            //    columns: new[] { "Id", "LineNumber" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_Project_Active",
            //    table: "Project",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Project_Code",
            //    table: "Project",
            //    column: "Code");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Project_CodeName",
            //    table: "Project",
            //    columns: new[] { "Code", "Name" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlip_Active",
            //    table: "ReservationSlip",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlip_Date",
            //    table: "ReservationSlip",
            //    columns: new[] { "SlipNumber", "SlipDate" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlip_OrderSlip",
            //    table: "ReservationSlip",
            //    column: "OrderSlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlip_PlanningSlip",
            //    table: "ReservationSlip",
            //    column: "PlanningSlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlip_ProdOrder",
            //    table: "ReservationSlip",
            //    column: "ProductionOrderId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlip_State",
            //    table: "ReservationSlip",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlip_WorkOrder",
            //    table: "ReservationSlip",
            //    column: "WorkOrderId");

            //migrationBuilder.CreateIndex(
            //    name: "uk_ReservationSlip_TypeNumber",
            //    table: "ReservationSlip",
            //    columns: new[] { "SlipType", "SlipNumber" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_Active",
            //    table: "ReservationSlipLine",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_Address",
            //    table: "ReservationSlipLine",
            //    column: "AddressId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_Arp",
            //    table: "ReservationSlipLine",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_BlockingType",
            //    table: "ReservationSlipLine",
            //    column: "BlockingTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_ChildContainer",
            //    table: "ReservationSlipLine",
            //    column: "ChildContainerId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_Container",
            //    table: "ReservationSlipLine",
            //    column: "ContainerId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_DateType",
            //    table: "ReservationSlipLine",
            //    columns: new[] { "LineDate", "SlipType" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_Item",
            //    table: "ReservationSlipLine",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_OrderSlip",
            //    table: "ReservationSlipLine",
            //    column: "OrderSlipLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_PlanningSlip",
            //    table: "ReservationSlipLine",
            //    column: "PlanningSlipLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_ProdOrder",
            //    table: "ReservationSlipLine",
            //    column: "ProdOrderLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_SlipId",
            //    table: "ReservationSlipLine",
            //    column: "SlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_State",
            //    table: "ReservationSlipLine",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_Unit",
            //    table: "ReservationSlipLine",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_Variant",
            //    table: "ReservationSlipLine",
            //    column: "VariantId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_Warehouse",
            //    table: "ReservationSlipLine",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ReservationSlipLine_WorkOrder",
            //    table: "ReservationSlipLine",
            //    column: "WorkOrderLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SalesPerson_Active",
            //    table: "SalesPerson",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SalesPerson_Code",
            //    table: "SalesPerson",
            //    column: "Code");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SalesPerson_CodeName",
            //    table: "SalesPerson",
            //    columns: new[] { "Code", "Name" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Shift_WarehouseId",
            //    table: "Shift",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Shift_Active",
            //    table: "Shift",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Shift_CodeName",
            //    table: "Shift",
            //    columns: new[] { "Code", "Name" });

            //migrationBuilder.CreateIndex(
            //    name: "uk_Shift_Code",
            //    table: "Shift",
            //    column: "Code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_ShiftPeriod_Active",
            //    table: "ShiftPeriod",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_ShiftPeriod_Date",
            //    table: "ShiftPeriod",
            //    columns: new[] { "ShiftId", "StartDate", "EndDate" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_ShipmentAddress_Active",
            //    table: "ShipmentAddress",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ShipmentAddress_Arp",
            //    table: "ShipmentAddress",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ShipmentAddress_Code",
            //    table: "ShipmentAddress",
            //    columns: new[] { "Code", "Title" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_ShipmentDay_ShipmentAddressId",
            //    table: "ShipmentDay",
            //    column: "ShipmentAddressId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_ShipmentDay_ArpAddress",
            //    table: "ShipmentDay",
            //    columns: new[] { "ArpId", "ShipmentAddressId" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_Active",
            //    table: "Slip",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_Address",
            //    table: "Slip",
            //    column: "ShipmentAddressId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_Arp",
            //    table: "Slip",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_CustomType",
            //    table: "Slip",
            //    column: "CustomSlipTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_DeliveryArp",
            //    table: "Slip",
            //    column: "DeliveryArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_Department",
            //    table: "Slip",
            //    column: "DepartmentId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_Division",
            //    table: "Slip",
            //    column: "DivisionId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_Driver",
            //    table: "Slip",
            //    column: "DriverId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_Factory",
            //    table: "Slip",
            //    column: "FactoryId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_OrderSlip",
            //    table: "Slip",
            //    column: "OrderSlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_PlanningSlip",
            //    table: "Slip",
            //    column: "PlanningSlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_ProductionOrder",
            //    table: "Slip",
            //    column: "ProductionOrderId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_Project",
            //    table: "Slip",
            //    column: "ProjectId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_SalesPerson",
            //    table: "Slip",
            //    column: "SalesPersonId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_State",
            //    table: "Slip",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_TypeDate",
            //    table: "Slip",
            //    columns: new[] { "SlipType", "SlipDate" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_Vehicle",
            //    table: "Slip",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_Warehouse",
            //    table: "Slip",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_Warehouse2",
            //    table: "Slip",
            //    column: "Warehouse2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Slip_WorkOrder",
            //    table: "Slip",
            //    column: "WorkOrderId");

            //migrationBuilder.CreateIndex(
            //    name: "uk_Slip_TypeNumber",
            //    table: "Slip",
            //    columns: new[] { "SlipType", "SlipNumber" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Active",
            //    table: "SlipLine",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Address",
            //    table: "SlipLine",
            //    column: "AddressId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Address2",
            //    table: "SlipLine",
            //    column: "Address2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Arp",
            //    table: "SlipLine",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_ChildContainer",
            //    table: "SlipLine",
            //    column: "ChildContainerId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_ChildContainer2",
            //    table: "SlipLine",
            //    column: "ChildContainer2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Container",
            //    table: "SlipLine",
            //    column: "ContainerId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Container2",
            //    table: "SlipLine",
            //    column: "Container2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_DateType",
            //    table: "SlipLine",
            //    columns: new[] { "LineDate", "SlipType" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Item",
            //    table: "SlipLine",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_OrderSlip",
            //    table: "SlipLine",
            //    column: "OrderSlipLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_PlanningSlip",
            //    table: "SlipLine",
            //    column: "PlanningSlipLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_ProdOrder",
            //    table: "SlipLine",
            //    column: "ProdOrderLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Project",
            //    table: "SlipLine",
            //    column: "ProjectId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_SlipId",
            //    table: "SlipLine",
            //    column: "SlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_State",
            //    table: "SlipLine",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Unit",
            //    table: "SlipLine",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_User",
            //    table: "SlipLine",
            //    column: "AssignedTo");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Variant",
            //    table: "SlipLine",
            //    column: "VariantId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Warehouse",
            //    table: "SlipLine",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_Warehouse2",
            //    table: "SlipLine",
            //    column: "Warehouse2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SlipLine_WorkOrder",
            //    table: "SlipLine",
            //    column: "WorkOrderLineId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysAddress_FloorId",
            //    table: "SysAddress",
            //    column: "FloorId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysAddress_ZoneId",
            //    table: "SysAddress",
            //    column: "ZoneId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysAddress_Active",
            //    table: "SysAddress",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysAddress_Address",
            //    table: "SysAddress",
            //    columns: new[] { "WarehouseId", "FloorId", "Address" },
            //    unique: true,
            //    filter: "[FloorId] IS NOT NULL AND [Address] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysAuthCode_UserId",
            //    table: "SysAuthCode",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysAuthCode_TypeCode",
            //    table: "SysAuthCode",
            //    columns: new[] { "RoleId", "UserId", "RecordType", "AuthCode" },
            //    unique: true,
            //    filter: "[RoleId] IS NOT NULL AND [UserId] IS NOT NULL AND [AuthCode] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysBlockingException_Type",
            //    table: "SysBlockingException",
            //    columns: new[] { "BlockingTypeId", "CustomSlipTypeId" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysBlockingType_Active",
            //    table: "SysBlockingType",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysBlockingType_Code",
            //    table: "SysBlockingType",
            //    column: "Code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysContainerRelation_ChildId",
            //    table: "SysContainerRelation",
            //    column: "ChildId");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysContainerRelation_ParentChild",
            //    table: "SysContainerRelation",
            //    columns: new[] { "ParentId", "ChildId" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysContainerType_Active",
            //    table: "SysContainerType",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysContainerType_Code",
            //    table: "SysContainerType",
            //    column: "Code",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysCustomCode_Active",
            //    table: "SysCustomCode",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysCustomCode_CodeType",
            //    table: "SysCustomCode",
            //    columns: new[] { "Code", "CodeType" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysCustomListColumn_ReportId",
            //    table: "SysCustomListColumn",
            //    column: "ReportId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysCustomListColumn_Active",
            //    table: "SysCustomListColumn",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysCustomListColumn_MenuNumber",
            //    table: "SysCustomListColumn",
            //    column: "MenuNumber",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysCustomReport_Active",
            //    table: "SysCustomReport",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysCustomReport_ReportType",
            //    table: "SysCustomReport",
            //    column: "ReportType");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysCustomReport_Name",
            //    table: "SysCustomReport",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysCustomRule_Active",
            //    table: "SysCustomRule",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysCustomRule_Name",
            //    table: "SysCustomRule",
            //    column: "Name",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysCustomRuleAction_IdNumber",
            //    table: "SysCustomRuleAction",
            //    columns: new[] { "RuleId", "ActionNumber" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysCustomSlipType_Active",
            //    table: "SysCustomSlipType",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysCustomState_Active",
            //    table: "SysCustomState",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysCustomState_TypeNumber",
            //    table: "SysCustomState",
            //    columns: new[] { "RecordType", "StateNumber" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysCustomTable_Active",
            //    table: "SysCustomTable",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysCustomTable_TypeName",
            //    table: "SysCustomTable",
            //    columns: new[] { "TableName", "RecordType" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysDepartment_Active",
            //    table: "SysDepartment",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysDepartment_Code",
            //    table: "SysDepartment",
            //    column: "Code");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysDivision_Active",
            //    table: "SysDivision",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysDivision_Code",
            //    table: "SysDivision",
            //    column: "Code");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysErp_Active",
            //    table: "SysErp",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysErp_ErpType",
            //    table: "SysErp",
            //    columns: new[] { "ErpType", "Description", "ConnectionType" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysErpFirm_Active",
            //    table: "SysErpFirm",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysErpFirm_ErpFirm",
            //    table: "SysErpFirm",
            //    columns: new[] { "ErpId", "ErpFirmNumber", "ErpBranchNumber" },
            //    unique: true,
            //    filter: "[ErpBranchNumber] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysErpIntegration_ErpFirmId",
            //    table: "SysErpIntegration",
            //    column: "ErpFirmId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysErpIntegration_Erp",
            //    table: "SysErpIntegration",
            //    columns: new[] { "ErpId", "ErpFirmId" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysErpIntegration_Record",
            //    table: "SysErpIntegration",
            //    columns: new[] { "RecordType", "RecordId" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysErpIntegration1",
            //    table: "SysErpIntegration",
            //    columns: new[] { "RecordType", "RecordId", "ErpFirmId" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysFactory_Active",
            //    table: "SysFactory",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysFactory_Code",
            //    table: "SysFactory",
            //    column: "Code");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysFactory_Division",
            //    table: "SysFactory",
            //    column: "DivisionId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysLog_LoggerDateLevel",
            //    table: "SysLog",
            //    columns: new[] { "Logger", "LogDate", "LogLevel" });

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysMenuRight_RoleOp",
            //    table: "SysMenuRight",
            //    columns: new[] { "RoleId", "MenuId", "OperationType" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysNetLock_CreatedBy",
            //    table: "SysNetLock",
            //    column: "CreatedBy");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysNetLock_Active",
            //    table: "SysNetLock",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysNetLock_Form",
            //    table: "SysNetLock",
            //    columns: new[] { "FormName", "RecordId" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysParameter_Active",
            //    table: "SysParameter",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysParameter_TypeIdNumber",
            //    table: "SysParameter",
            //    columns: new[] { "ParameterType", "ParameterTypeId", "ParameterNumber" },
            //    unique: true,
            //    filter: "[ParameterTypeId] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysPasswordHistory_UserDate",
            //    table: "SysPasswordHistory",
            //    columns: new[] { "UserId", "CreatedDate" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysPasswordPolicy_Active",
            //    table: "SysPasswordPolicy",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysPrinter_Active",
            //    table: "SysPrinter",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysPrinter_Name",
            //    table: "SysPrinter",
            //    column: "Name",
            //    unique: true,
            //    filter: "[Name] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysRole_PasswordPolicyId",
            //    table: "SysRole",
            //    column: "PasswordPolicyId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysRole_Active",
            //    table: "SysRole",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysRole_Description",
            //    table: "SysRole",
            //    column: "Description",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysScript_Active",
            //    table: "SysScript",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysScript_TypeName",
            //    table: "SysScript",
            //    columns: new[] { "ScriptType", "Name" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysSession_User",
            //    table: "SysSession",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysUser_BossId",
            //    table: "SysUser",
            //    column: "BossId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysUser_DefaultErpFirmId",
            //    table: "SysUser",
            //    column: "DefaultErpFirmId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysUser_DefaultErpId",
            //    table: "SysUser",
            //    column: "DefaultErpId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysUser_DefaultWarehouseId",
            //    table: "SysUser",
            //    column: "DefaultWarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysUser_PasswordPolicyId",
            //    table: "SysUser",
            //    column: "PasswordPolicyId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysUser_Active",
            //    table: "SysUser",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysUser_Printer",
            //    table: "SysUser",
            //    column: "PrinterId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysUser_Role",
            //    table: "SysUser",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysUser_Script",
            //    table: "SysUser",
            //    column: "ScriptId");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysUser_UserName",
            //    table: "SysUser",
            //    column: "UserName",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysUserWarehouse_ErpFirmId",
            //    table: "SysUserWarehouse",
            //    column: "ErpFirmId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysUserWarehouse_WarehouseId",
            //    table: "SysUserWarehouse",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysUserWarehouse_UserFirm",
            //    table: "SysUserWarehouse",
            //    columns: new[] { "UserId", "WarehouseId", "ErpFirmId" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysWarehouse_Active",
            //    table: "SysWarehouse",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysWarehouse_CodeName",
            //    table: "SysWarehouse",
            //    columns: new[] { "Code", "Name" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysWarehouse_Department",
            //    table: "SysWarehouse",
            //    column: "DepartmentId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysWarehouse_Division",
            //    table: "SysWarehouse",
            //    column: "DivisionId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysWarehouse_Factory",
            //    table: "SysWarehouse",
            //    column: "FactoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysWarehouseBlock_FloorId",
            //    table: "SysWarehouseBlock",
            //    column: "FloorId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysWarehouseBlock_Active",
            //    table: "SysWarehouseBlock",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysWarehouseBlock_Code",
            //    table: "SysWarehouseBlock",
            //    columns: new[] { "WarehouseId", "FloorId", "Code" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysWarehouseFloor_WarehouseId",
            //    table: "SysWarehouseFloor",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysWarehouseFloor_Active",
            //    table: "SysWarehouseFloor",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysWarehouseFloor_CodeId",
            //    table: "SysWarehouseFloor",
            //    columns: new[] { "Code", "WarehouseId" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysWarehouseZone_FloorId",
            //    table: "SysWarehouseZone",
            //    column: "FloorId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_SysWarehouseZone_WarehouseId",
            //    table: "SysWarehouseZone",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_SysWarehouseZone_Active",
            //    table: "SysWarehouseZone",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "uk_SysWarehouseZone_CodeId",
            //    table: "SysWarehouseZone",
            //    columns: new[] { "Code", "WarehouseId", "FloorId" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_Active",
            //    table: "TransactionDetail",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_Address",
            //    table: "TransactionDetail",
            //    column: "AddressId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_ChildContainer",
            //    table: "TransactionDetail",
            //    column: "ChildContainerId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_Container",
            //    table: "TransactionDetail",
            //    column: "ContainerId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_Item",
            //    table: "TransactionDetail",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_Order",
            //    table: "TransactionDetail",
            //    column: "OrderSlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_OrderLine",
            //    table: "TransactionDetail",
            //    column: "OrderSlipLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_Planning",
            //    table: "TransactionDetail",
            //    column: "PlanningSlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_PlanningLine",
            //    table: "TransactionDetail",
            //    column: "PlanningSlipLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_ProdOrder",
            //    table: "TransactionDetail",
            //    column: "ProductionOrderId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_ProdOrderLine",
            //    table: "TransactionDetail",
            //    column: "ProdOrderLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_Reservation",
            //    table: "TransactionDetail",
            //    column: "ReservationSlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_ReservationLine",
            //    table: "TransactionDetail",
            //    column: "ReservationLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_Slip",
            //    table: "TransactionDetail",
            //    column: "SlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_SlipLine",
            //    table: "TransactionDetail",
            //    column: "SlipLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_TypeDate",
            //    table: "TransactionDetail",
            //    columns: new[] { "IoCode", "LineType", "LineDate" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_Unit",
            //    table: "TransactionDetail",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_Variant",
            //    table: "TransactionDetail",
            //    column: "VariantId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_Warehouse",
            //    table: "TransactionDetail",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_WorkOrder",
            //    table: "TransactionDetail",
            //    column: "WorkOrderId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail_WorkOrderLine",
            //    table: "TransactionDetail",
            //    column: "WorkOrderLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail1",
            //    table: "TransactionDetail",
            //    columns: new[] { "ContainerId", "LineType", "Active", "WarehouseId" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail2",
            //    table: "TransactionDetail",
            //    columns: new[] { "LineType", "Active", "ItemId", "AddressId", "ContainerId" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail3",
            //    table: "TransactionDetail",
            //    columns: new[] { "WarehouseId", "ItemId", "Active", "LineType" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_TransactionDetail4",
            //    table: "TransactionDetail",
            //    columns: new[] { "TrCode", "WorkOrderId", "Active" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_UnitBarcode_ArpId",
            //    table: "UnitBarcode",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UnitBarcode_ItemId",
            //    table: "UnitBarcode",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_UnitBarcode_Active",
            //    table: "UnitBarcode",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_UnitBarcode_Unit",
            //    table: "UnitBarcode",
            //    columns: new[] { "UnitId", "ItemId" });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vehicle_WarehouseId",
            //    table: "Vehicle",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Vehicle_Active",
            //    table: "Vehicle",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Vehicle_Code",
            //    table: "Vehicle",
            //    column: "Code");

            //migrationBuilder.CreateIndex(
            //    name: "idx_Vehicle_CodeName",
            //    table: "Vehicle",
            //    columns: new[] { "Code", "Name", "PlateNumber" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_Active",
            //    table: "WorkOrder",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_Address",
            //    table: "WorkOrder",
            //    column: "ShipmentAddressId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_Arp",
            //    table: "WorkOrder",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_CustomType",
            //    table: "WorkOrder",
            //    column: "CustomSlipTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_DeliveryArp",
            //    table: "WorkOrder",
            //    column: "DeliveryArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_Department",
            //    table: "WorkOrder",
            //    column: "DepartmentId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_Division",
            //    table: "WorkOrder",
            //    column: "DivisionId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_Driver",
            //    table: "WorkOrder",
            //    column: "DriverId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_Factory",
            //    table: "WorkOrder",
            //    column: "FactoryId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_OrderSlip",
            //    table: "WorkOrder",
            //    column: "OrderSlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_PlanningSlip",
            //    table: "WorkOrder",
            //    column: "PlanningSlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_ProdOrderLine",
            //    table: "WorkOrder",
            //    column: "ProdOrderLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_ProductionOrder",
            //    table: "WorkOrder",
            //    column: "ProductionOrderId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_Project",
            //    table: "WorkOrder",
            //    column: "ProjectId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_SalesPerson",
            //    table: "WorkOrder",
            //    column: "SalesPersonId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_State",
            //    table: "WorkOrder",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_TypeDate",
            //    table: "WorkOrder",
            //    columns: new[] { "SlipType", "SlipDate" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_Vehicle",
            //    table: "WorkOrder",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_Warehouse",
            //    table: "WorkOrder",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrder_Warehouse2",
            //    table: "WorkOrder",
            //    column: "Warehouse2Id");

            //migrationBuilder.CreateIndex(
            //    name: "uk_WorkOrder_TypeNumber",
            //    table: "WorkOrder",
            //    columns: new[] { "SlipType", "SlipNumber" },
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Active",
            //    table: "WorkOrderLine",
            //    column: "Active");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Address",
            //    table: "WorkOrderLine",
            //    column: "AddressId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Address2",
            //    table: "WorkOrderLine",
            //    column: "Address2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Arp",
            //    table: "WorkOrderLine",
            //    column: "ArpId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_ChildContainer",
            //    table: "WorkOrderLine",
            //    column: "ChildContainerId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_ChildContainer2",
            //    table: "WorkOrderLine",
            //    column: "ChildContainer2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Container",
            //    table: "WorkOrderLine",
            //    column: "ContainerId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Container2",
            //    table: "WorkOrderLine",
            //    column: "Container2Id");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_DateType",
            //    table: "WorkOrderLine",
            //    columns: new[] { "LineDate", "SlipType" });

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Item",
            //    table: "WorkOrderLine",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_OrderSlip",
            //    table: "WorkOrderLine",
            //    column: "OrderSlipLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_PlanningSlip",
            //    table: "WorkOrderLine",
            //    column: "PlanningSlipLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_ProdOrder",
            //    table: "WorkOrderLine",
            //    column: "ProdOrderLineId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Project",
            //    table: "WorkOrderLine",
            //    column: "ProjectId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_SlipId",
            //    table: "WorkOrderLine",
            //    column: "SlipId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_State",
            //    table: "WorkOrderLine",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Unit",
            //    table: "WorkOrderLine",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_User",
            //    table: "WorkOrderLine",
            //    column: "AssignedTo");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Variant",
            //    table: "WorkOrderLine",
            //    column: "VariantId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Warehouse",
            //    table: "WorkOrderLine",
            //    column: "WarehouseId");

            //migrationBuilder.CreateIndex(
            //    name: "idx_WorkOrderLine_Warehouse2",
            //    table: "WorkOrderLine",
            //    column: "Warehouse2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "AddressItem");

            //migrationBuilder.DropTable(
            //    name: "Decomposition");

            //migrationBuilder.DropTable(
            //    name: "DecompositionLine");

            //migrationBuilder.DropTable(
            //    name: "Document");

            //migrationBuilder.DropTable(
            //    name: "ERPInvTotal");

            //migrationBuilder.DropTable(
            //    name: "FormLayout");

            //migrationBuilder.DropTable(
            //    name: "History");

            //migrationBuilder.DropTable(
            //    name: "HistoryDetail");

            //migrationBuilder.DropTable(
            //    name: "HttpLogger");

            //migrationBuilder.DropTable(
            //    name: "ItemClassRelation");

            //migrationBuilder.DropTable(
            //    name: "ItemContent");

            //migrationBuilder.DropTable(
            //    name: "ItemExtra");

            //migrationBuilder.DropTable(
            //    name: "ItemParameter");

            //migrationBuilder.DropTable(
            //    name: "Logger");

            //migrationBuilder.DropTable(
            //    name: "LoginHistory");

            //migrationBuilder.DropTable(
            //    name: "Shift");

            //migrationBuilder.DropTable(
            //    name: "ShiftPeriod");

            //migrationBuilder.DropTable(
            //    name: "ShipmentDay");

            //migrationBuilder.DropTable(
            //    name: "SysAuthCode");

            //migrationBuilder.DropTable(
            //    name: "SysBlockingException");

            //migrationBuilder.DropTable(
            //    name: "SysContainerRelation");

            //migrationBuilder.DropTable(
            //    name: "SysCustomCode");

            //migrationBuilder.DropTable(
            //    name: "SysCustomListColumn");

            //migrationBuilder.DropTable(
            //    name: "SysCustomRuleAction");

            //migrationBuilder.DropTable(
            //    name: "SysCustomTable");

            //migrationBuilder.DropTable(
            //    name: "SysErpIntegration");

            //migrationBuilder.DropTable(
            //    name: "SysLog");

            //migrationBuilder.DropTable(
            //    name: "SysMenuRight");

            //migrationBuilder.DropTable(
            //    name: "SysNetLock");

            //migrationBuilder.DropTable(
            //    name: "SysParameter");

            //migrationBuilder.DropTable(
            //    name: "SysPasswordHistory");

            //migrationBuilder.DropTable(
            //    name: "SysSession");

            //migrationBuilder.DropTable(
            //    name: "SysUserWarehouse");

            //migrationBuilder.DropTable(
            //    name: "SysWarehouseBlock");

            //migrationBuilder.DropTable(
            //    name: "TransactionDetail");

            //migrationBuilder.DropTable(
            //    name: "UnitBarcode");

            //migrationBuilder.DropTable(
            //    name: "DecompositionShelves");

            //migrationBuilder.DropTable(
            //    name: "SysCustomReport");

            //migrationBuilder.DropTable(
            //    name: "SysCustomRule");

            //migrationBuilder.DropTable(
            //    name: "ReservationSlipLine");

            //migrationBuilder.DropTable(
            //    name: "SlipLine");

            //migrationBuilder.DropTable(
            //    name: "DecompositionShelf");

            //migrationBuilder.DropTable(
            //    name: "SysBlockingType");

            //migrationBuilder.DropTable(
            //    name: "ReservationSlip");

            //migrationBuilder.DropTable(
            //    name: "Slip");

            //migrationBuilder.DropTable(
            //    name: "WorkOrderLine");

            //migrationBuilder.DropTable(
            //    name: "Container");

            //migrationBuilder.DropTable(
            //    name: "OrderSlipLine");

            //migrationBuilder.DropTable(
            //    name: "PlanningSlipLine");

            //migrationBuilder.DropTable(
            //    name: "WorkOrder");

            //migrationBuilder.DropTable(
            //    name: "SysContainerType");

            //migrationBuilder.DropTable(
            //    name: "SysAddress");

            //migrationBuilder.DropTable(
            //    name: "SysCustomSlipType");

            //migrationBuilder.DropTable(
            //    name: "OrderSlip");

            //migrationBuilder.DropTable(
            //    name: "PlanningSlip");

            //migrationBuilder.DropTable(
            //    name: "ProductionOrderLine");

            //migrationBuilder.DropTable(
            //    name: "SysWarehouseZone");

            //migrationBuilder.DropTable(
            //    name: "Carrier");

            //migrationBuilder.DropTable(
            //    name: "Driver");

            //migrationBuilder.DropTable(
            //    name: "SalesPerson");

            //migrationBuilder.DropTable(
            //    name: "ShipmentAddress");

            //migrationBuilder.DropTable(
            //    name: "SysCustomState");

            //migrationBuilder.DropTable(
            //    name: "Vehicle");

            //migrationBuilder.DropTable(
            //    name: "ProductionOrder");

            //migrationBuilder.DropTable(
            //    name: "SysWarehouseFloor");

            //migrationBuilder.DropTable(
            //    name: "SysUser");

            //migrationBuilder.DropTable(
            //    name: "Arp");

            //migrationBuilder.DropTable(
            //    name: "Project");

            //migrationBuilder.DropTable(
            //    name: "ItemUnit");

            //migrationBuilder.DropTable(
            //    name: "SysErpFirm");

            //migrationBuilder.DropTable(
            //    name: "SysPrinter");

            //migrationBuilder.DropTable(
            //    name: "SysRole");

            //migrationBuilder.DropTable(
            //    name: "SysScript");

            //migrationBuilder.DropTable(
            //    name: "SysWarehouse");

            //migrationBuilder.DropTable(
            //    name: "Item");

            //migrationBuilder.DropTable(
            //    name: "SysErp");

            //migrationBuilder.DropTable(
            //    name: "SysPasswordPolicy");

            //migrationBuilder.DropTable(
            //    name: "SysDepartment");

            //migrationBuilder.DropTable(
            //    name: "SysFactory");

            //migrationBuilder.DropTable(
            //    name: "SysDivision");
        }
    }
}
