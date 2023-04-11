using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BakeryShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,1)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Carrot Cake Any Description", "carrot_cake.jpg", "Carrot Cake", 15.5m },
                    { 2, "Lemo Tart Any Description", "lemon_tart.jpg", "Lemo Tart", 10.5m },
                    { 3, "Cup Cakes Any Description", "carrot_cake.jpg", "Cup Cakes", 13m },
                    { 4, "New Carrot Cake Any Description", "cupcakes.jpg", "New Cake", 18m },
                    { 5, "Bread Any Description", "bread.jpg", "Bread", 12m },
                    { 6, "Chocolate Cake Any Description", "chocolate_cake.jpg", "Chocolate Cake", 16m },
                    { 7, "Pear Tart Any Description", "pear_tart.jpg", "Pear Tart", 15m },
                    { 8, "Bread Any Description", "bread.jpg", "New Bread", 20m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
