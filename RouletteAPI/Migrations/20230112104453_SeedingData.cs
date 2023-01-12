using Microsoft.EntityFrameworkCore.Migrations;

namespace RouletteAPI.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TableSections",
                columns: new[] { "TableSectionId", "Description" },
                values: new object[,]
                {
                    { 3, "Red" },
                    { 6, "19-36" },
                    { 5, "Odd" },
                    { 4, "Black" },
                    { 2, "Even" },
                    { 1, "1-18" }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "Color", "Number", "Polarity", "Range" },
                values: new object[,]
                {
                    { 25, "Red", 25, "", "3rd 12" },
                    { 26, "Black", 26, "", "3rd 12" },
                    { 27, "Red", 27, "", "3rd 12" },
                    { 28, "Red", 28, "", "3rd 12" },
                    { 29, "Black", 29, "", "3rd 12" },
                    { 30, "Red", 30, "", "3rd 12" },
                    { 31, "Black", 31, "", "3rd 12" },
                    { 34, "Red", 34, "", "3rd 12" },
                    { 33, "Black", 33, "", "3rd 12" },
                    { 24, "Black", 24, "", "2nd 12" },
                    { 35, "Black", 35, "", "3rd 12" },
                    { 36, "Red", 36, "", "3rd 12" },
                    { 37, "Green", 0, "", "" },
                    { 38, "Green", 0, "", "" },
                    { 32, "Red", 32, "", "3rd 12" },
                    { 23, "Red", 23, "", "2nd 12" },
                    { 1, "Red", 1, "", "1st 12" },
                    { 21, "Red", 21, "", "2nd 12" },
                    { 22, "Black", 22, "", "2nd 12" },
                    { 2, "Black", 2, "", "1st 12" },
                    { 4, "Black", 4, "", "1st 12" },
                    { 5, "Red", 5, "", "1st 12" },
                    { 6, "Black", 6, "", "1st 12" },
                    { 7, "Red", 7, "", "1st 12" },
                    { 8, "Black", 8, "", "1st 12" },
                    { 9, "Red", 9, "", "1st 12" },
                    { 10, "Black", 10, "", "1st 12" },
                    { 3, "Red", 3, "", "1st 12" },
                    { 12, "Red", 12, "", "1st 12" },
                    { 11, "Black", 11, "", "1st 12" },
                    { 19, "Black", 19, "", "2nd 12" },
                    { 18, "Red", 18, "", "2nd 12" },
                    { 17, "Black", 17, "", "2nd 12" },
                    { 20, "Black", 20, "", "2nd 12" },
                    { 15, "Black", 15, "", "2nd 12" },
                    { 14, "Red", 14, "", "2nd 12" }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "Color", "Number", "Polarity", "Range" },
                values: new object[,]
                {
                    { 13, "Black", 13, "", "2nd 12" },
                    { 16, "Red", 16, "", "2nd 12" }
                });

            migrationBuilder.InsertData(
                table: "Wheel",
                columns: new[] { "WheelId", "Color", "Number" },
                values: new object[,]
                {
                    { 21, "Black", 21 },
                    { 27, "Black", 27 },
                    { 23, "Black", 23 },
                    { 24, "Red", 24 },
                    { 25, "Black", 25 },
                    { 26, "Red", 26 },
                    { 22, "Red", 22 },
                    { 32, "Black", 32 },
                    { 29, "Red", 29 },
                    { 30, "Black", 30 },
                    { 31, "Red", 31 },
                    { 33, "Red", 33 },
                    { 34, "Black", 34 },
                    { 35, "Red", 35 },
                    { 20, "Red", 20 },
                    { 36, "Black", 36 },
                    { 28, "Black", 28 },
                    { 19, "Red", 19 },
                    { 9, "Black", 9 },
                    { 17, "Red", 17 },
                    { 37, "Green", 0 },
                    { 1, "Black", 1 },
                    { 2, "Red", 2 },
                    { 3, "Black", 3 },
                    { 4, "Red", 4 },
                    { 5, "Black", 5 },
                    { 6, "Red", 6 },
                    { 18, "Black", 18 },
                    { 7, "Black", 7 },
                    { 10, "Red", 10 },
                    { 11, "Red", 11 },
                    { 12, "Black", 12 },
                    { 13, "Red", 13 },
                    { 14, "Black", 14 },
                    { 15, "Red", 15 },
                    { 16, "Black", 16 },
                    { 8, "Red", 8 },
                    { 38, "Green", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TableSections",
                keyColumn: "TableSectionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TableSections",
                keyColumn: "TableSectionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TableSections",
                keyColumn: "TableSectionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TableSections",
                keyColumn: "TableSectionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TableSections",
                keyColumn: "TableSectionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TableSections",
                keyColumn: "TableSectionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Wheel",
                keyColumn: "WheelId",
                keyValue: 38);
        }
    }
}
