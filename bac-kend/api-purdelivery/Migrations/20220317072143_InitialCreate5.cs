using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "remark",
                table: "T_Reason_ShortLT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "remark",
                table: "T_Reason_Evalio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "remark",
                table: "T_Reason_Early",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "remark",
                table: "T_Reason_DL_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "remark",
                table: "T_Reason_DL_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "remark",
                table: "T_Reason_Delay",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "remark",
                table: "T_Reason_ShortLT");

            migrationBuilder.DropColumn(
                name: "remark",
                table: "T_Reason_Evalio");

            migrationBuilder.DropColumn(
                name: "remark",
                table: "T_Reason_Early");

            migrationBuilder.DropColumn(
                name: "remark",
                table: "T_Reason_DL_Oversea");

            migrationBuilder.DropColumn(
                name: "remark",
                table: "T_Reason_DL_Domestic");

            migrationBuilder.DropColumn(
                name: "remark",
                table: "T_Reason_Delay");
        }
    }
}
