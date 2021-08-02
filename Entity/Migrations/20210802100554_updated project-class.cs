using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class updatedprojectclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectList_Customers_CustomerId",
                table: "ProjectList");

            migrationBuilder.DropIndex(
                name: "IX_ProjectList_CustomerId",
                table: "ProjectList");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "ProjectList",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CustomerProject",
                columns: table => new
                {
                    CustomersId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProjectsId = table.Column<string>(type: "varchar(36)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProject", x => new { x.CustomersId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_CustomerProject_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProject_ProjectList_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "ProjectList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProject_ProjectsId",
                table: "CustomerProject",
                column: "ProjectsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerProject");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "ProjectList",
                type: "varchar(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectList_CustomerId",
                table: "ProjectList",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectList_Customers_CustomerId",
                table: "ProjectList",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
