using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftSiteRepository.Migrations
{
    public partial class FirstCleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drafts_DraftSiteUsers_OwnerId",
                table: "Drafts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Drafts");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Drafts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Drafts_DraftSiteUsers_OwnerId",
                table: "Drafts",
                column: "OwnerId",
                principalTable: "DraftSiteUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drafts_DraftSiteUsers_OwnerId",
                table: "Drafts");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Drafts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Drafts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Drafts_DraftSiteUsers_OwnerId",
                table: "Drafts",
                column: "OwnerId",
                principalTable: "DraftSiteUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
