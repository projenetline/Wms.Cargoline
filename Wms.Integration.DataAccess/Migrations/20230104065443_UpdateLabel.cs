using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wms.Integration.DataAccess.Migrations
{
    public partial class UpdateLabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LabelHeader",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    OrderNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoxCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaletNr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transporter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClDefintion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabelHeader", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LabelBody",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    LabelHeaderId = table.Column<Guid>(type: "UniqueIdentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabelBody", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabelBody_LabelHeader_LabelHeaderId",
                        column: x => x.LabelHeaderId,
                        principalTable: "LabelHeader",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabelBody_LabelHeaderId",
                table: "LabelBody",
                column: "LabelHeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabelBody");

            migrationBuilder.DropTable(
                name: "LabelHeader");
        }
    }
}
