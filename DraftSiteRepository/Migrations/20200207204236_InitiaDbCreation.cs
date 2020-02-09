using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftSiteRepository.Migrations
{
    public partial class InitiaDbCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drafts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HasComputerTeams = table.Column<bool>(nullable: false),
                    IsPublic = table.Column<bool>(nullable: false),
                    IsSinglePick = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    PickTime = table.Column<int>(nullable: false),
                    RoundCount = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTimeOffset>(nullable: false),
                    UserId = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drafts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DraftSiteUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Token = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DraftSiteUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    College = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DraftUsers",
                columns: table => new
                {
                    DraftId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DraftUsers", x => new { x.DraftId, x.UserId });
                    table.ForeignKey(
                        name: "FK_DraftUsers_Drafts_DraftId",
                        column: x => x.DraftId,
                        principalTable: "Drafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DraftUsers_DraftSiteUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "DraftSiteUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DraftTeamUsers",
                columns: table => new
                {
                    DraftId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DraftTeamUsers", x => new { x.DraftId, x.UserId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_DraftTeamUsers_Drafts_DraftId",
                        column: x => x.DraftId,
                        principalTable: "Drafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DraftTeamUsers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DraftTeamUsers_DraftUsers_DraftId_UserId",
                        columns: x => new { x.DraftId, x.UserId },
                        principalTable: "DraftUsers",
                        principalColumns: new[] { "DraftId", "UserId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DraftTeamUserPlayers",
                columns: table => new
                {
                    DraftId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DraftTeamUserPlayers", x => new { x.DraftId, x.UserId, x.TeamId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_DraftTeamUserPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DraftTeamUserPlayers_DraftTeamUsers_DraftId_TeamId_UserId",
                        columns: x => new { x.DraftId, x.TeamId, x.UserId },
                        principalTable: "DraftTeamUsers",
                        principalColumns: new[] { "DraftId", "UserId", "TeamId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DraftTeamUserPlayers_PlayerId",
                table: "DraftTeamUserPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_DraftTeamUserPlayers_DraftId_TeamId_UserId",
                table: "DraftTeamUserPlayers",
                columns: new[] { "DraftId", "TeamId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_DraftTeamUsers_TeamId",
                table: "DraftTeamUsers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_DraftUsers_UserId",
                table: "DraftUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DraftTeamUserPlayers");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "DraftTeamUsers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "DraftUsers");

            migrationBuilder.DropTable(
                name: "Drafts");

            migrationBuilder.DropTable(
                name: "DraftSiteUsers");
        }
    }
}
