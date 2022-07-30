using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Role",
                columns: table => new
                {
                    role = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Role", x => x.role);
                });

            migrationBuilder.CreateTable(
                name: "T_User",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    passwordhash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    storedsalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    active = table.Column<bool>(type: "bit", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reset_password_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    reset_password_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dept = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_User", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "T_Role_Claim",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(8)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Role_Claim", x => new { x.username, x.role });
                    table.ForeignKey(
                        name: "FK_T_Role_Claim_T_Role_role",
                        column: x => x.role,
                        principalTable: "T_Role",
                        principalColumn: "role",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Role_Claim_T_User_username",
                        column: x => x.username,
                        principalTable: "T_User",
                        principalColumn: "username",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Role_Claim_role",
                table: "T_Role_Claim",
                column: "role");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Role_Claim");

            migrationBuilder.DropTable(
                name: "T_Role");

            migrationBuilder.DropTable(
                name: "T_User");
        }
    }
}
