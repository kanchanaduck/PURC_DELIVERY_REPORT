using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "leader_result",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "manager_result",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "other_result",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "purc_result",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "leader_result",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "manager_result",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "other_result",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "purc_result",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "leader_result",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "manager_result",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "other_result",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "purc_result",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "leader_result",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "manager_result",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "other_result",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "purc_result",
                table: "T_Domestic");
        }
    }
}
