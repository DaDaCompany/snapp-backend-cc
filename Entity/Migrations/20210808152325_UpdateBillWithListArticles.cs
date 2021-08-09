using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class UpdateBillWithListArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BillId",
                table: "ArticleHistory",
                type: "varchar(36)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleHistory_BillId",
                table: "ArticleHistory",
                column: "BillId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleHistory_Bill_BillId",
                table: "ArticleHistory",
                column: "BillId",
                principalTable: "Bill",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleHistory_Bill_BillId",
                table: "ArticleHistory");

            migrationBuilder.DropIndex(
                name: "IX_ArticleHistory_BillId",
                table: "ArticleHistory");

            migrationBuilder.DropColumn(
                name: "BillId",
                table: "ArticleHistory");
        }
    }
}
