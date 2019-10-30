using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_200412952.Data.Migrations
{
    public partial class fixoffix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PetFood",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "PetFood",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PetFood",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://vignette.wikia.nocookie.net/miscreated/images/8/84/WolfMeatSteakRaw_2048.png/revision/latest?cb=20190729025047");

            migrationBuilder.UpdateData(
                table: "PetFood",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://vignette.wikia.nocookie.net/miscreated/images/8/84/WolfMeatSteakRaw_2048.png/revision/latest?cb=20190729025047");
        }
    }
}
