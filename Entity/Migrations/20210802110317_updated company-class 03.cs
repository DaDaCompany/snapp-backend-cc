using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class updatedcompanyclass03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_ProjectList_ProjectId",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Contactdatas_Customers_CustomerId",
                table: "Contactdatas");

            migrationBuilder.DropIndex(
                name: "IX_Contactdatas_CustomerId",
                table: "Contactdatas");

            migrationBuilder.DropIndex(
                name: "IX_Bill_ProjectId",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Contactdatas");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Bill");

            migrationBuilder.AlterColumn<string>(
                name: "BillId",
                table: "ProjectList",
                type: "varchar(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
                name: "IX_ProjectList_BillId",
                table: "ProjectList",
                column: "BillId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectList_Bill_BillId",
                table: "ProjectList",
                column: "BillId",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Contactdatas_ContactdataId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectList_Bill_BillId",
                table: "ProjectList");

            migrationBuilder.DropIndex(
                name: "IX_ProjectList_BillId",
                table: "ProjectList");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ContactdataId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "BillId",
                table: "ProjectList",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "Bill",
                type: "varchar(36)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Contactdatas_CustomerId",
                table: "Contactdatas",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_ProjectId",
                table: "Bill",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_ProjectList_ProjectId",
                table: "Bill",
                column: "ProjectId",
                principalTable: "ProjectList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contactdatas_Customers_CustomerId",
                table: "Contactdatas",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
