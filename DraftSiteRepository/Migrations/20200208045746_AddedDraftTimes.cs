using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftSiteRepository.Migrations
{
    public partial class AddedDraftTimes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PickTime",
                table: "Drafts");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Drafts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(80) CHARACTER SET utf8mb4",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Drafts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PickTimeId",
                table: "Drafts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DraftTimes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TimeInSeconds = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DraftTimes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DraftTimes",
                columns: new[] { "Id", "Name", "TimeInSeconds", "Value" },
                values: new object[,]
                {
                    { 1, "ThirtySeconds", 30, "30 Seconds" },
                    { 2, "OneMinute", 60, "1 Minute" },
                    { 3, "FiveMinutes", 300, "5 Minutes" },
                    { 4, "OneHour", 3600, "1 Hour" },
                    { 5, "Unlimited", 0, "Unlimited" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drafts_OwnerId",
                table: "Drafts",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Drafts_PickTimeId",
                table: "Drafts",
                column: "PickTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drafts_DraftSiteUsers_OwnerId",
                table: "Drafts",
                column: "OwnerId",
                principalTable: "DraftSiteUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Drafts_DraftTimes_PickTimeId",
                table: "Drafts",
                column: "PickTimeId",
                principalTable: "DraftTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drafts_DraftSiteUsers_OwnerId",
                table: "Drafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Drafts_DraftTimes_PickTimeId",
                table: "Drafts");

            migrationBuilder.DropTable(
                name: "DraftTimes");

            migrationBuilder.DropIndex(
                name: "IX_Drafts_OwnerId",
                table: "Drafts");

            migrationBuilder.DropIndex(
                name: "IX_Drafts_PickTimeId",
                table: "Drafts");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Drafts");

            migrationBuilder.DropColumn(
                name: "PickTimeId",
                table: "Drafts");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Drafts",
                type: "varchar(80) CHARACTER SET utf8mb4",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PickTime",
                table: "Drafts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
