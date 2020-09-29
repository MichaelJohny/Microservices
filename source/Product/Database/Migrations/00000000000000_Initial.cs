using Microsoft.EntityFrameworkCore.Migrations;

namespace Microservices.Product.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Products");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Products",
                table: "Products",
                columns: new[] { "Id", "Description", "Price" },
                values: new object[] { 1L, "Computer", 5000m });

            migrationBuilder.InsertData(
                schema: "Products",
                table: "Products",
                columns: new[] { "Id", "Description", "Price" },
                values: new object[] { 2L, "Car", 50000m });

            migrationBuilder.InsertData(
                schema: "Products",
                table: "Products",
                columns: new[] { "Id", "Description", "Price" },
                values: new object[] { 3L, "Rocket", 50000000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "Products");
        }
    }
}
