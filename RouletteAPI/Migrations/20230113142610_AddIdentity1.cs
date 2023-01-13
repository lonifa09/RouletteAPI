using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RouletteAPI.Migrations
{
    public partial class AddIdentity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "Lastname");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "AspNetUsers",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
