using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class updatedcontactdataclassAdressList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contactdatas_Addresses_AddressId",
                table: "Contactdatas");

            migrationBuilder.DropIndex(
                name: "IX_Contactdatas_AddressId",
                table: "Contactdatas");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Contactdatas");

            migrationBuilder.AddColumn<string>(
                name: "ContactdataId",
                table: "Addresses",
                type: "varchar(36)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ContactdataId",
                table: "Addresses",
                column: "ContactdataId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Contactdatas_ContactdataId",
                table: "Addresses",
                column: "ContactdataId",
                principalTable: "Contactdatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Contactdatas_ContactdataId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ContactdataId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ContactdataId",
                table: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "AddressId",
                table: "Contactdatas",
                type: "varchar(36)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Contactdatas_AddressId",
                table: "Contactdatas",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contactdatas_Addresses_AddressId",
                table: "Contactdatas",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
