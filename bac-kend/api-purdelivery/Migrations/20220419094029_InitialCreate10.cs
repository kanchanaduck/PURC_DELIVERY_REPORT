using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "T_PU_Original",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "T_PU_Abnormal",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "T_PU",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "T_PO_Issue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "T_Delay_ShortLT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "T_Delay_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "T_Delay_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "T_Control_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "T_Control_Evalio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subject",
                table: "T_Control_Domestic",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "subject",
                table: "T_PU_Original");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "T_PU_Abnormal");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "T_PU");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "T_PO_Issue");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "T_Delay_ShortLT");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "T_Delay_Oversea");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "T_Delay_Domestic");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "T_Control_Oversea");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "T_Control_Evalio");

            migrationBuilder.DropColumn(
                name: "subject",
                table: "T_Control_Domestic");
        }
    }
}
