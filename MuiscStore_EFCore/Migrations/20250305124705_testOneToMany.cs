using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuiscStore_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class testOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Promotions_PromotionId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_TGenres_GenreId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_TGenres_DailyBests_DailyBestId",
                table: "TGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_TGenres_MonthlyBests_MonthlyBestId",
                table: "TGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_TGenres_WeeklyBests_WeeklyBestId",
                table: "TGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_TGenres_YearlyBests_YearlyBestId",
                table: "TGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TGenres",
                table: "TGenres");

            migrationBuilder.RenameTable(
                name: "TGenres",
                newName: "Genres");

            migrationBuilder.RenameIndex(
                name: "IX_TGenres_YearlyBestId",
                table: "Genres",
                newName: "IX_Genres_YearlyBestId");

            migrationBuilder.RenameIndex(
                name: "IX_TGenres_WeeklyBestId",
                table: "Genres",
                newName: "IX_Genres_WeeklyBestId");

            migrationBuilder.RenameIndex(
                name: "IX_TGenres_MonthlyBestId",
                table: "Genres",
                newName: "IX_Genres_MonthlyBestId");

            migrationBuilder.RenameIndex(
                name: "IX_TGenres_DailyBestId",
                table: "Genres",
                newName: "IX_Genres_DailyBestId");

            migrationBuilder.AlterColumn<int>(
                name: "PromotionId",
                table: "Records",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_DailyBests_DailyBestId",
                table: "Genres",
                column: "DailyBestId",
                principalTable: "DailyBests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_MonthlyBests_MonthlyBestId",
                table: "Genres",
                column: "MonthlyBestId",
                principalTable: "MonthlyBests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_WeeklyBests_WeeklyBestId",
                table: "Genres",
                column: "WeeklyBestId",
                principalTable: "WeeklyBests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_YearlyBests_YearlyBestId",
                table: "Genres",
                column: "YearlyBestId",
                principalTable: "YearlyBests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Genres_GenreId",
                table: "Records",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Promotions_PromotionId",
                table: "Records",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_DailyBests_DailyBestId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_MonthlyBests_MonthlyBestId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_WeeklyBests_WeeklyBestId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_YearlyBests_YearlyBestId",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Genres_GenreId",
                table: "Records");

            migrationBuilder.DropForeignKey(
                name: "FK_Records_Promotions_PromotionId",
                table: "Records");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "TGenres");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_YearlyBestId",
                table: "TGenres",
                newName: "IX_TGenres_YearlyBestId");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_WeeklyBestId",
                table: "TGenres",
                newName: "IX_TGenres_WeeklyBestId");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_MonthlyBestId",
                table: "TGenres",
                newName: "IX_TGenres_MonthlyBestId");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_DailyBestId",
                table: "TGenres",
                newName: "IX_TGenres_DailyBestId");

            migrationBuilder.AlterColumn<int>(
                name: "PromotionId",
                table: "Records",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TGenres",
                table: "TGenres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Promotions_PromotionId",
                table: "Records",
                column: "PromotionId",
                principalTable: "Promotions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_TGenres_GenreId",
                table: "Records",
                column: "GenreId",
                principalTable: "TGenres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TGenres_DailyBests_DailyBestId",
                table: "TGenres",
                column: "DailyBestId",
                principalTable: "DailyBests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TGenres_MonthlyBests_MonthlyBestId",
                table: "TGenres",
                column: "MonthlyBestId",
                principalTable: "MonthlyBests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TGenres_WeeklyBests_WeeklyBestId",
                table: "TGenres",
                column: "WeeklyBestId",
                principalTable: "WeeklyBests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TGenres_YearlyBests_YearlyBestId",
                table: "TGenres",
                column: "YearlyBestId",
                principalTable: "YearlyBests",
                principalColumn: "Id");
        }
    }
}
