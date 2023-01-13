using Microsoft.EntityFrameworkCore.Migrations;

namespace RouletteAPI.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fc8872d3-afb3-4c89-bb73-1d8c842a747a", "aadc567c-32eb-49ca-9749-0b18e875ac4c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1562872f-4ac8-44bd-a52f-1ce62732c034", "7a41cf66-8e4c-4a76-8f64-13a427dd38e7", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1562872f-4ac8-44bd-a52f-1ce62732c034");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc8872d3-afb3-4c89-bb73-1d8c842a747a");
        }
    }
}
