using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftSiteRepository.Migrations
{
    public partial class AddSnakeCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DraftTeamUserPlayers_players_PlayerId",
                table: "DraftTeamUserPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_DraftTeamUserPlayers_DraftTeamUsers_DraftId_TeamId_UserId",
                table: "DraftTeamUserPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_DraftTeamUsers_MultiPlayerDrafts_MultiplayerDraftId",
                table: "DraftTeamUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_DraftTeamUsers_teams_TeamId",
                table: "DraftTeamUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_DraftTeamUsers_DraftUsers_DraftId_UserId",
                table: "DraftTeamUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_DraftUsers_MultiPlayerDrafts_DraftId",
                table: "DraftUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_DraftUsers_users_UserId",
                table: "DraftUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_MultiPlayerDrafts_DraftStartTypes_DraftStartTypeId",
                table: "MultiPlayerDrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_MultiPlayerDrafts_DraftStatuses_DraftStatusId",
                table: "MultiPlayerDrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_MultiPlayerDrafts_users_OwnerId",
                table: "MultiPlayerDrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_MultiPlayerDrafts_DraftTimes_PickTimeId",
                table: "MultiPlayerDrafts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userranks_copy",
                table: "userranks_copy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userranks",
                table: "userranks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_team_picks",
                table: "user_team_picks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_team_draft_analysis_picks",
                table: "user_team_draft_analysis_picks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_team_draft_analysis",
                table: "user_team_draft_analysis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_redrafts",
                table: "user_redrafts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_players",
                table: "user_players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_player_rankings",
                table: "user_player_rankings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_mock_drafts_contest",
                table: "user_mock_drafts_contest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_mock_drafts",
                table: "user_mock_drafts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_gamification_points",
                table: "user_gamification_points");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_gamification_calculation",
                table: "user_gamification_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "user_draft_votes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_auth_tokens",
                table: "user_auth_tokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tradetransactions",
                table: "tradetransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_trades",
                table: "trades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tradecheck",
                table: "tradecheck");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teams_previous_names",
                table: "teams_previous_names");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teams",
                table: "teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_team_draft_analysis",
                table: "team_draft_analysis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_suppicks",
                table: "suppicks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_staticpicks",
                table: "staticpicks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_states",
                table: "states");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sports",
                table: "sports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_settings",
                table: "settings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_schools",
                table: "schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rules",
                table: "rules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rounds",
                table: "rounds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_reset_password",
                table: "reset_password");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ranks_temp",
                table: "ranks_temp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ranks",
                table: "ranks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_positions_sub",
                table: "positions_sub");

            migrationBuilder.DropPrimaryKey(
                name: "PK_positions",
                table: "positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_players",
                table: "players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_player_content_types",
                table: "player_content_types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_player_content",
                table: "player_content");

            migrationBuilder.DropPrimaryKey(
                name: "PK_picks_temp",
                table: "picks_temp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_picks",
                table: "picks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_permissions",
                table: "permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "mock_trades");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "mock_rounds");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "mock_picks_deleted");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "mock_picks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mock_drafts_deleted",
                table: "mock_drafts_deleted");

            migrationBuilder.DropPrimaryKey(
                name: "PK_mock_drafts",
                table: "mock_drafts");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "login_cookie_data");

            migrationBuilder.DropPrimaryKey(
                name: "PK_leagues",
                table: "leagues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_globals",
                table: "globals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_games",
                table: "games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_fantasy_rankings",
                table: "fantasy_rankings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_fantasy",
                table: "fantasy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_draftteams",
                table: "draftteams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drafts_unpublished",
                table: "drafts_unpublished");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drafts",
                table: "drafts");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "draft_versions");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "draft_players");

            migrationBuilder.DropPrimaryKey(
                name: "PRIMARY",
                table: "draft_picks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_draft_contributors",
                table: "draft_contributors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_countries",
                table: "countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_conferences",
                table: "conferences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blogposts_bak",
                table: "blogposts_bak");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blogposts",
                table: "blogposts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_authors",
                table: "authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ads",
                table: "ads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admin_auth_tokens",
                table: "admin_auth_tokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_admin",
                table: "admin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MultiPlayerDrafts",
                table: "MultiPlayerDrafts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DraftUsers",
                table: "DraftUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DraftTimes",
                table: "DraftTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DraftTeamUsers",
                table: "DraftTeamUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DraftTeamUserPlayers",
                table: "DraftTeamUserPlayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DraftStatuses",
                table: "DraftStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DraftStartTypes",
                table: "DraftStartTypes");

            migrationBuilder.RenameTable(
                name: "MultiPlayerDrafts",
                newName: "multi_player_drafts");

            migrationBuilder.RenameTable(
                name: "DraftUsers",
                newName: "draft_users");

            migrationBuilder.RenameTable(
                name: "DraftTimes",
                newName: "draft_times");

            migrationBuilder.RenameTable(
                name: "DraftTeamUsers",
                newName: "draft_team_users");

            migrationBuilder.RenameTable(
                name: "DraftTeamUserPlayers",
                newName: "draft_team_user_players");

            migrationBuilder.RenameTable(
                name: "DraftStatuses",
                newName: "draft_statuses");

            migrationBuilder.RenameTable(
                name: "DraftStartTypes",
                newName: "draft_start_types");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "multi_player_drafts",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "multi_player_drafts",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "multi_player_drafts",
                newName: "start_time");

            migrationBuilder.RenameColumn(
                name: "RoundCount",
                table: "multi_player_drafts",
                newName: "round_count");

            migrationBuilder.RenameColumn(
                name: "PickTimeId",
                table: "multi_player_drafts",
                newName: "pick_time_id");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "multi_player_drafts",
                newName: "owner_id");

            migrationBuilder.RenameColumn(
                name: "IsPublic",
                table: "multi_player_drafts",
                newName: "is_public");

            migrationBuilder.RenameColumn(
                name: "IsMultiSelect",
                table: "multi_player_drafts",
                newName: "is_multi_select");

            migrationBuilder.RenameColumn(
                name: "IsComputerTeams",
                table: "multi_player_drafts",
                newName: "is_computer_teams");

            migrationBuilder.RenameColumn(
                name: "DraftStatusId",
                table: "multi_player_drafts",
                newName: "draft_status_id");

            migrationBuilder.RenameColumn(
                name: "DraftStartTypeId",
                table: "multi_player_drafts",
                newName: "draft_start_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_MultiPlayerDrafts_PickTimeId",
                table: "multi_player_drafts",
                newName: "ix_multi_player_drafts_pick_time_id");

            migrationBuilder.RenameIndex(
                name: "IX_MultiPlayerDrafts_OwnerId",
                table: "multi_player_drafts",
                newName: "ix_multi_player_drafts_owner_id");

            migrationBuilder.RenameIndex(
                name: "IX_MultiPlayerDrafts_DraftStatusId",
                table: "multi_player_drafts",
                newName: "ix_multi_player_drafts_draft_status_id");

            migrationBuilder.RenameIndex(
                name: "IX_MultiPlayerDrafts_DraftStartTypeId",
                table: "multi_player_drafts",
                newName: "ix_multi_player_drafts_draft_start_type_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "draft_users",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "DraftId",
                table: "draft_users",
                newName: "draft_id");

            migrationBuilder.RenameIndex(
                name: "IX_DraftUsers_UserId",
                table: "draft_users",
                newName: "ix_draft_users_user_id");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "draft_times",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "draft_times",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "draft_times",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TimeInSeconds",
                table: "draft_times",
                newName: "time_in_seconds");

            migrationBuilder.RenameColumn(
                name: "MultiplayerDraftId",
                table: "draft_team_users",
                newName: "multiplayer_draft_id");

            migrationBuilder.RenameColumn(
                name: "IsComputer",
                table: "draft_team_users",
                newName: "is_computer");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "draft_team_users",
                newName: "team_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "draft_team_users",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "DraftId",
                table: "draft_team_users",
                newName: "draft_id");

            migrationBuilder.RenameIndex(
                name: "IX_DraftTeamUsers_TeamId",
                table: "draft_team_users",
                newName: "ix_draft_team_users_team_id");

            migrationBuilder.RenameIndex(
                name: "IX_DraftTeamUsers_MultiplayerDraftId",
                table: "draft_team_users",
                newName: "ix_draft_team_users_multiplayer_draft_id");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "draft_team_user_players",
                newName: "player_id");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "draft_team_user_players",
                newName: "team_id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "draft_team_user_players",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "DraftId",
                table: "draft_team_user_players",
                newName: "draft_id");

            migrationBuilder.RenameIndex(
                name: "IX_DraftTeamUserPlayers_DraftId_TeamId_UserId",
                table: "draft_team_user_players",
                newName: "ix_draft_team_user_players_draft_id_team_id_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_DraftTeamUserPlayers_PlayerId",
                table: "draft_team_user_players",
                newName: "ix_draft_team_user_players_player_id");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "draft_statuses",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "draft_statuses",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "draft_statuses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "draft_start_types",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "draft_start_types",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "draft_start_types",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IsEnabled",
                table: "draft_start_types",
                newName: "is_enabled");

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "users",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "userranks_copy",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "userranks",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_team_picks",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_team_draft_analysis_picks",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_team_draft_analysis",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_redrafts",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_players",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_mock_drafts_contest",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_mock_drafts",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_gamification_points",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_auth_tokens",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "tradetransactions",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "trades",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "teams_previous_names",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "teams",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "team_draft_analysis",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "suppicks",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "states",
                type: "int(11) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(11) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "sports",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "settings",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "schools",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "rules",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "rounds",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "reset_password",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "positions",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "picks",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "permissions",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "leagues",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "fantasy_rankings",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "fantasy",
                type: "int(11) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(11) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "draftteams",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "drafts_unpublished",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "drafts",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "draft_contributors",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "countries",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "conferences",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "blogposts_bak",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "blogposts",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "ads",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "admin_auth_tokens",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "admin",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "pk_users",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_userranks_copy",
                table: "userranks_copy",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_userranks",
                table: "userranks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_team_picks",
                table: "user_team_picks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_team_draft_analysis_picks",
                table: "user_team_draft_analysis_picks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_team_draft_analysis",
                table: "user_team_draft_analysis",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_redrafts",
                table: "user_redrafts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_players",
                table: "user_players",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_player_rankings",
                table: "user_player_rankings",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_mock_drafts_contest",
                table: "user_mock_drafts_contest",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_mock_drafts",
                table: "user_mock_drafts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_gamification_points",
                table: "user_gamification_points",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_gamification_calculation",
                table: "user_gamification_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "primary",
                table: "user_draft_votes",
                columns: new[] { "voting_user_id", "owner_user_id", "draft_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_user_auth_tokens",
                table: "user_auth_tokens",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_tradetransactions",
                table: "tradetransactions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_trades",
                table: "trades",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_tradecheck",
                table: "tradecheck",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_teams_previous_names",
                table: "teams_previous_names",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_teams",
                table: "teams",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_team_draft_analysis",
                table: "team_draft_analysis",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_suppicks",
                table: "suppicks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_staticpicks",
                table: "staticpicks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_states",
                table: "states",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_sports",
                table: "sports",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_settings",
                table: "settings",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_schools",
                table: "schools",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_rules",
                table: "rules",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_rounds",
                table: "rounds",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_reset_password",
                table: "reset_password",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_ranks_temp",
                table: "ranks_temp",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_ranks",
                table: "ranks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_positions_sub",
                table: "positions_sub",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_positions",
                table: "positions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_players",
                table: "players",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_player_content_types",
                table: "player_content_types",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_player_content",
                table: "player_content",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_picks_temp",
                table: "picks_temp",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_picks",
                table: "picks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_permissions",
                table: "permissions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "primary",
                table: "mock_trades",
                columns: new[] { "mock_draft_id", "pick_order" });

            migrationBuilder.AddPrimaryKey(
                name: "primary",
                table: "mock_rounds",
                columns: new[] { "mock_draft_id", "order" });

            migrationBuilder.AddPrimaryKey(
                name: "primary",
                table: "mock_picks_deleted",
                columns: new[] { "mock_draft_id", "order" });

            migrationBuilder.AddPrimaryKey(
                name: "primary",
                table: "mock_picks",
                columns: new[] { "mock_draft_id", "order" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_mock_drafts_deleted",
                table: "mock_drafts_deleted",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_mock_drafts",
                table: "mock_drafts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "primary",
                table: "login_cookie_data",
                columns: new[] { "user_id", "series", "token" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_leagues",
                table: "leagues",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_globals",
                table: "globals",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_games",
                table: "games",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_fantasy_rankings",
                table: "fantasy_rankings",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_fantasy",
                table: "fantasy",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_draftteams",
                table: "draftteams",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_drafts_unpublished",
                table: "drafts_unpublished",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_drafts",
                table: "drafts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "primary",
                table: "draft_versions",
                columns: new[] { "draft_id", "rank_type" });

            migrationBuilder.AddPrimaryKey(
                name: "primary",
                table: "draft_players",
                columns: new[] { "draft_id", "rank_type", "rank" });

            migrationBuilder.AddPrimaryKey(
                name: "primary",
                table: "draft_picks",
                columns: new[] { "draft_id", "order" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_draft_contributors",
                table: "draft_contributors",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_countries",
                table: "countries",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_conferences",
                table: "conferences",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_blogposts_bak",
                table: "blogposts_bak",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_blogposts",
                table: "blogposts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_authors",
                table: "authors",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_ads",
                table: "ads",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_admin_auth_tokens",
                table: "admin_auth_tokens",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_admin",
                table: "admin",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_multi_player_drafts",
                table: "multi_player_drafts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_draft_users",
                table: "draft_users",
                columns: new[] { "draft_id", "user_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_draft_times",
                table: "draft_times",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_draft_team_users",
                table: "draft_team_users",
                columns: new[] { "draft_id", "user_id", "team_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_draft_team_user_players",
                table: "draft_team_user_players",
                columns: new[] { "draft_id", "user_id", "team_id", "player_id" });

            migrationBuilder.AddPrimaryKey(
                name: "pk_draft_statuses",
                table: "draft_statuses",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_draft_start_types",
                table: "draft_start_types",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_draft_team_user_players_players_player_id",
                table: "draft_team_user_players",
                column: "player_id",
                principalTable: "players",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_draft_team_user_players_draft_team_users_draft_id_team_id_us~",
                table: "draft_team_user_players",
                columns: new[] { "draft_id", "team_id", "user_id" },
                principalTable: "draft_team_users",
                principalColumns: new[] { "draft_id", "user_id", "team_id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_draft_team_users_multi_player_drafts_multiplayer_draft_id",
                table: "draft_team_users",
                column: "multiplayer_draft_id",
                principalTable: "multi_player_drafts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_draft_team_users_teams_team_id",
                table: "draft_team_users",
                column: "team_id",
                principalTable: "teams",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_draft_team_users_draft_users_draft_id_user_id",
                table: "draft_team_users",
                columns: new[] { "draft_id", "user_id" },
                principalTable: "draft_users",
                principalColumns: new[] { "draft_id", "user_id" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_draft_users_multi_player_drafts_draft_id",
                table: "draft_users",
                column: "draft_id",
                principalTable: "multi_player_drafts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_draft_users_users_user_id",
                table: "draft_users",
                column: "user_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_multi_player_drafts_draft_start_types_draft_start_type_id",
                table: "multi_player_drafts",
                column: "draft_start_type_id",
                principalTable: "draft_start_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_multi_player_drafts_draft_statuses_draft_status_id",
                table: "multi_player_drafts",
                column: "draft_status_id",
                principalTable: "draft_statuses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_multi_player_drafts_users_owner_id",
                table: "multi_player_drafts",
                column: "owner_id",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_multi_player_drafts_draft_times_pick_time_id",
                table: "multi_player_drafts",
                column: "pick_time_id",
                principalTable: "draft_times",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_draft_team_user_players_players_player_id",
                table: "draft_team_user_players");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_team_user_players_draft_team_users_draft_id_team_id_us~",
                table: "draft_team_user_players");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_team_users_multi_player_drafts_multiplayer_draft_id",
                table: "draft_team_users");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_team_users_teams_team_id",
                table: "draft_team_users");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_team_users_draft_users_draft_id_user_id",
                table: "draft_team_users");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_users_multi_player_drafts_draft_id",
                table: "draft_users");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_users_users_user_id",
                table: "draft_users");

            migrationBuilder.DropForeignKey(
                name: "fk_multi_player_drafts_draft_start_types_draft_start_type_id",
                table: "multi_player_drafts");

            migrationBuilder.DropForeignKey(
                name: "fk_multi_player_drafts_draft_statuses_draft_status_id",
                table: "multi_player_drafts");

            migrationBuilder.DropForeignKey(
                name: "fk_multi_player_drafts_users_owner_id",
                table: "multi_player_drafts");

            migrationBuilder.DropForeignKey(
                name: "fk_multi_player_drafts_draft_times_pick_time_id",
                table: "multi_player_drafts");

            migrationBuilder.DropPrimaryKey(
                name: "pk_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_userranks_copy",
                table: "userranks_copy");

            migrationBuilder.DropPrimaryKey(
                name: "pk_userranks",
                table: "userranks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_team_picks",
                table: "user_team_picks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_team_draft_analysis_picks",
                table: "user_team_draft_analysis_picks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_team_draft_analysis",
                table: "user_team_draft_analysis");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_redrafts",
                table: "user_redrafts");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_players",
                table: "user_players");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_player_rankings",
                table: "user_player_rankings");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_mock_drafts_contest",
                table: "user_mock_drafts_contest");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_mock_drafts",
                table: "user_mock_drafts");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_gamification_points",
                table: "user_gamification_points");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_gamification_calculation",
                table: "user_gamification_calculation");

            migrationBuilder.DropPrimaryKey(
                name: "primary",
                table: "user_draft_votes");

            migrationBuilder.DropPrimaryKey(
                name: "pk_user_auth_tokens",
                table: "user_auth_tokens");

            migrationBuilder.DropPrimaryKey(
                name: "pk_tradetransactions",
                table: "tradetransactions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_trades",
                table: "trades");

            migrationBuilder.DropPrimaryKey(
                name: "pk_tradecheck",
                table: "tradecheck");

            migrationBuilder.DropPrimaryKey(
                name: "pk_teams_previous_names",
                table: "teams_previous_names");

            migrationBuilder.DropPrimaryKey(
                name: "pk_teams",
                table: "teams");

            migrationBuilder.DropPrimaryKey(
                name: "pk_team_draft_analysis",
                table: "team_draft_analysis");

            migrationBuilder.DropPrimaryKey(
                name: "pk_suppicks",
                table: "suppicks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_staticpicks",
                table: "staticpicks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_states",
                table: "states");

            migrationBuilder.DropPrimaryKey(
                name: "pk_sports",
                table: "sports");

            migrationBuilder.DropPrimaryKey(
                name: "pk_settings",
                table: "settings");

            migrationBuilder.DropPrimaryKey(
                name: "pk_schools",
                table: "schools");

            migrationBuilder.DropPrimaryKey(
                name: "pk_rules",
                table: "rules");

            migrationBuilder.DropPrimaryKey(
                name: "pk_rounds",
                table: "rounds");

            migrationBuilder.DropPrimaryKey(
                name: "pk_reset_password",
                table: "reset_password");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ranks_temp",
                table: "ranks_temp");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ranks",
                table: "ranks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_positions_sub",
                table: "positions_sub");

            migrationBuilder.DropPrimaryKey(
                name: "pk_positions",
                table: "positions");

            migrationBuilder.DropPrimaryKey(
                name: "pk_players",
                table: "players");

            migrationBuilder.DropPrimaryKey(
                name: "pk_player_content_types",
                table: "player_content_types");

            migrationBuilder.DropPrimaryKey(
                name: "pk_player_content",
                table: "player_content");

            migrationBuilder.DropPrimaryKey(
                name: "pk_picks_temp",
                table: "picks_temp");

            migrationBuilder.DropPrimaryKey(
                name: "pk_picks",
                table: "picks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_permissions",
                table: "permissions");

            migrationBuilder.DropPrimaryKey(
                name: "primary",
                table: "mock_trades");

            migrationBuilder.DropPrimaryKey(
                name: "primary",
                table: "mock_rounds");

            migrationBuilder.DropPrimaryKey(
                name: "primary",
                table: "mock_picks_deleted");

            migrationBuilder.DropPrimaryKey(
                name: "primary",
                table: "mock_picks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_mock_drafts_deleted",
                table: "mock_drafts_deleted");

            migrationBuilder.DropPrimaryKey(
                name: "pk_mock_drafts",
                table: "mock_drafts");

            migrationBuilder.DropPrimaryKey(
                name: "primary",
                table: "login_cookie_data");

            migrationBuilder.DropPrimaryKey(
                name: "pk_leagues",
                table: "leagues");

            migrationBuilder.DropPrimaryKey(
                name: "pk_globals",
                table: "globals");

            migrationBuilder.DropPrimaryKey(
                name: "pk_games",
                table: "games");

            migrationBuilder.DropPrimaryKey(
                name: "pk_fantasy_rankings",
                table: "fantasy_rankings");

            migrationBuilder.DropPrimaryKey(
                name: "pk_fantasy",
                table: "fantasy");

            migrationBuilder.DropPrimaryKey(
                name: "pk_draftteams",
                table: "draftteams");

            migrationBuilder.DropPrimaryKey(
                name: "pk_drafts_unpublished",
                table: "drafts_unpublished");

            migrationBuilder.DropPrimaryKey(
                name: "pk_drafts",
                table: "drafts");

            migrationBuilder.DropPrimaryKey(
                name: "primary",
                table: "draft_versions");

            migrationBuilder.DropPrimaryKey(
                name: "primary",
                table: "draft_players");

            migrationBuilder.DropPrimaryKey(
                name: "primary",
                table: "draft_picks");

            migrationBuilder.DropPrimaryKey(
                name: "pk_draft_contributors",
                table: "draft_contributors");

            migrationBuilder.DropPrimaryKey(
                name: "pk_countries",
                table: "countries");

            migrationBuilder.DropPrimaryKey(
                name: "pk_conferences",
                table: "conferences");

            migrationBuilder.DropPrimaryKey(
                name: "pk_blogposts_bak",
                table: "blogposts_bak");

            migrationBuilder.DropPrimaryKey(
                name: "pk_blogposts",
                table: "blogposts");

            migrationBuilder.DropPrimaryKey(
                name: "pk_authors",
                table: "authors");

            migrationBuilder.DropPrimaryKey(
                name: "pk_ads",
                table: "ads");

            migrationBuilder.DropPrimaryKey(
                name: "pk_admin_auth_tokens",
                table: "admin_auth_tokens");

            migrationBuilder.DropPrimaryKey(
                name: "pk_admin",
                table: "admin");

            migrationBuilder.DropPrimaryKey(
                name: "pk_multi_player_drafts",
                table: "multi_player_drafts");

            migrationBuilder.DropPrimaryKey(
                name: "pk_draft_users",
                table: "draft_users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_draft_times",
                table: "draft_times");

            migrationBuilder.DropPrimaryKey(
                name: "pk_draft_team_users",
                table: "draft_team_users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_draft_team_user_players",
                table: "draft_team_user_players");

            migrationBuilder.DropPrimaryKey(
                name: "pk_draft_statuses",
                table: "draft_statuses");

            migrationBuilder.DropPrimaryKey(
                name: "pk_draft_start_types",
                table: "draft_start_types");

            migrationBuilder.RenameTable(
                name: "multi_player_drafts",
                newName: "MultiPlayerDrafts");

            migrationBuilder.RenameTable(
                name: "draft_users",
                newName: "DraftUsers");

            migrationBuilder.RenameTable(
                name: "draft_times",
                newName: "DraftTimes");

            migrationBuilder.RenameTable(
                name: "draft_team_users",
                newName: "DraftTeamUsers");

            migrationBuilder.RenameTable(
                name: "draft_team_user_players",
                newName: "DraftTeamUserPlayers");

            migrationBuilder.RenameTable(
                name: "draft_statuses",
                newName: "DraftStatuses");

            migrationBuilder.RenameTable(
                name: "draft_start_types",
                newName: "DraftStartTypes");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "MultiPlayerDrafts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "MultiPlayerDrafts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "start_time",
                table: "MultiPlayerDrafts",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "round_count",
                table: "MultiPlayerDrafts",
                newName: "RoundCount");

            migrationBuilder.RenameColumn(
                name: "pick_time_id",
                table: "MultiPlayerDrafts",
                newName: "PickTimeId");

            migrationBuilder.RenameColumn(
                name: "owner_id",
                table: "MultiPlayerDrafts",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "is_public",
                table: "MultiPlayerDrafts",
                newName: "IsPublic");

            migrationBuilder.RenameColumn(
                name: "is_multi_select",
                table: "MultiPlayerDrafts",
                newName: "IsMultiSelect");

            migrationBuilder.RenameColumn(
                name: "is_computer_teams",
                table: "MultiPlayerDrafts",
                newName: "IsComputerTeams");

            migrationBuilder.RenameColumn(
                name: "draft_status_id",
                table: "MultiPlayerDrafts",
                newName: "DraftStatusId");

            migrationBuilder.RenameColumn(
                name: "draft_start_type_id",
                table: "MultiPlayerDrafts",
                newName: "DraftStartTypeId");

            migrationBuilder.RenameIndex(
                name: "ix_multi_player_drafts_pick_time_id",
                table: "MultiPlayerDrafts",
                newName: "IX_MultiPlayerDrafts_PickTimeId");

            migrationBuilder.RenameIndex(
                name: "ix_multi_player_drafts_owner_id",
                table: "MultiPlayerDrafts",
                newName: "IX_MultiPlayerDrafts_OwnerId");

            migrationBuilder.RenameIndex(
                name: "ix_multi_player_drafts_draft_status_id",
                table: "MultiPlayerDrafts",
                newName: "IX_MultiPlayerDrafts_DraftStatusId");

            migrationBuilder.RenameIndex(
                name: "ix_multi_player_drafts_draft_start_type_id",
                table: "MultiPlayerDrafts",
                newName: "IX_MultiPlayerDrafts_DraftStartTypeId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "DraftUsers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "draft_id",
                table: "DraftUsers",
                newName: "DraftId");

            migrationBuilder.RenameIndex(
                name: "ix_draft_users_user_id",
                table: "DraftUsers",
                newName: "IX_DraftUsers_UserId");

            migrationBuilder.RenameColumn(
                name: "value",
                table: "DraftTimes",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "DraftTimes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DraftTimes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "time_in_seconds",
                table: "DraftTimes",
                newName: "TimeInSeconds");

            migrationBuilder.RenameColumn(
                name: "multiplayer_draft_id",
                table: "DraftTeamUsers",
                newName: "MultiplayerDraftId");

            migrationBuilder.RenameColumn(
                name: "is_computer",
                table: "DraftTeamUsers",
                newName: "IsComputer");

            migrationBuilder.RenameColumn(
                name: "team_id",
                table: "DraftTeamUsers",
                newName: "TeamId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "DraftTeamUsers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "draft_id",
                table: "DraftTeamUsers",
                newName: "DraftId");

            migrationBuilder.RenameIndex(
                name: "ix_draft_team_users_team_id",
                table: "DraftTeamUsers",
                newName: "IX_DraftTeamUsers_TeamId");

            migrationBuilder.RenameIndex(
                name: "ix_draft_team_users_multiplayer_draft_id",
                table: "DraftTeamUsers",
                newName: "IX_DraftTeamUsers_MultiplayerDraftId");

            migrationBuilder.RenameColumn(
                name: "player_id",
                table: "DraftTeamUserPlayers",
                newName: "PlayerId");

            migrationBuilder.RenameColumn(
                name: "team_id",
                table: "DraftTeamUserPlayers",
                newName: "TeamId");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "DraftTeamUserPlayers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "draft_id",
                table: "DraftTeamUserPlayers",
                newName: "DraftId");

            migrationBuilder.RenameIndex(
                name: "ix_draft_team_user_players_draft_id_team_id_user_id",
                table: "DraftTeamUserPlayers",
                newName: "IX_DraftTeamUserPlayers_DraftId_TeamId_UserId");

            migrationBuilder.RenameIndex(
                name: "ix_draft_team_user_players_player_id",
                table: "DraftTeamUserPlayers",
                newName: "IX_DraftTeamUserPlayers_PlayerId");

            migrationBuilder.RenameColumn(
                name: "value",
                table: "DraftStatuses",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "DraftStatuses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DraftStatuses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "value",
                table: "DraftStartTypes",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "DraftStartTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DraftStartTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "is_enabled",
                table: "DraftStartTypes",
                newName: "IsEnabled");

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "users",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "userranks_copy",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "userranks",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_team_picks",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_team_draft_analysis_picks",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_team_draft_analysis",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_redrafts",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_players",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_mock_drafts_contest",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_mock_drafts",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_gamification_points",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "user_auth_tokens",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "tradetransactions",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "trades",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "teams_previous_names",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "teams",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "team_draft_analysis",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "suppicks",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "states",
                type: "int(11) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(11) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "sports",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "settings",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "schools",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "rules",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "rounds",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "reset_password",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "positions",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "picks",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "permissions",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "leagues",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "fantasy_rankings",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "fantasy",
                type: "int(11) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(11) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "draftteams",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "drafts_unpublished",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "drafts",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "draft_contributors",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "countries",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "conferences",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "blogposts_bak",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "blogposts",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "ads",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "admin_auth_tokens",
                type: "int(10) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int(10) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "admin",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userranks_copy",
                table: "userranks_copy",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userranks",
                table: "userranks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_team_picks",
                table: "user_team_picks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_team_draft_analysis_picks",
                table: "user_team_draft_analysis_picks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_team_draft_analysis",
                table: "user_team_draft_analysis",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_redrafts",
                table: "user_redrafts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_players",
                table: "user_players",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_player_rankings",
                table: "user_player_rankings",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_mock_drafts_contest",
                table: "user_mock_drafts_contest",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_mock_drafts",
                table: "user_mock_drafts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_gamification_points",
                table: "user_gamification_points",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_gamification_calculation",
                table: "user_gamification_calculation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "user_draft_votes",
                columns: new[] { "voting_user_id", "owner_user_id", "draft_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_auth_tokens",
                table: "user_auth_tokens",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tradetransactions",
                table: "tradetransactions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_trades",
                table: "trades",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tradecheck",
                table: "tradecheck",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teams_previous_names",
                table: "teams_previous_names",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teams",
                table: "teams",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_team_draft_analysis",
                table: "team_draft_analysis",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_suppicks",
                table: "suppicks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_staticpicks",
                table: "staticpicks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_states",
                table: "states",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sports",
                table: "sports",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_settings",
                table: "settings",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_schools",
                table: "schools",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rules",
                table: "rules",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rounds",
                table: "rounds",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_reset_password",
                table: "reset_password",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ranks_temp",
                table: "ranks_temp",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ranks",
                table: "ranks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_positions_sub",
                table: "positions_sub",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_positions",
                table: "positions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_players",
                table: "players",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_player_content_types",
                table: "player_content_types",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_player_content",
                table: "player_content",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_picks_temp",
                table: "picks_temp",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_picks",
                table: "picks",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_permissions",
                table: "permissions",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "mock_trades",
                columns: new[] { "mock_draft_id", "pick_order" });

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "mock_rounds",
                columns: new[] { "mock_draft_id", "order" });

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "mock_picks_deleted",
                columns: new[] { "mock_draft_id", "order" });

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "mock_picks",
                columns: new[] { "mock_draft_id", "order" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_mock_drafts_deleted",
                table: "mock_drafts_deleted",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mock_drafts",
                table: "mock_drafts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "login_cookie_data",
                columns: new[] { "user_id", "series", "token" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_leagues",
                table: "leagues",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_globals",
                table: "globals",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_games",
                table: "games",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fantasy_rankings",
                table: "fantasy_rankings",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fantasy",
                table: "fantasy",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_draftteams",
                table: "draftteams",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_drafts_unpublished",
                table: "drafts_unpublished",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_drafts",
                table: "drafts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "draft_versions",
                columns: new[] { "draft_id", "rank_type" });

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "draft_players",
                columns: new[] { "draft_id", "rank_type", "rank" });

            migrationBuilder.AddPrimaryKey(
                name: "PRIMARY",
                table: "draft_picks",
                columns: new[] { "draft_id", "order" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_draft_contributors",
                table: "draft_contributors",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_countries",
                table: "countries",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_conferences",
                table: "conferences",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_blogposts_bak",
                table: "blogposts_bak",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_blogposts",
                table: "blogposts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_authors",
                table: "authors",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ads",
                table: "ads",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admin_auth_tokens",
                table: "admin_auth_tokens",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_admin",
                table: "admin",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MultiPlayerDrafts",
                table: "MultiPlayerDrafts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DraftUsers",
                table: "DraftUsers",
                columns: new[] { "DraftId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DraftTimes",
                table: "DraftTimes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DraftTeamUsers",
                table: "DraftTeamUsers",
                columns: new[] { "DraftId", "UserId", "TeamId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DraftTeamUserPlayers",
                table: "DraftTeamUserPlayers",
                columns: new[] { "DraftId", "UserId", "TeamId", "PlayerId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DraftStatuses",
                table: "DraftStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DraftStartTypes",
                table: "DraftStartTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DraftTeamUserPlayers_players_PlayerId",
                table: "DraftTeamUserPlayers",
                column: "PlayerId",
                principalTable: "players",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DraftTeamUserPlayers_DraftTeamUsers_DraftId_TeamId_UserId",
                table: "DraftTeamUserPlayers",
                columns: new[] { "DraftId", "TeamId", "UserId" },
                principalTable: "DraftTeamUsers",
                principalColumns: new[] { "DraftId", "UserId", "TeamId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DraftTeamUsers_MultiPlayerDrafts_MultiplayerDraftId",
                table: "DraftTeamUsers",
                column: "MultiplayerDraftId",
                principalTable: "MultiPlayerDrafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DraftTeamUsers_teams_TeamId",
                table: "DraftTeamUsers",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DraftTeamUsers_DraftUsers_DraftId_UserId",
                table: "DraftTeamUsers",
                columns: new[] { "DraftId", "UserId" },
                principalTable: "DraftUsers",
                principalColumns: new[] { "DraftId", "UserId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DraftUsers_MultiPlayerDrafts_DraftId",
                table: "DraftUsers",
                column: "DraftId",
                principalTable: "MultiPlayerDrafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DraftUsers_users_UserId",
                table: "DraftUsers",
                column: "UserId",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MultiPlayerDrafts_DraftStartTypes_DraftStartTypeId",
                table: "MultiPlayerDrafts",
                column: "DraftStartTypeId",
                principalTable: "DraftStartTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MultiPlayerDrafts_DraftStatuses_DraftStatusId",
                table: "MultiPlayerDrafts",
                column: "DraftStatusId",
                principalTable: "DraftStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MultiPlayerDrafts_users_OwnerId",
                table: "MultiPlayerDrafts",
                column: "OwnerId",
                principalTable: "users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MultiPlayerDrafts_DraftTimes_PickTimeId",
                table: "MultiPlayerDrafts",
                column: "PickTimeId",
                principalTable: "DraftTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
