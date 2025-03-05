using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuiscStore_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyBests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyBests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyBests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyBests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeeklyBests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyBests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearlyBests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearlyBests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regulars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regulars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regulars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyBestId = table.Column<int>(type: "int", nullable: true),
                    MonthlyBestId = table.Column<int>(type: "int", nullable: true),
                    WeeklyBestId = table.Column<int>(type: "int", nullable: true),
                    YearlyBestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_DailyBests_DailyBestId",
                        column: x => x.DailyBestId,
                        principalTable: "DailyBests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Authors_MonthlyBests_MonthlyBestId",
                        column: x => x.MonthlyBestId,
                        principalTable: "MonthlyBests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Authors_WeeklyBests_WeeklyBestId",
                        column: x => x.WeeklyBestId,
                        principalTable: "WeeklyBests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Authors_YearlyBests_YearlyBestId",
                        column: x => x.YearlyBestId,
                        principalTable: "YearlyBests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TGenres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyBestId = table.Column<int>(type: "int", nullable: true),
                    MonthlyBestId = table.Column<int>(type: "int", nullable: true),
                    WeeklyBestId = table.Column<int>(type: "int", nullable: true),
                    YearlyBestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TGenres_DailyBests_DailyBestId",
                        column: x => x.DailyBestId,
                        principalTable: "DailyBests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TGenres_MonthlyBests_MonthlyBestId",
                        column: x => x.MonthlyBestId,
                        principalTable: "MonthlyBests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TGenres_WeeklyBests_WeeklyBestId",
                        column: x => x.WeeklyBestId,
                        principalTable: "WeeklyBests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TGenres_YearlyBests_YearlyBestId",
                        column: x => x.YearlyBestId,
                        principalTable: "YearlyBests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountOfTracks = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    PrimeCost = table.Column<decimal>(type: "money", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    DailyBestId = table.Column<int>(type: "int", nullable: true),
                    MonthlyBestId = table.Column<int>(type: "int", nullable: true),
                    PromotionId = table.Column<int>(type: "int", nullable: true),
                    WeeklyBestId = table.Column<int>(type: "int", nullable: true),
                    YearlyBestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Records_DailyBests_DailyBestId",
                        column: x => x.DailyBestId,
                        principalTable: "DailyBests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Records_MonthlyBests_MonthlyBestId",
                        column: x => x.MonthlyBestId,
                        principalTable: "MonthlyBests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Records_Promotions_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Records_TGenres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "TGenres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Records_WeeklyBests_WeeklyBestId",
                        column: x => x.WeeklyBestId,
                        principalTable: "WeeklyBests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Records_YearlyBests_YearlyBestId",
                        column: x => x.YearlyBestId,
                        principalTable: "YearlyBests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_DailyBestId",
                table: "Authors",
                column: "DailyBestId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_MonthlyBestId",
                table: "Authors",
                column: "MonthlyBestId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_WeeklyBestId",
                table: "Authors",
                column: "WeeklyBestId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_YearlyBestId",
                table: "Authors",
                column: "YearlyBestId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_AuthorId",
                table: "Records",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_DailyBestId",
                table: "Records",
                column: "DailyBestId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_GenreId",
                table: "Records",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_MonthlyBestId",
                table: "Records",
                column: "MonthlyBestId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_PromotionId",
                table: "Records",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_WeeklyBestId",
                table: "Records",
                column: "WeeklyBestId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_YearlyBestId",
                table: "Records",
                column: "YearlyBestId");

            migrationBuilder.CreateIndex(
                name: "IX_Regulars_UserId",
                table: "Regulars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TGenres_DailyBestId",
                table: "TGenres",
                column: "DailyBestId");

            migrationBuilder.CreateIndex(
                name: "IX_TGenres_MonthlyBestId",
                table: "TGenres",
                column: "MonthlyBestId");

            migrationBuilder.CreateIndex(
                name: "IX_TGenres_WeeklyBestId",
                table: "TGenres",
                column: "WeeklyBestId");

            migrationBuilder.CreateIndex(
                name: "IX_TGenres_YearlyBestId",
                table: "TGenres",
                column: "YearlyBestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Regulars");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "TGenres");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "DailyBests");

            migrationBuilder.DropTable(
                name: "MonthlyBests");

            migrationBuilder.DropTable(
                name: "WeeklyBests");

            migrationBuilder.DropTable(
                name: "YearlyBests");
        }
    }
}
