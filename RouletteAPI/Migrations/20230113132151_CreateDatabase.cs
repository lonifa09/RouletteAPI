using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RouletteAPI.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    TableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Polarity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.TableId);
                });

            migrationBuilder.CreateTable(
                name: "TableSections",
                columns: table => new
                {
                    TableSectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableSections", x => x.TableSectionId);
                });

            migrationBuilder.CreateTable(
                name: "Wheel",
                columns: table => new
                {
                    WheelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheel", x => x.WheelId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    BetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    TableId = table.Column<int>(type: "int", nullable: false),
                    TableSectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.BetId);
                    table.ForeignKey(
                        name: "FK_Bets_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "TableId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bets_TableSections_TableSectionId",
                        column: x => x.TableSectionId,
                        principalTable: "TableSections",
                        principalColumn: "TableSectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PayOuts",
                columns: table => new
                {
                    PayOutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PayOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayOuts", x => x.PayOutId);
                    table.ForeignKey(
                        name: "FK_PayOuts_Bets_BetId",
                        column: x => x.BetId,
                        principalTable: "Bets",
                        principalColumn: "BetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spins",
                columns: table => new
                {
                    SpinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WheelId = table.Column<int>(type: "int", nullable: false),
                    BetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spins", x => x.SpinId);
                    table.ForeignKey(
                        name: "FK_Spins_Bets_BetId",
                        column: x => x.BetId,
                        principalTable: "Bets",
                        principalColumn: "BetId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spins_Wheel_WheelId",
                        column: x => x.WheelId,
                        principalTable: "Wheel",
                        principalColumn: "WheelId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bets_TableId",
                table: "Bets",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Bets_TableSectionId",
                table: "Bets",
                column: "TableSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_PayOuts_BetId",
                table: "PayOuts",
                column: "BetId");

            migrationBuilder.CreateIndex(
                name: "IX_Spins_BetId",
                table: "Spins",
                column: "BetId");

            migrationBuilder.CreateIndex(
                name: "IX_Spins_WheelId",
                table: "Spins",
                column: "WheelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PayOuts");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Spins");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Bets");

            migrationBuilder.DropTable(
                name: "Wheel");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "TableSections");
        }
    }
}
