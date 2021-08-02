using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class updatedprojectclassagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Customers_CustomerId",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_CustomerId",
                table: "Bill");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ProjectList",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "BillId",
                table: "Customers",
                type: "varchar(36)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Bill",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_BillId",
                table: "Customers",
                column: "BillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Bill_BillId",
                table: "Customers",
                column: "BillId",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Bill_BillId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_BillId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProjectList");

            migrationBuilder.DropColumn(
                name: "BillId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Bill",
                type: "varchar(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CustomerId",
                table: "Bill",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Customers_CustomerId",
                table: "Bill",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
