using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wms.Integration.DataAccess.Migrations
{
    public partial class CreateAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HttpLogger",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FullUrl = table.Column<string>(type: "NVarChar(max)", nullable: true),
                    Body = table.Column<string>(type: "NVarChar(max)", nullable: true),
                    LocalIp = table.Column<string>(type: "NVarChar(max)", nullable: true),
                    RemoteIp = table.Column<string>(type: "NVarChar(max)", nullable: true),
                    LocalPort = table.Column<int>(type: "Int", nullable: false),
                    RemotePort = table.Column<int>(type: "Int", nullable: false),
                    ResponseStatu = table.Column<int>(type: "Int", nullable: false),
                    Response = table.Column<string>(type: "NVarChar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HttpLogger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logger",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "UniqueIdentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    MethodName = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
                    ProjectName = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
                    Message1 = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
                    Message2 = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true),
                    Statu = table.Column<string>(type: "NVarChar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVarChar", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "NVarChar", nullable: true),
                    LastName = table.Column<string>(type: "NVarChar", nullable: true),
                    UserName = table.Column<string>(type: "NVarChar", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "VarBinary", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "VarBinary", nullable: true),
                    Status = table.Column<bool>(type: "Bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "Int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "Int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaims",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HttpLogger");

            migrationBuilder.DropTable(
                name: "Logger");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
