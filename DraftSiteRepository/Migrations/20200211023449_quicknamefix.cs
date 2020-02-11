using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftSiteRepository.Migrations
{
    public partial class quicknamefix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSinglePick",
                table: "Drafts");

            migrationBuilder.AddColumn<bool>(
                name: "IsMultiSelect",
                table: "Drafts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMultiSelect",
                table: "Drafts");

            migrationBuilder.AddColumn<bool>(
                name: "IsSinglePick",
                table: "Drafts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
