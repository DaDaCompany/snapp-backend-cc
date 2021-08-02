using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class updatedcustomerclasscontactdataList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Contactdatas_ContactdataId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ContactdataId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "ContactdataId",
                table: "Customers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Contactdatas",
                type: "varchar(36)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Contactdatas_CustomerId",
                table: "Contactdatas",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contactdatas_Customers_CustomerId",
                table: "Contactdatas",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contactdatas_Customers_CustomerId",
                table: "Contactdatas");

            migrationBuilder.DropIndex(
                name: "IX_Contactdatas_CustomerId",
                table: "Contactdatas");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Contactdatas");

            migrationBuilder.AlterColumn<string>(
                name: "ContactdataId",
                table: "Customers",
                type: "varchar(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ContactdataId",
                table: "Customers",
                column: "ContactdataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Contactdatas_ContactdataId",
                table: "Customers",
                column: "ContactdataId",
                principalTable: "Contactdatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
