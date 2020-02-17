using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftSiteRepository.Migrations
{
    public partial class InitialMigraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "draft_site_users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    token = table.Column<string>(nullable: true),
                    username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_draft_site_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "draft_start_types",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    value = table.Column<string>(nullable: true),
                    is_enabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_draft_start_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "draft_statuses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_draft_statuses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "draft_times",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    time_in_seconds = table.Column<int>(nullable: false),
                    value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_draft_times", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "players",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    college = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_players", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_teams", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "drafts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    is_computer_teams = table.Column<bool>(nullable: false),
                    is_public = table.Column<bool>(nullable: false),
                    is_multi_select = table.Column<bool>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    pick_time_id = table.Column<int>(nullable: false),
                    round_count = table.Column<int>(nullable: false),
                    start_time = table.Column<DateTimeOffset>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    owner_id = table.Column<int>(nullable: false),
                    draft_status_id = table.Column<int>(nullable: false),
                    draft_start_type_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_drafts", x => x.id);
                    table.ForeignKey(
                        name: "fk_drafts_draft_start_types_draft_start_type_id",
                        column: x => x.draft_start_type_id,
                        principalTable: "draft_start_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_drafts_draft_statuses_draft_status_id",
                        column: x => x.draft_status_id,
                        principalTable: "draft_statuses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_drafts_draft_site_users_owner_id",
                        column: x => x.owner_id,
                        principalTable: "draft_site_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_drafts_draft_times_pick_time_id",
                        column: x => x.pick_time_id,
                        principalTable: "draft_times",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "draft_users",
                columns: table => new
                {
                    draft_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_draft_users", x => new { x.draft_id, x.user_id });
                    table.ForeignKey(
                        name: "fk_draft_users_drafts_draft_id",
                        column: x => x.draft_id,
                        principalTable: "drafts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_draft_users_draft_site_users_user_id",
                        column: x => x.user_id,
                        principalTable: "draft_site_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "draft_team_users",
                columns: table => new
                {
                    draft_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    team_id = table.Column<int>(nullable: false),
                    is_computer = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_draft_team_users", x => new { x.draft_id, x.user_id, x.team_id });
                    table.ForeignKey(
                        name: "fk_draft_team_users_drafts_draft_id",
                        column: x => x.draft_id,
                        principalTable: "drafts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_draft_team_users_teams_team_id",
                        column: x => x.team_id,
                        principalTable: "teams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_draft_team_users_draft_users_draft_id_user_id",
                        columns: x => new { x.draft_id, x.user_id },
                        principalTable: "draft_users",
                        principalColumns: new[] { "draft_id", "user_id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "draft_team_user_players",
                columns: table => new
                {
                    draft_id = table.Column<int>(nullable: false),
                    team_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    player_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_draft_team_user_players", x => new { x.draft_id, x.user_id, x.team_id, x.player_id });
                    table.ForeignKey(
                        name: "fk_draft_team_user_players_players_player_id",
                        column: x => x.player_id,
                        principalTable: "players",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_draft_team_user_players_draft_team_users_draft_id_team_id_us~",
                        columns: x => new { x.draft_id, x.team_id, x.user_id },
                        principalTable: "draft_team_users",
                        principalColumns: new[] { "draft_id", "user_id", "team_id" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "draft_start_types",
                columns: new[] { "id", "is_enabled", "name", "value" },
                values: new object[,]
                {
                    { 1, true, "Manual", "Manual" },
                    { 2, false, "Automatic", "Automatic" }
                });

            migrationBuilder.InsertData(
                table: "draft_statuses",
                columns: new[] { "id", "name", "value" },
                values: new object[,]
                {
                    { 1, "WaitingForPlayers", "Waiting for players" },
                    { 2, "WaitingForOwnerToStart", "Waiting for owner" },
                    { 3, "WaitingForTimerToStart", "Waiting for time" },
                    { 4, "InProgress", "In Progress" },
                    { 5, "Paused", "Paused" },
                    { 6, "Completed", "Completed" },
                    { 7, "Canceled", "Canceled" }
                });

            migrationBuilder.InsertData(
                table: "draft_times",
                columns: new[] { "id", "name", "time_in_seconds", "value" },
                values: new object[,]
                {
                    { 1, "ThirtySeconds", 30, "30 Seconds" },
                    { 2, "OneMinute", 60, "1 Minute" },
                    { 3, "FiveMinutes", 300, "5 Minutes" },
                    { 4, "OneHour", 3600, "1 Hour" },
                    { 5, "Unlimited", 0, "Unlimited" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_draft_team_user_players_player_id",
                table: "draft_team_user_players",
                column: "player_id");

            migrationBuilder.CreateIndex(
                name: "ix_draft_team_user_players_draft_id_team_id_user_id",
                table: "draft_team_user_players",
                columns: new[] { "draft_id", "team_id", "user_id" });

            migrationBuilder.CreateIndex(
                name: "ix_draft_team_users_team_id",
                table: "draft_team_users",
                column: "team_id");

            migrationBuilder.CreateIndex(
                name: "ix_draft_users_user_id",
                table: "draft_users",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_drafts_draft_start_type_id",
                table: "drafts",
                column: "draft_start_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_drafts_draft_status_id",
                table: "drafts",
                column: "draft_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_drafts_owner_id",
                table: "drafts",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "ix_drafts_pick_time_id",
                table: "drafts",
                column: "pick_time_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "draft_team_user_players");

            migrationBuilder.DropTable(
                name: "players");

            migrationBuilder.DropTable(
                name: "draft_team_users");

            migrationBuilder.DropTable(
                name: "teams");

            migrationBuilder.DropTable(
                name: "draft_users");

            migrationBuilder.DropTable(
                name: "drafts");

            migrationBuilder.DropTable(
                name: "draft_start_types");

            migrationBuilder.DropTable(
                name: "draft_statuses");

            migrationBuilder.DropTable(
                name: "draft_site_users");

            migrationBuilder.DropTable(
                name: "draft_times");
        }
    }
}
