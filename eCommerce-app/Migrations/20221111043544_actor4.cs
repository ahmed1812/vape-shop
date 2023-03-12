using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce_app.Migrations
{
    public partial class actor4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureURLt",
                table: "Actors",
                newName: "ProfilePictureURL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Actors",
                newName: "ProfilePictureURLt");
        }
    }
}
