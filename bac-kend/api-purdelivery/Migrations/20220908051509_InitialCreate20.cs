using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "buyer_date",
                table: "T_Oversea",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "buyer_input",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "buyer_date",
                table: "T_Domestic",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "buyer_input",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "buyer_date",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "buyer_input",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "buyer_date",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "buyer_input",
                table: "T_Domestic");
        }
    }
}
