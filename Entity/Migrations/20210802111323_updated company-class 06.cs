using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class updatedcompanyclass06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contactdatas_Company_CompanyId",
                table: "Contactdatas");

            migrationBuilder.DropIndex(
                name: "IX_Contactdatas_CompanyId",
                table: "Contactdatas");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Contactdatas");

            migrationBuilder.AlterColumn<string>(
                name: "ContactdataId",
                table: "Company",
                type: "varchar(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Company_ContactdataId",
                table: "Company",
                column: "ContactdataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Contactdatas_ContactdataId",
                table: "Company",
                column: "ContactdataId",
                principalTable: "Contactdatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Contactdatas_ContactdataId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_ContactdataId",
                table: "Company");

            migrationBuilder.AddColumn<string>(
                name: "CompanyId",
                table: "Contactdatas",
                type: "varchar(36)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ContactdataId",
                table: "Company",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Contactdatas_CompanyId",
                table: "Contactdatas",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contactdatas_Company_CompanyId",
                table: "Contactdatas",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
