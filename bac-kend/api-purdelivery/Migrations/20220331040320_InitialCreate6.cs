using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Input_Domestic",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_input = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    leader_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    leader_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    manager_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    other_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    other_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    purc_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    purc_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Input_Domestic", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_Input_Oversea",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_input = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    leader_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    leader_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    manager_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    other_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    other_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    purc_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    purc_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Input_Oversea", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Input_Domestic");

            migrationBuilder.DropTable(
                name: "T_Input_Oversea");
        }
    }
}
