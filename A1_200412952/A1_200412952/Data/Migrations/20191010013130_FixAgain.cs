using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_200412952.Data.Migrations
{
    public partial class FixAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PetFood",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: " ");

            migrationBuilder.UpdateData(
                table: "PetFood",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: " ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
