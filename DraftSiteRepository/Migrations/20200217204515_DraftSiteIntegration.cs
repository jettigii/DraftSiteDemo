using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DraftSiteRepository.Migrations
{
    public partial class DraftSiteIntegration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_draft_team_user_players_players_player_id",
                table: "draft_team_user_players");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_team_user_players_draft_team_users_draft_id_team_id_us~",
                table: "draft_team_user_players");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_team_users_drafts_draft_id",
                table: "draft_team_users");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_team_users_teams_team_id",
                table: "draft_team_users");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_team_users_draft_users_draft_id_user_id",
                table: "draft_team_users");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_users_drafts_draft_id",
                table: "draft_users");

            migrationBuilder.DropForeignKey(
                name: "fk_draft_users_draft_site_users_user_id",
                table: "draft_users");

            migrationBuilder.DropForeignKey(
                name: "fk_drafts_draft_start_types_draft_start_type_id",
                table: "drafts");

            migrationBuilder.DropForeignKey(
                name: "fk_drafts_draft_statuses_draft_status_id",
                table: "drafts");

            migrationBuilder.DropForeignKey(
                name: "fk_drafts_draft_site_users_owner_id",
                table: "drafts");

            migrationBuilder.DropForeignKey(
                name: "fk_drafts_draft_times_pick_time_id",
                table: "drafts");

            migrationBuilder.DropTable(
                name: "draft_site_users");

            migrationBuilder.DropPrimaryKey(
                name: "pk_teams",
                table: "teams");

            migrationBuilder.DropPrimaryKey(
                name: "pk_players",
                table: "players");

            migrationBuilder.DropPrimaryKey(
                name: "pk_drafts",
                table: "drafts");

            migrationBuilder.DropIndex(
                name: "ix_drafts_draft_start_type_id",
                table: "drafts");

            migrationBuilder.DropIndex(
                name: "ix_drafts_draft_status_id",
                table: "drafts");

            migrationBuilder.DropIndex(
                name: "ix_drafts_owner_id",
                table: "drafts");

            migrationBuilder.DropIndex(
                name: "ix_drafts_pick_time_id",
                table: "drafts");

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

            migrationBuilder.DropColumn(
                name: "college",
                table: "players");

            migrationBuilder.DropColumn(
                name: "name",
                table: "players");

            migrationBuilder.DropColumn(
                name: "draft_start_type_id",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "draft_status_id",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "is_computer_teams",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "is_multi_select",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "is_public",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "name",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "owner_id",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "pick_time_id",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "round_count",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "start_time",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "password",
                table: "drafts");

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

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "teams",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "teams",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<byte>(
                name: "active",
                table: "teams",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValueSql: "'1'");

            migrationBuilder.AddColumn<uint>(
                name: "country",
                table: "teams",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "created_by",
                table: "teams",
                type: "int(10) unsigned",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "display",
                table: "teams",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "home",
                table: "teams",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AddColumn<uint>(
                name: "last_modified_by",
                table: "teams",
                type: "int(10) unsigned",
                nullable: true);

            migrationBuilder.AddColumn<uint>(
                name: "league",
                table: "teams",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<byte>(
                name: "sport",
                table: "teams",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "state",
                table: "teams",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<uint>(
                name: "successor",
                table: "teams",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<byte>(
                name: "type",
                table: "teams",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "age",
                table: "players",
                type: "char(2)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AddColumn<byte>(
                name: "bats",
                table: "players",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte[]>(
                name: "commentary",
                table: "players",
                type: "blob",
                nullable: false);

            migrationBuilder.AddColumn<uint>(
                name: "country",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "players",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<uint>(
                name: "created_by",
                table: "players",
                type: "int(10) unsigned",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "dob",
                table: "players",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "draftclass",
                table: "players",
                type: "char(4)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AddColumn<sbyte>(
                name: "fantasy",
                table: "players",
                type: "tinyint(3)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fantasy_positions",
                table: "players",
                type: "text",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "fantasy_team",
                table: "players",
                type: "int(11)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstname",
                table: "players",
                type: "varchar(40)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "gradclass",
                table: "players",
                type: "char(4)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AddColumn<byte>(
                name: "heightf",
                table: "players",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<double>(
                name: "heighti",
                table: "players",
                type: "double unsigned",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<uint>(
                name: "highschool",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "last_modified_by",
                table: "players",
                type: "int(10) unsigned",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "lastactivity",
                table: "players",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastname",
                table: "players",
                type: "varchar(40)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AddColumn<DateTime>(
                name: "lastupdate",
                table: "players",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte[]>(
                name: "notes",
                table: "players",
                type: "blob",
                nullable: false);

            migrationBuilder.AddColumn<uint>(
                name: "player_comparison",
                table: "players",
                type: "int(10) unsigned",
                nullable: true);

            migrationBuilder.AddColumn<uint>(
                name: "position",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "prehighschool",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "preposition",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "preschool",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "preteam",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "redshirt",
                table: "players",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<uint>(
                name: "school",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "shoots",
                table: "players",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<uint>(
                name: "sport",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<byte[]>(
                name: "stats",
                table: "players",
                type: "blob",
                nullable: false);

            migrationBuilder.AddColumn<byte>(
                name: "status",
                table: "players",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<uint>(
                name: "team",
                table: "players",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<byte>(
                name: "throws",
                table: "players",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "twitter_handler",
                table: "players",
                type: "varchar(250)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AddColumn<ushort>(
                name: "weight",
                table: "players",
                type: "smallint(5) unsigned",
                nullable: false,
                defaultValue: (ushort)0);

            migrationBuilder.AlterColumn<uint>(
                name: "id",
                table: "drafts",
                type: "mediumint(8) unsigned",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<ushort>(
                name: "compensatory",
                table: "drafts",
                type: "smallint(5) unsigned",
                nullable: false,
                defaultValue: (ushort)0);

            migrationBuilder.AddColumn<uint>(
                name: "created_by",
                table: "drafts",
                type: "int(10) unsigned",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "displayfreeagents",
                table: "drafts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "end",
                table: "drafts",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<uint>(
                name: "last_modified_by",
                table: "drafts",
                type: "int(10) unsigned",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "lastupdate",
                table: "drafts",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "'current_timestamp()'");

            migrationBuilder.AddColumn<sbyte>(
                name: "livemockstartinground",
                table: "drafts",
                type: "tinyint(3)",
                nullable: false,
                defaultValue: (sbyte)0);

            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "drafts",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AddColumn<bool>(
                name: "manage_draft",
                table: "drafts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte>(
                name: "monthonly",
                table: "drafts",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "open_by",
                table: "drafts",
                type: "tinyint(3) unsigned",
                nullable: true);

            migrationBuilder.AddColumn<uint>(
                name: "playerdisplay",
                table: "drafts",
                type: "int(10) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<ushort>(
                name: "rounddisplay",
                table: "drafts",
                type: "smallint(5) unsigned",
                nullable: false,
                defaultValue: (ushort)0);

            migrationBuilder.AddColumn<uint>(
                name: "sport",
                table: "drafts",
                type: "mediumint(8) unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<DateTime>(
                name: "start",
                table: "drafts",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "'0000-00-00 00:00:00'");

            migrationBuilder.AddColumn<byte>(
                name: "status",
                table: "drafts",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "team_order_change",
                table: "drafts",
                type: "tinyint(1) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "time",
                table: "drafts",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "'0000-00-00 00:00:00'");

            migrationBuilder.AddColumn<byte>(
                name: "tradesuppress",
                table: "drafts",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "type",
                table: "drafts",
                type: "tinyint(3) unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<ushort>(
                name: "usermockplayerlimit",
                table: "drafts",
                type: "smallint(5) unsigned",
                nullable: false,
                defaultValue: (ushort)0);

            migrationBuilder.AddColumn<string>(
                name: "year",
                table: "drafts",
                type: "char(4)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8")
                .Annotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AlterColumn<uint>(
                name: "UserId",
                table: "DraftUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "TeamId",
                table: "DraftTeamUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "UserId",
                table: "DraftTeamUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MultiplayerDraftId",
                table: "DraftTeamUsers",
                nullable: true);

            migrationBuilder.AlterColumn<uint>(
                name: "PlayerId",
                table: "DraftTeamUserPlayers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "TeamId",
                table: "DraftTeamUserPlayers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "UserId",
                table: "DraftTeamUserPlayers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_teams",
                table: "teams",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_players",
                table: "players",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_drafts",
                table: "drafts",
                column: "id");

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

            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    username = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    password = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    lastname = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    firstname = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    email = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    lastlogin = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'"),
                    active = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    twitter_handler = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    facebook_username = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "admin_auth_tokens",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    selector = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    hashed_validator = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    admin_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    expires = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin_auth_tokens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ads",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    text = table.Column<byte[]>(type: "blob", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ads", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(250)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    admin_id = table.Column<int>(type: "mediumint(8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "blogposts",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    writer = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    author = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    title = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    text = table.Column<byte[]>(type: "mediumblob", nullable: false),
                    time = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'"),
                    status = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    sport = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    created_by = table.Column<uint>(type: "int(10) unsigned", nullable: true),
                    last_modified_by = table.Column<uint>(type: "int(10) unsigned", nullable: true),
                    featured_image = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    author_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogposts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "blogposts_bak",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    writer = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    author = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    title = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    text = table.Column<string>(type: "mediumtext", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    time = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'"),
                    status = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    sport = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogposts_bak", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "conferences",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(60)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    nickname = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    division = table.Column<string>(type: "varchar(6)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conferences", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    nickname = table.Column<string>(type: "varchar(15)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "draft_contributors",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    draft_id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    admin_id = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_draft_contributors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "draft_picks",
                columns: table => new
                {
                    draft_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    order = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    round_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    rank = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    team_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    type_desc = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.draft_id, x.order });
                });

            migrationBuilder.CreateTable(
                name: "draft_players",
                columns: table => new
                {
                    draft_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    rank_type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    rank = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    player_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    comments = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.draft_id, x.rank_type, x.rank });
                });

            migrationBuilder.CreateTable(
                name: "draft_versions",
                columns: table => new
                {
                    draft_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    rank_type = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    published_rounds = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    saved_rounds = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    status = table.Column<bool>(nullable: false),
                    last_published = table.Column<DateTime>(type: "datetime", nullable: false),
                    last_saved = table.Column<DateTime>(type: "datetime", nullable: false),
                    created_by = table.Column<uint>(type: "int(10) unsigned", nullable: true),
                    last_modified_by = table.Column<uint>(type: "int(10) unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.draft_id, x.rank_type });
                });

            migrationBuilder.CreateTable(
                name: "drafts_unpublished",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    draft_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    sport_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    user_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    steps = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    post_vars = table.Column<byte[]>(type: "blob", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drafts_unpublished", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "draftteams",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    draft = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    team = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    rank = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    commentary = table.Column<byte[]>(type: "blob", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_draftteams", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fantasy",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    sport_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    year = table.Column<string>(type: "char(4)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    name = table.Column<string>(type: "varchar(250)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    slug = table.Column<string>(type: "varchar(250)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    playerdisplay = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    status = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    date_published = table.Column<DateTime>(type: "datetime", nullable: false),
                    created_by = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    last_modified_by = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fantasy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fantasy_rankings",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    fantasy_id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    player_id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    rank = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    team_id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    positions = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fantasy_rankings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "games",
                columns: table => new
                {
                    id = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_games", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "globals",
                columns: table => new
                {
                    id = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    message = table.Column<byte[]>(type: "blob", nullable: false),
                    sponsortakeover = table.Column<sbyte>(type: "tinyint(4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_globals", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "leagues",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    nickname = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    country = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leagues", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "login_cookie_data",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int(10)", nullable: false),
                    series = table.Column<int>(type: "int(6)", nullable: false),
                    token = table.Column<int>(type: "int(6)", nullable: false),
                    expires = table.Column<DateTime>(type: "datetime", nullable: false),
                    last_verified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.user_id, x.series, x.token });
                });

            migrationBuilder.CreateTable(
                name: "mock_drafts",
                columns: table => new
                {
                    id = table.Column<int>(type: "mediumint(8)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    draft_id = table.Column<int>(type: "mediumint(9)", nullable: false),
                    version = table.Column<short>(type: "smallint(6)", nullable: false),
                    status = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    current = table.Column<bool>(nullable: false, comment: "1=Current Mock. 0=Prior Mock"),
                    date_published = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mock_drafts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mock_drafts_deleted",
                columns: table => new
                {
                    id = table.Column<int>(type: "mediumint(8)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    draft_id = table.Column<int>(type: "mediumint(9)", nullable: false),
                    version = table.Column<short>(type: "smallint(6)", nullable: false, defaultValueSql: "'1'"),
                    status = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    current = table.Column<bool>(nullable: false),
                    date_published = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mock_drafts_deleted", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mock_picks",
                columns: table => new
                {
                    mock_draft_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    order = table.Column<short>(type: "smallint(5)", nullable: false),
                    round_order = table.Column<sbyte>(type: "tinyint(3)", nullable: false),
                    rank = table.Column<short>(type: "smallint(5)", nullable: false),
                    team_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    type = table.Column<bool>(nullable: false),
                    type_desc = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    player_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    comments = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.mock_draft_id, x.order });
                });

            migrationBuilder.CreateTable(
                name: "mock_picks_deleted",
                columns: table => new
                {
                    mock_draft_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    order = table.Column<short>(type: "smallint(5)", nullable: false),
                    round_order = table.Column<sbyte>(type: "tinyint(3)", nullable: false),
                    rank = table.Column<short>(type: "smallint(5)", nullable: false),
                    team_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    type = table.Column<bool>(nullable: false),
                    type_desc = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    player_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    comments = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.mock_draft_id, x.order });
                });

            migrationBuilder.CreateTable(
                name: "mock_rounds",
                columns: table => new
                {
                    mock_draft_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    order = table.Column<sbyte>(type: "tinyint(3)", nullable: false),
                    name = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.mock_draft_id, x.order });
                });

            migrationBuilder.CreateTable(
                name: "mock_rounds_deleted",
                columns: table => new
                {
                    mock_draft_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    order = table.Column<sbyte>(type: "tinyint(3)", nullable: false),
                    name = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "mock_trades",
                columns: table => new
                {
                    mock_draft_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    pick_order = table.Column<short>(type: "smallint(5)", nullable: false),
                    trade_trans_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    team_ids = table.Column<string>(type: "tinytext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.mock_draft_id, x.pick_order });
                });

            migrationBuilder.CreateTable(
                name: "mock_trades_deleted",
                columns: table => new
                {
                    mock_draft_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    pick_order = table.Column<short>(type: "smallint(5)", nullable: false),
                    trade_trans_id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    team_ids = table.Column<string>(type: "tinytext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    admin = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    players = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    players_media = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    sports = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    teams = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    positions = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    schools = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    ranks = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    drafts_create = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    drafts_edit = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    drafts_stage_4_edit = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    redrafts = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    posts = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    admin_edit = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    user_edit = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    delete = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    rule = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    ads = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    whats_new = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    agreement = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    drafts_import = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    sport_access = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "picks",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    round = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    pick = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    team = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    typename = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    comments = table.Column<byte[]>(type: "blob", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_picks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "picks_temp",
                columns: table => new
                {
                    id = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    round = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    pick = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    team = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    typename = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    comments = table.Column<byte[]>(type: "blob", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_picks_temp", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "player_content",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    player_id = table.Column<int>(type: "int(11)", nullable: false),
                    type_id = table.Column<sbyte>(type: "tinyint(2)", nullable: false),
                    data = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_unicode_ci"),
                    approved = table.Column<bool>(nullable: false),
                    user_id = table.Column<int>(type: "int(10)", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_player_content", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "player_content_types",
                columns: table => new
                {
                    id = table.Column<sbyte>(type: "tinyint(2)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_unicode_ci"),
                    player_limit = table.Column<sbyte>(type: "tinyint(2)", nullable: false),
                    user_limit = table.Column<sbyte>(type: "tinyint(2)", nullable: false),
                    column = table.Column<string>(type: "enum('1','2')", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_unicode_ci"),
                    show_name = table.Column<bool>(nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_player_content_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(5)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    fullname = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    game = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    sort = table.Column<sbyte>(type: "tinyint(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "positions_sub",
                columns: table => new
                {
                    id = table.Column<sbyte>(type: "tinyint(4)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(10)", nullable: false, comment: "abbreviated name")
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    fullname = table.Column<string>(name: "full name", type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    mainpositions = table.Column<sbyte>(name: "main positions", type: "tinyint(4)", nullable: false, comment: "main pos reference num")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions_sub", x => x.id);
                },
                comment: "Sub positions drawing from main position table");

            migrationBuilder.CreateTable(
                name: "ranks",
                columns: table => new
                {
                    id = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    player = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    draft = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    rank = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ranks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ranks_temp",
                columns: table => new
                {
                    id = table.Column<ulong>(type: "bigint(8) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    player = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    draft = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    rank = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ranks_temp", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reset_password",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    user = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    key = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    used = table.Column<bool>(nullable: false),
                    timestamp = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reset_password", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rounds",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    draft = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    round = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rounds", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rules",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    sport = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    text = table.Column<byte[]>(type: "mediumblob", nullable: true),
                    time = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "schools",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(90)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    teamname = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    display = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    city = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    state = table.Column<int>(type: "mediumint(9)", nullable: false),
                    country = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    conference = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    @private = table.Column<byte>(name: "private", type: "tinyint(3) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    created_by = table.Column<uint>(type: "int(10) unsigned", nullable: true),
                    last_modified_by = table.Column<uint>(type: "int(10) unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schools", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "settings",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    value = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_settings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sports",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    nickname = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    game = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    message = table.Column<byte[]>(type: "blob", nullable: false),
                    sort = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    active = table.Column<bool>(nullable: false, defaultValueSql: "'1'"),
                    sponsortakeover = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    visible = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sports", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "states",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    name = table.Column<string>(type: "char(40)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    abbrev = table.Column<string>(type: "char(2)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    country = table.Column<int>(type: "mediumint(9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_states", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "staticpicks",
                columns: table => new
                {
                    id = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    draft = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    position = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    pick = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    round = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    team = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    typename = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    tradetext = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    tradelink = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    player = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    comments = table.Column<byte[]>(type: "blob", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staticpicks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "suppicks",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    draft = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    round = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    pick = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    team = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppicks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "team_draft_analysis",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    team = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    draft = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    positions = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    preview = table.Column<byte[]>(type: "blob", nullable: false),
                    analysis = table.Column<byte[]>(type: "blob", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team_draft_analysis", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "teams_previous_names",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    team = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    home = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    name = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    display = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    start_year = table.Column<string>(type: "char(4)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    end_year = table.Column<string>(type: "char(4)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    created_by = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    last_modified_by = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams_previous_names", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tradecheck",
                columns: table => new
                {
                    id = table.Column<ulong>(type: "bigint(10) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    trans = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    check = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tradecheck", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "trades",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    description = table.Column<byte[]>(type: "blob", nullable: false),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    sport = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tradetransactions",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    trade = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    round = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    futuredraft = table.Column<string>(type: "char(4)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    player = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    players_to = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    fromoriginal = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    from = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    to = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    check = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    picktype = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    specialpickinstance = table.Column<byte>(type: "tinyint(2) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tradetransactions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_auth_tokens",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    selector = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    hashed_validator = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    user_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    expires = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_auth_tokens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_draft_votes",
                columns: table => new
                {
                    voting_user_id = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    owner_user_id = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    draft_id = table.Column<string>(type: "varchar(8)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    rating = table.Column<bool>(nullable: false),
                    lastupdate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.voting_user_id, x.owner_user_id, x.draft_id });
                });

            migrationBuilder.CreateTable(
                name: "user_gamification_calculation",
                columns: table => new
                {
                    id = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    create_mocks = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    correct_mocks = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    player_additions = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    player_comparison = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    scouting_reports = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    videos = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    team_needs = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    team_preview = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    mocks_voted = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    mock_votes = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    total = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_gamification_calculation", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_gamification_points",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    point = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_gamification_points", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_mock_drafts",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    draft_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    shared_status = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false),
                    user_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    user_round_limit = table.Column<bool>(nullable: false),
                    comment_status = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_mock_drafts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_mock_drafts_contest",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    draft_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    rank = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    user_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    points = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_mock_drafts_contest", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_player_rankings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rank = table.Column<int>(type: "int(11)", nullable: false),
                    player_id = table.Column<int>(type: "int(11)", nullable: false),
                    user_id = table.Column<int>(type: "int(11)", nullable: false),
                    draft_id = table.Column<int>(type: "int(11)", nullable: false),
                    visibility = table.Column<string>(type: "enum('1','0')", nullable: false, defaultValueSql: "'0'")
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_player_rankings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_players",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    user_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    approved = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    lastname = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    firstname = table.Column<string>(type: "varchar(40)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    heightf = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    heighti = table.Column<double>(type: "double unsigned", nullable: false),
                    weight = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    sport = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    team = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    position = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    school = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    country = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    twitter_handler = table.Column<string>(type: "varchar(250)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    gradclass = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    draftclass = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    player_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_players", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_redrafts",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    draft_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    shared_status = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    last_update = table.Column<DateTime>(type: "datetime", nullable: false),
                    user_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    user_round_limit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_redrafts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_team_draft_analysis",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    user_id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    team_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    draft_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    preview = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    analysis = table.Column<string>(type: "text", nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                        .Annotation("MySql:Collation", "latin1_swedish_ci"),
                    shared_status = table.Column<bool>(nullable: true, defaultValueSql: "'1'"),
                    approved = table.Column<bool>(nullable: true, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_team_draft_analysis", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_team_draft_analysis_picks",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    user_team_draft_analysis_id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    position_id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    order = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_team_draft_analysis_picks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_team_picks",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    draft = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    round = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    round_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    rank = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    team = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    type_desc = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    user = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_team_picks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "userranks",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    player = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    draft = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    rank = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    comments = table.Column<byte[]>(type: "blob", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'"),
                    user = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userranks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "userranks_copy",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    player = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    draft = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    rank = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    comments = table.Column<byte[]>(type: "blob", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'current_timestamp()'"),
                    user = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userranks_copy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    username = table.Column<string>(type: "varchar(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    password = table.Column<string>(type: "varchar(60)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    securityphrase = table.Column<byte[]>(type: "blob", nullable: false),
                    securityanswer = table.Column<string>(type: "varchar(100)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    lastname = table.Column<string>(type: "varchar(70)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    firstname = table.Column<string>(type: "varchar(70)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    email = table.Column<string>(type: "varchar(70)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    gender = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    zip = table.Column<string>(type: "varchar(5)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    country = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    dob = table.Column<string>(type: "varchar(4)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    teamnfl = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    teamnba = table.Column<uint>(type: "mediumint(5) unsigned", nullable: false),
                    teammlb = table.Column<uint>(type: "mediumint(5) unsigned", nullable: false),
                    teamnhl = table.Column<uint>(type: "mediumint(5) unsigned", nullable: false),
                    teammls = table.Column<uint>(type: "mediumint(5) unsigned", nullable: false),
                    teamwnba = table.Column<uint>(type: "mediumint(5) unsigned", nullable: false),
                    sportorder = table.Column<string>(type: "char(15)", nullable: false, defaultValueSql: "'1,5,3,2,4,6,7,8'")
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    maillist = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    joindate = table.Column<DateTime>(type: "date", nullable: false),
                    lastlogin = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "'0000-00-00 00:00:00'"),
                    featured = table.Column<bool>(nullable: false),
                    photo = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    twitter_handle = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci"),
                    facebook_username = table.Column<string>(type: "varchar(250)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8")
                        .Annotation("MySql:Collation", "utf8_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "MultiPlayerDrafts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsComputerTeams = table.Column<bool>(nullable: false),
                    IsPublic = table.Column<bool>(nullable: false),
                    IsMultiSelect = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    PickTimeId = table.Column<int>(nullable: false),
                    RoundCount = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTimeOffset>(nullable: false),
                    password = table.Column<string>(nullable: true),
                    OwnerId = table.Column<uint>(nullable: false),
                    DraftStatusId = table.Column<int>(nullable: false),
                    DraftStartTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiPlayerDrafts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiPlayerDrafts_DraftStartTypes_DraftStartTypeId",
                        column: x => x.DraftStartTypeId,
                        principalTable: "DraftStartTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MultiPlayerDrafts_DraftStatuses_DraftStatusId",
                        column: x => x.DraftStatusId,
                        principalTable: "DraftStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MultiPlayerDrafts_users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MultiPlayerDrafts_DraftTimes_PickTimeId",
                        column: x => x.PickTimeId,
                        principalTable: "DraftTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "successor",
                table: "teams",
                column: "successor");

            migrationBuilder.CreateIndex(
                name: "sport_league_active",
                table: "teams",
                columns: new[] { "sport", "league", "active" });

            migrationBuilder.CreateIndex(
                name: "highschool",
                table: "players",
                column: "highschool");

            migrationBuilder.CreateIndex(
                name: "position",
                table: "players",
                column: "position");

            migrationBuilder.CreateIndex(
                name: "school",
                table: "players",
                column: "school");

            migrationBuilder.CreateIndex(
                name: "team",
                table: "players",
                column: "team");

            migrationBuilder.CreateIndex(
                name: "year",
                table: "drafts",
                column: "year");

            migrationBuilder.CreateIndex(
                name: "sport",
                table: "drafts",
                columns: new[] { "sport", "status" });

            migrationBuilder.CreateIndex(
                name: "IX_DraftTeamUsers_MultiplayerDraftId",
                table: "DraftTeamUsers",
                column: "MultiplayerDraftId");

            migrationBuilder.CreateIndex(
                name: "username",
                table: "admin",
                column: "username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "name",
                table: "conferences",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "draft_ranktype",
                table: "draft_players",
                columns: new[] { "draft_id", "rank_type" });

            migrationBuilder.CreateIndex(
                name: "name",
                table: "games",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "draft_version",
                table: "mock_drafts",
                columns: new[] { "draft_id", "version" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MultiPlayerDrafts_DraftStartTypeId",
                table: "MultiPlayerDrafts",
                column: "DraftStartTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiPlayerDrafts_DraftStatusId",
                table: "MultiPlayerDrafts",
                column: "DraftStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiPlayerDrafts_OwnerId",
                table: "MultiPlayerDrafts",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiPlayerDrafts_PickTimeId",
                table: "MultiPlayerDrafts",
                column: "PickTimeId");

            migrationBuilder.CreateIndex(
                name: "admin",
                table: "permissions",
                column: "admin",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "team",
                table: "picks",
                column: "team");

            migrationBuilder.CreateIndex(
                name: "round_type",
                table: "picks",
                columns: new[] { "round", "type" });

            migrationBuilder.CreateIndex(
                name: "type",
                table: "ranks",
                column: "type");

            migrationBuilder.CreateIndex(
                name: "draft",
                table: "ranks",
                columns: new[] { "draft", "type" });

            migrationBuilder.CreateIndex(
                name: "draft_type_rank",
                table: "ranks",
                columns: new[] { "draft", "type", "rank" });

            migrationBuilder.CreateIndex(
                name: "type",
                table: "ranks_temp",
                column: "type");

            migrationBuilder.CreateIndex(
                name: "draft",
                table: "ranks_temp",
                columns: new[] { "draft", "type" });

            migrationBuilder.CreateIndex(
                name: "draft_type_rank",
                table: "ranks_temp",
                columns: new[] { "draft", "type", "rank" });

            migrationBuilder.CreateIndex(
                name: "draft_round",
                table: "rounds",
                columns: new[] { "draft", "round" });

            migrationBuilder.CreateIndex(
                name: "name",
                table: "sports",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "nickname",
                table: "sports",
                column: "nickname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "abbrev",
                table: "states",
                column: "abbrev",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "name",
                table: "states",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "draft_pick",
                table: "suppicks",
                columns: new[] { "draft", "pick" });

            migrationBuilder.CreateIndex(
                name: "trans",
                table: "tradecheck",
                columns: new[] { "trans", "check" });

            migrationBuilder.CreateIndex(
                name: "from",
                table: "tradetransactions",
                column: "from");

            migrationBuilder.CreateIndex(
                name: "round_fromorig_from",
                table: "tradetransactions",
                columns: new[] { "round", "fromoriginal", "from" });

            migrationBuilder.CreateIndex(
                name: "round_fromorig_from_type",
                table: "tradetransactions",
                columns: new[] { "round", "fromoriginal", "from", "type" });

            migrationBuilder.CreateIndex(
                name: "owner_user_id",
                table: "user_draft_votes",
                columns: new[] { "owner_user_id", "draft_id" });

            migrationBuilder.CreateIndex(
                name: "name",
                table: "user_gamification_points",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "draft_user",
                table: "user_mock_drafts",
                columns: new[] { "draft_id", "user_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "draft_user",
                table: "user_redrafts",
                columns: new[] { "draft_id", "user_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "draft_user",
                table: "userranks",
                columns: new[] { "draft", "user" });

            migrationBuilder.CreateIndex(
                name: "draft_user",
                table: "userranks_copy",
                columns: new[] { "draft", "user" });

            migrationBuilder.CreateIndex(
                name: "username",
                table: "users",
                column: "username",
                unique: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "admin_auth_tokens");

            migrationBuilder.DropTable(
                name: "ads");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "blogposts");

            migrationBuilder.DropTable(
                name: "blogposts_bak");

            migrationBuilder.DropTable(
                name: "conferences");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.DropTable(
                name: "draft_contributors");

            migrationBuilder.DropTable(
                name: "draft_picks");

            migrationBuilder.DropTable(
                name: "draft_players");

            migrationBuilder.DropTable(
                name: "draft_versions");

            migrationBuilder.DropTable(
                name: "drafts_unpublished");

            migrationBuilder.DropTable(
                name: "draftteams");

            migrationBuilder.DropTable(
                name: "fantasy");

            migrationBuilder.DropTable(
                name: "fantasy_rankings");

            migrationBuilder.DropTable(
                name: "games");

            migrationBuilder.DropTable(
                name: "globals");

            migrationBuilder.DropTable(
                name: "leagues");

            migrationBuilder.DropTable(
                name: "login_cookie_data");

            migrationBuilder.DropTable(
                name: "mock_drafts");

            migrationBuilder.DropTable(
                name: "mock_drafts_deleted");

            migrationBuilder.DropTable(
                name: "mock_picks");

            migrationBuilder.DropTable(
                name: "mock_picks_deleted");

            migrationBuilder.DropTable(
                name: "mock_rounds");

            migrationBuilder.DropTable(
                name: "mock_rounds_deleted");

            migrationBuilder.DropTable(
                name: "mock_trades");

            migrationBuilder.DropTable(
                name: "mock_trades_deleted");

            migrationBuilder.DropTable(
                name: "MultiPlayerDrafts");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "picks");

            migrationBuilder.DropTable(
                name: "picks_temp");

            migrationBuilder.DropTable(
                name: "player_content");

            migrationBuilder.DropTable(
                name: "player_content_types");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropTable(
                name: "positions_sub");

            migrationBuilder.DropTable(
                name: "ranks");

            migrationBuilder.DropTable(
                name: "ranks_temp");

            migrationBuilder.DropTable(
                name: "reset_password");

            migrationBuilder.DropTable(
                name: "rounds");

            migrationBuilder.DropTable(
                name: "rules");

            migrationBuilder.DropTable(
                name: "schools");

            migrationBuilder.DropTable(
                name: "settings");

            migrationBuilder.DropTable(
                name: "sports");

            migrationBuilder.DropTable(
                name: "states");

            migrationBuilder.DropTable(
                name: "staticpicks");

            migrationBuilder.DropTable(
                name: "suppicks");

            migrationBuilder.DropTable(
                name: "team_draft_analysis");

            migrationBuilder.DropTable(
                name: "teams_previous_names");

            migrationBuilder.DropTable(
                name: "tradecheck");

            migrationBuilder.DropTable(
                name: "trades");

            migrationBuilder.DropTable(
                name: "tradetransactions");

            migrationBuilder.DropTable(
                name: "user_auth_tokens");

            migrationBuilder.DropTable(
                name: "user_draft_votes");

            migrationBuilder.DropTable(
                name: "user_gamification_calculation");

            migrationBuilder.DropTable(
                name: "user_gamification_points");

            migrationBuilder.DropTable(
                name: "user_mock_drafts");

            migrationBuilder.DropTable(
                name: "user_mock_drafts_contest");

            migrationBuilder.DropTable(
                name: "user_player_rankings");

            migrationBuilder.DropTable(
                name: "user_players");

            migrationBuilder.DropTable(
                name: "user_redrafts");

            migrationBuilder.DropTable(
                name: "user_team_draft_analysis");

            migrationBuilder.DropTable(
                name: "user_team_draft_analysis_picks");

            migrationBuilder.DropTable(
                name: "user_team_picks");

            migrationBuilder.DropTable(
                name: "userranks");

            migrationBuilder.DropTable(
                name: "userranks_copy");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_teams",
                table: "teams");

            migrationBuilder.DropIndex(
                name: "successor",
                table: "teams");

            migrationBuilder.DropIndex(
                name: "sport_league_active",
                table: "teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_players",
                table: "players");

            migrationBuilder.DropIndex(
                name: "highschool",
                table: "players");

            migrationBuilder.DropIndex(
                name: "position",
                table: "players");

            migrationBuilder.DropIndex(
                name: "school",
                table: "players");

            migrationBuilder.DropIndex(
                name: "team",
                table: "players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drafts",
                table: "drafts");

            migrationBuilder.DropIndex(
                name: "year",
                table: "drafts");

            migrationBuilder.DropIndex(
                name: "sport",
                table: "drafts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DraftUsers",
                table: "DraftUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DraftTimes",
                table: "DraftTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DraftTeamUsers",
                table: "DraftTeamUsers");

            migrationBuilder.DropIndex(
                name: "IX_DraftTeamUsers_MultiplayerDraftId",
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

            migrationBuilder.DropColumn(
                name: "active",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "country",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "display",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "home",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "last_modified_by",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "league",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "sport",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "state",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "successor",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "type",
                table: "teams");

            migrationBuilder.DropColumn(
                name: "age",
                table: "players");

            migrationBuilder.DropColumn(
                name: "bats",
                table: "players");

            migrationBuilder.DropColumn(
                name: "commentary",
                table: "players");

            migrationBuilder.DropColumn(
                name: "country",
                table: "players");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "players");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "players");

            migrationBuilder.DropColumn(
                name: "dob",
                table: "players");

            migrationBuilder.DropColumn(
                name: "draftclass",
                table: "players");

            migrationBuilder.DropColumn(
                name: "fantasy",
                table: "players");

            migrationBuilder.DropColumn(
                name: "fantasy_positions",
                table: "players");

            migrationBuilder.DropColumn(
                name: "fantasy_team",
                table: "players");

            migrationBuilder.DropColumn(
                name: "firstname",
                table: "players");

            migrationBuilder.DropColumn(
                name: "gradclass",
                table: "players");

            migrationBuilder.DropColumn(
                name: "heightf",
                table: "players");

            migrationBuilder.DropColumn(
                name: "heighti",
                table: "players");

            migrationBuilder.DropColumn(
                name: "highschool",
                table: "players");

            migrationBuilder.DropColumn(
                name: "last_modified_by",
                table: "players");

            migrationBuilder.DropColumn(
                name: "lastactivity",
                table: "players");

            migrationBuilder.DropColumn(
                name: "lastname",
                table: "players");

            migrationBuilder.DropColumn(
                name: "lastupdate",
                table: "players");

            migrationBuilder.DropColumn(
                name: "notes",
                table: "players");

            migrationBuilder.DropColumn(
                name: "player_comparison",
                table: "players");

            migrationBuilder.DropColumn(
                name: "position",
                table: "players");

            migrationBuilder.DropColumn(
                name: "prehighschool",
                table: "players");

            migrationBuilder.DropColumn(
                name: "preposition",
                table: "players");

            migrationBuilder.DropColumn(
                name: "preschool",
                table: "players");

            migrationBuilder.DropColumn(
                name: "preteam",
                table: "players");

            migrationBuilder.DropColumn(
                name: "redshirt",
                table: "players");

            migrationBuilder.DropColumn(
                name: "school",
                table: "players");

            migrationBuilder.DropColumn(
                name: "shoots",
                table: "players");

            migrationBuilder.DropColumn(
                name: "sport",
                table: "players");

            migrationBuilder.DropColumn(
                name: "stats",
                table: "players");

            migrationBuilder.DropColumn(
                name: "status",
                table: "players");

            migrationBuilder.DropColumn(
                name: "team",
                table: "players");

            migrationBuilder.DropColumn(
                name: "throws",
                table: "players");

            migrationBuilder.DropColumn(
                name: "twitter_handler",
                table: "players");

            migrationBuilder.DropColumn(
                name: "weight",
                table: "players");

            migrationBuilder.DropColumn(
                name: "compensatory",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "displayfreeagents",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "end",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "last_modified_by",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "lastupdate",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "livemockstartinground",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "location",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "manage_draft",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "monthonly",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "open_by",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "playerdisplay",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "rounddisplay",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "sport",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "start",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "status",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "team_order_change",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "time",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "tradesuppress",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "type",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "usermockplayerlimit",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "year",
                table: "drafts");

            migrationBuilder.DropColumn(
                name: "MultiplayerDraftId",
                table: "DraftTeamUsers");

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

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "teams",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)")
                .OldAnnotation("MySql:CharSet", "utf8")
                .OldAnnotation("MySql:Collation", "utf8_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "teams",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "players",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "college",
                table: "players",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "players",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "drafts",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "mediumint(8) unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "draft_start_type_id",
                table: "drafts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "draft_status_id",
                table: "drafts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "is_computer_teams",
                table: "drafts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_multi_select",
                table: "drafts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "is_public",
                table: "drafts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "drafts",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "owner_id",
                table: "drafts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pick_time_id",
                table: "drafts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "round_count",
                table: "drafts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "start_time",
                table: "drafts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "drafts",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "draft_users",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "team_id",
                table: "draft_team_users",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "draft_team_users",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "player_id",
                table: "draft_team_user_players",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "team_id",
                table: "draft_team_user_players",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "draft_team_user_players",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AddPrimaryKey(
                name: "pk_teams",
                table: "teams",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_players",
                table: "players",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_drafts",
                table: "drafts",
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

            migrationBuilder.CreateTable(
                name: "draft_site_users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    token = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    username = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_draft_site_users", x => x.id);
                });

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
                name: "fk_draft_team_users_drafts_draft_id",
                table: "draft_team_users",
                column: "draft_id",
                principalTable: "drafts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

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
                name: "fk_draft_users_drafts_draft_id",
                table: "draft_users",
                column: "draft_id",
                principalTable: "drafts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_draft_users_draft_site_users_user_id",
                table: "draft_users",
                column: "user_id",
                principalTable: "draft_site_users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_drafts_draft_start_types_draft_start_type_id",
                table: "drafts",
                column: "draft_start_type_id",
                principalTable: "draft_start_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_drafts_draft_statuses_draft_status_id",
                table: "drafts",
                column: "draft_status_id",
                principalTable: "draft_statuses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_drafts_draft_site_users_owner_id",
                table: "drafts",
                column: "owner_id",
                principalTable: "draft_site_users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_drafts_draft_times_pick_time_id",
                table: "drafts",
                column: "pick_time_id",
                principalTable: "draft_times",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
