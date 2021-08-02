using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class updatedprojectclass01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Contactdatas_ContactdataId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Company_CompanyId",
                table: "CompanyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectList_Bill_BillId",
                table: "ProjectList");

            migrationBuilder.DropIndex(
                name: "IX_ProjectList_BillId",
                table: "ProjectList");

            migrationBuilder.DropIndex(
                name: "IX_Company_ContactdataId",
                table: "Company");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "CompanyUser",
                newName: "CompanysId");

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

            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "Bill",
                type: "varchar(36)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Contactdatas_CompanyId",
                table: "Contactdatas",
                column: "CompanyId");

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
                name: "FK_CompanyUser_Company_CompanysId",
                table: "CompanyUser",
                column: "CompanysId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contactdatas_Company_CompanyId",
                table: "Contactdatas",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_ProjectList_ProjectId",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyUser_Company_CompanysId",
                table: "CompanyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Contactdatas_Company_CompanyId",
                table: "Contactdatas");

            migrationBuilder.DropIndex(
                name: "IX_Contactdatas_CompanyId",
                table: "Contactdatas");

            migrationBuilder.DropIndex(
                name: "IX_Bill_ProjectId",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Contactdatas");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Bill");

            migrationBuilder.RenameColumn(
                name: "CompanysId",
                table: "CompanyUser",
                newName: "CompanyId");

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
                table: "Company",
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

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyUser_Company_CompanyId",
                table: "CompanyUser",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectList_Bill_BillId",
                table: "ProjectList",
                column: "BillId",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
