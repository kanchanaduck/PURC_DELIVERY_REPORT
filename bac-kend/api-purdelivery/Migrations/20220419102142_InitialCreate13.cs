using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "input_by",
                table: "T_PU");

            migrationBuilder.DropColumn(
                name: "input_dt",
                table: "T_PU");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "input_by",
                table: "T_PU",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "input_dt",
                table: "T_PU",
                type: "datetime2",
                nullable: true);
        }
    }
}
