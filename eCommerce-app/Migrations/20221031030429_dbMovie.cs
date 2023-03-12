using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerce_app.Migrations
{
    public partial class dbMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "producers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Movies",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "endDate",
                table: "Movies",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Actors",
                newName: "Id");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Movies",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "producers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Movies",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Movies",
                newName: "endDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Actors",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
