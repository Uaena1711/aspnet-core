using Microsoft.EntityFrameworkCore.Migrations;

namespace tmss.Migrations
{
    public partial class fixincometype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Input",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "Income",
                table: "Customer",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Income",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "Input",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
