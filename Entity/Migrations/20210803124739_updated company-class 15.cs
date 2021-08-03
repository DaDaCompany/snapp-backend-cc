using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class updatedcompanyclass15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Bill",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<int>(
                name: "BillNumber",
                table: "Bill",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillNumber",
                table: "Bill");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Bill",
                newName: "StartDate");
        }
    }
}
