using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_KPI_Monthly",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    percent = table.Column<int>(type: "int", nullable: false),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    percent = table.Column<int>(type: "int", nullable: false),
                    upd_dt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    upd_by = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_KPI_Yearly", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_KPI_Monthly");

            migrationBuilder.DropTable(
                name: "T_KPI_Yearly");
        }
    }
}
