using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopPet.Migrations
{
    public partial class KhoiTao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Bull" },
                    { 2, 2, "Alaska" },
                    { 3, 3, "Husky" },
                    { 4, 4, "Chihuahua" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, null, null, "Bull Anh", 300.0 },
                    { 2, 1, null, null, "Bull Pháp", 350.0 },
                    { 3, 1, null, null, "American Bully", 400.0 },
                    { 4, 1, null, null, "American Pit Bull Terrier", 420.0 },
                    { 5, 2, null, null, "Alaska Sable – trắng", 630.0 },
                    { 6, 2, null, null, "Alaska màu lông xám – trắng", 750.0 },
                    { 7, 2, null, null, "Alaska màu lông nâu đỏ – trắng", 820.0 },
                    { 8, 3, null, null, "Husky màu đen trắng", 950.0 },
                    { 9, 3, null, null, "Husky màu xám", 1200.0 },
                    { 10, 3, null, null, "Husky màu trắng tinh khiết ", 1450.0 },
                    { 11, 3, null, null, "Husky màu đồng hoặc đỏ", 750.0 },
                    { 12, 4, null, null, "Chihuahua Socola", 1250.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
