using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantSwap.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Swaps",
                columns: table => new
                {
                    SwapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IngredientToSwap = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    CuisineType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapOne = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapOneAbout = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapOneFlavorNotes = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapOnePrep = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapTwo = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapTwoAbout = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapTwoFlavorNotes = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapTwoPrep = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapThree = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapThreeAbout = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapThreeFlavorNotes = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SwapThreePrep = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Swaps", x => x.SwapId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Swaps");
        }
    }
}
