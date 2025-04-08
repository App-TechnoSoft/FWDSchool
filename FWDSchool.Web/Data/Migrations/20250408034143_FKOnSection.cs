using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FWDSchool.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class FKOnSection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TutorialSections_TutorialId",
                table: "TutorialSections",
                column: "TutorialId");

            migrationBuilder.AddForeignKey(
                name: "FK_TutorialSections_Tutorials_TutorialId",
                table: "TutorialSections",
                column: "TutorialId",
                principalTable: "Tutorials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TutorialSections_Tutorials_TutorialId",
                table: "TutorialSections");

            migrationBuilder.DropIndex(
                name: "IX_TutorialSections_TutorialId",
                table: "TutorialSections");
        }
    }
}
