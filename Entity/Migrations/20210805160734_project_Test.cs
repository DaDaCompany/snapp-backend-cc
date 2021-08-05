using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class project_Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropIndex(
            //    name: "IX_ProjectList_BillId1",
            //    table: "ProjectList");

            //migrationBuilder.DropColumn(
            //    name: "BillId1",
            //    table: "ProjectList");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            //migrationBuilder.AddColumn<string>(
            //    name: "BillId1",
            //    table: "ProjectList",
            //    type: "varchar(36)",
            //    nullable: true)
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ProjectList_BillId1",
            //    table: "ProjectList",
            //    column: "BillId1");
        }
    }
}
