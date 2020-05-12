using Microsoft.EntityFrameworkCore.Migrations;

namespace Tobacco_Shop.Migrations
{
    public partial class MigStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tobaccos",
                columns: table => new
                {
                    TobaccoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ShortDescription = table.Column<string>(maxLength: 300, nullable: true),
                    LongDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    Price = table.Column<decimal>(maxLength: 2000, nullable: false),
                    ImageURL = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(maxLength: 2000, nullable: true),
                    IsTobaccoBest = table.Column<bool>(nullable: false),
                    Available = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tobaccos", x => x.TobaccoId);
                    table.ForeignKey(
                        name: "FK_Tobaccos_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ShoppingCartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TobaccoId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    SCartId = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ShoppingCartId);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Tobaccos_TobaccoId",
                        column: x => x.TobaccoId,
                        principalTable: "Tobaccos",
                        principalColumn: "TobaccoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_TobaccoId",
                table: "ShoppingCarts",
                column: "TobaccoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tobaccos_CategoryId",
                table: "Tobaccos",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Tobaccos");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
