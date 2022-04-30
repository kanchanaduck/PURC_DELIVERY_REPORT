using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "dt_date",
                table: "T_Input_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dt_date",
                table: "T_Input_Domestic",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dt_date",
                table: "T_Input_Oversea");

            migrationBuilder.DropColumn(
                name: "dt_date",
                table: "T_Input_Domestic");
        }
    }
}
