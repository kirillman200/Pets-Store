using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_200412952.Data.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PetFood",
                columns: new[] { "Id", "AnimalId", "Brand", "Description", "ImageUrl", "Name", "NutritionalInformation", "Price", "Weight" },
                values: new object[] { 2, 1, "PetFoods", "It will last for 2 months", null, "Bone", "Just a bone", 1m, 1f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PetFood",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
