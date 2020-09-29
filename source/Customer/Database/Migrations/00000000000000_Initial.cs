using Microsoft.EntityFrameworkCore.Migrations;

namespace Microservices.Customer.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Customers");

            migrationBuilder.CreateTable(
                name: "Customers",
                schema: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Forename = table.Column<string>(maxLength: 250, nullable: true),
                    Surname = table.Column<string>(maxLength: 250, nullable: true),
                    Email = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Customers",
                table: "Customers",
                columns: new[] { "Id", "Email", "Forename", "Surname" },
                values: new object[] { 1L, "albert.einstein@email.com", "Albert", "Einstein" });

            migrationBuilder.InsertData(
                schema: "Customers",
                table: "Customers",
                columns: new[] { "Id", "Email", "Forename", "Surname" },
                values: new object[] { 2L, "stephen.hawking@email.com", "Stephen", "Hawking" });

            migrationBuilder.InsertData(
                schema: "Customers",
                table: "Customers",
                columns: new[] { "Id", "Email", "Forename", "Surname" },
                values: new object[] { 3L, "ada.lovelace@email.com", "Ada", "Lovelace" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Email",
                schema: "Customers",
                table: "Customers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers",
                schema: "Customers");
        }
    }
}
