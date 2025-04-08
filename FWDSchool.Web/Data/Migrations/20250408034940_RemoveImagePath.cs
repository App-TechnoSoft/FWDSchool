using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FWDSchool.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "TutorialSections");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "TutorialSections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
