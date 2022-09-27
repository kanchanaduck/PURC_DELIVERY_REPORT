using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_KPI_Monthly");

            migrationBuilder.DropTable(
                name: "T_KPI_Yearly");

            migrationBuilder.CreateTable(
                name: "T_KPI",
                columns: table => new
                {
                    year = table.Column<int>(type: "int", nullable: false),
                    monthly = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    dept = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    kpi = table.Column<float>(type: "real", nullable: true),
                    created_dt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updated_dt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_KPI", x => new { x.year, x.monthly, x.dept });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_KPI");

            migrationBuilder.CreateTable(
                name: "T_KPI_Monthly",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    percent = table.Column<int>(type: "int", nullable: false),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_KPI_Monthly", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_KPI_Yearly",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    percent = table.Column<int>(type: "int", nullable: false),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_KPI_Yearly", x => x.ID);
                });
        }
    }
}
