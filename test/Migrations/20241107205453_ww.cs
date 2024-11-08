using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    public partial class ww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idmain",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idmain",
                table: "Item");
        }
    }
}
