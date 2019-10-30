using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_200412952.Data.Migrations
{
    public partial class SeedDataAndcreatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.AnimalId);
                });

            migrationBuilder.CreateTable(
                name: "PetFood",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    NutritionalInformation = table.Column<string>(nullable: true),
                    Weight = table.Column<float>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    AnimalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetFood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetFood_Animal_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animal",
                        principalColumn: "AnimalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "AnimalId", "Description", "Name" },
                values: new object[] { 1, "Big and cute", "Labrador" });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "AnimalId", "Description", "Name" },
                values: new object[] { 2, "HUGE and has lots of hair", "GIANT SCHNAUZER" });

            migrationBuilder.InsertData(
                table: "PetFood",
                columns: new[] { "Id", "AnimalId", "Brand", "Description", "Name", "NutritionalInformation", "Price", "Weight" },
                values: new object[] { 1, 2, "NoName", "Your pet will like it", "Meat", "It is probably healthy", 10m, 4f });

            migrationBuilder.CreateIndex(
                name: "IX_PetFood_AnimalId",
                table: "PetFood",
                column: "AnimalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetFood");

            migrationBuilder.DropTable(
                name: "Animal");
        }
    }
}
