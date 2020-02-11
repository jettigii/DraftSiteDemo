using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftSiteRepository.Migrations
{
    public partial class quickfi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasComputerTeams",
                table: "Drafts");

            migrationBuilder.AddColumn<bool>(
                name: "IsComputerTeams",
                table: "Drafts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComputerTeams",
                table: "Drafts");

            migrationBuilder.AddColumn<bool>(
                name: "HasComputerTeams",
                table: "Drafts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
