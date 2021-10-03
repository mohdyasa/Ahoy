using Microsoft.EntityFrameworkCore.Migrations;

namespace Ahoy.Repository.Migrations
{
    public partial class addedHotelLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Hotels");
        }
    }
}
