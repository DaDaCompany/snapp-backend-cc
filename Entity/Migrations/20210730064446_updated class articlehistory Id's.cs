using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class updatedclassarticlehistoryIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleHistory_ArticleList_BaseArticleId",
                table: "ArticleHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleHistory_ProjectList_ProjectId",
                table: "ArticleHistory");

            migrationBuilder.DropIndex(
                name: "IX_ArticleHistory_BaseArticleId",
                table: "ArticleHistory");

            migrationBuilder.DropIndex(
                name: "IX_ArticleHistory_ProjectId",
                table: "ArticleHistory");

            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                table: "ArticleHistory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BaseArticleId",
                table: "ArticleHistory",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProjectId",
                table: "ArticleHistory",
                type: "varchar(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "BaseArticleId",
                table: "ArticleHistory",
                type: "varchar(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleHistory_BaseArticleId",
                table: "ArticleHistory",
                column: "BaseArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleHistory_ProjectId",
                table: "ArticleHistory",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleHistory_ArticleList_BaseArticleId",
                table: "ArticleHistory",
                column: "BaseArticleId",
                principalTable: "ArticleList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleHistory_ProjectList_ProjectId",
                table: "ArticleHistory",
                column: "ProjectId",
                principalTable: "ProjectList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
