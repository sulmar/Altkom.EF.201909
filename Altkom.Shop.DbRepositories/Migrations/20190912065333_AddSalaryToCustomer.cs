using Microsoft.EntityFrameworkCore.Migrations;

namespace Altkom.Shop.DbRepositories.Migrations
{
    public partial class AddSalaryToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Customers",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Customers");
        }
    }
}
