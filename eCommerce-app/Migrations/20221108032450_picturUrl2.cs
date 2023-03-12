using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce_app.Migrations
{
    public partial class picturUrl2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePicturURL",
                table: "producers",
                newName: "ProfilePictureURL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "producers",
                newName: "ProfilePicturURL");
        }
    }
}
