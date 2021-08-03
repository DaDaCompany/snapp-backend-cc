using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class updatedcompanyclass11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectList_Bill_BillId",
                table: "ProjectList");

            migrationBuilder.DropIndex(
                name: "IX_ProjectList_BillId",
                table: "ProjectList");

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
                name: "BillId1",
                table: "ProjectList",
                type: "varchar(36)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "NetCost",
                table: "Bill",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "Bill",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<double>(
                name: "TotalCost",
                table: "Bill",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectList_BillId1",
                table: "ProjectList",
                column: "BillId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectList_Bill_BillId1",
                table: "ProjectList",
                column: "BillId1",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectList_Bill_BillId1",
                table: "ProjectList");

            migrationBuilder.DropIndex(
                name: "IX_ProjectList_BillId1",
                table: "ProjectList");

            migrationBuilder.DropColumn(
                name: "BillId1",
                table: "ProjectList");

            migrationBuilder.DropColumn(
                name: "NetCost",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "TotalCost",
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

            migrationBuilder.CreateIndex(
                name: "IX_ProjectList_BillId",
                table: "ProjectList",
                column: "BillId");

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
