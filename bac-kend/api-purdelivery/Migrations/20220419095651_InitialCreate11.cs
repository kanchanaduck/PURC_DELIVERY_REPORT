using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "input_by",
                table: "T_Delay_ShortLT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "input_dt",
                table: "T_Delay_ShortLT",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "input_by",
                table: "T_Delay_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "input_dt",
                table: "T_Delay_Oversea",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "input_by",
                table: "T_Delay_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "input_dt",
                table: "T_Delay_Domestic",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "input_by",
                table: "T_Control_Evalio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "input_dt",
                table: "T_Control_Evalio",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "input_by",
                table: "T_PU");

            migrationBuilder.DropColumn(
                name: "input_dt",
                table: "T_PU");

            migrationBuilder.DropColumn(
                name: "input_by",
                table: "T_Delay_ShortLT");

            migrationBuilder.DropColumn(
                name: "input_dt",
                table: "T_Delay_ShortLT");

            migrationBuilder.DropColumn(
                name: "input_by",
                table: "T_Delay_Oversea");

            migrationBuilder.DropColumn(
                name: "input_dt",
                table: "T_Delay_Oversea");

            migrationBuilder.DropColumn(
                name: "input_by",
                table: "T_Delay_Domestic");

            migrationBuilder.DropColumn(
                name: "input_dt",
                table: "T_Delay_Domestic");

            migrationBuilder.DropColumn(
                name: "input_by",
                table: "T_Control_Evalio");

            migrationBuilder.DropColumn(
                name: "input_dt",
                table: "T_Control_Evalio");
        }
    }
}
