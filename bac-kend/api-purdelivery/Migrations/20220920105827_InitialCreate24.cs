using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Reason_Delay");

            migrationBuilder.DropTable(
                name: "T_Reason_Early");

            migrationBuilder.DropTable(
                name: "T_Reason_ShortLT");

            migrationBuilder.CreateTable(
                name: "T_Reason_Domestic_Delay",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Reason_Domestic_Delay", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_Reason_Domestic_Early",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Reason_Domestic_Early", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_Reason_Domestic_ShortLT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Reason_Domestic_ShortLT", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_Reason_Oversea_Delay",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Reason_Oversea_Delay", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_Reason_Oversea_Early",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Reason_Oversea_Early", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_Reason_Oversea_ShortLT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Reason_Oversea_ShortLT", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Reason_Domestic_Delay");

            migrationBuilder.DropTable(
                name: "T_Reason_Domestic_Early");

            migrationBuilder.DropTable(
                name: "T_Reason_Domestic_ShortLT");

            migrationBuilder.DropTable(
                name: "T_Reason_Oversea_Delay");

            migrationBuilder.DropTable(
                name: "T_Reason_Oversea_Early");

            migrationBuilder.DropTable(
                name: "T_Reason_Oversea_ShortLT");

            migrationBuilder.CreateTable(
                name: "T_Reason_Delay",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Reason_Delay", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_Reason_Early",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Reason_Early", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_Reason_ShortLT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Reason_ShortLT", x => x.id);
                });
        }
    }
}
