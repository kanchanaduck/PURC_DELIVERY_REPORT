using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Input_Domestic");

            migrationBuilder.DropTable(
                name: "T_Input_Oversea");

            migrationBuilder.AddColumn<string>(
                name: "leader_check",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "leader_date",
                table: "T_Oversea",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "manager_check",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "manager_date",
                table: "T_Oversea",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "other_check",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "other_date",
                table: "T_Oversea",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "purc_check",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "purc_date",
                table: "T_Oversea",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "leader_check",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "leader_date",
                table: "T_Domestic",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "manager_check",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "manager_date",
                table: "T_Domestic",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "other_check",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "other_date",
                table: "T_Domestic",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "purc_check",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "purc_date",
                table: "T_Domestic",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "leader_check",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "leader_date",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "manager_check",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "manager_date",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "other_check",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "other_date",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "purc_check",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "purc_date",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "leader_check",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "leader_date",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "manager_check",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "manager_date",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "other_check",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "other_date",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "purc_check",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "purc_date",
                table: "T_Domestic");

            migrationBuilder.CreateTable(
                name: "T_Input_Domestic",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    buyer_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    buyer_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dt_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_input = table.Column<int>(type: "int", nullable: false),
                    leader_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    leader_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    manager_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    other_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    other_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    purc_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    purc_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_check = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    buyer_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    buyer_input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dt_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    id_input = table.Column<int>(type: "int", nullable: false),
                    leader_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    leader_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    manager_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    other_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    other_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    purc_check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    purc_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_check = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Input_Oversea", x => x.id);
                });
        }
    }
}
