using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DraftSiteApi.Models
{
    public partial class comdraft_mainContext : DbContext
    {
        public comdraft_mainContext()
        {
        }

        public comdraft_mainContext(DbContextOptions<comdraft_mainContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<AdminAuthTokens> AdminAuthTokens { get; set; }
        public virtual DbSet<Ads> Ads { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Blogposts> Blogposts { get; set; }
        public virtual DbSet<BlogpostsBak> BlogpostsBak { get; set; }
        public virtual DbSet<Conferences> Conferences { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<DraftContributors> DraftContributors { get; set; }
        public virtual DbSet<DraftPicks> DraftPicks { get; set; }
        public virtual DbSet<DraftPlayers> DraftPlayers { get; set; }
        public virtual DbSet<DraftVersions> DraftVersions { get; set; }
        public virtual DbSet<Drafts> Drafts { get; set; }
        public virtual DbSet<DraftsUnpublished> DraftsUnpublished { get; set; }
        public virtual DbSet<Draftteams> Draftteams { get; set; }
        public virtual DbSet<Fantasy> Fantasy { get; set; }
        public virtual DbSet<FantasyRankings> FantasyRankings { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Globals> Globals { get; set; }
        public virtual DbSet<Leagues> Leagues { get; set; }
        public virtual DbSet<LoginCookieData> LoginCookieData { get; set; }
        public virtual DbSet<MockDrafts> MockDrafts { get; set; }
        public virtual DbSet<MockDraftsDeleted> MockDraftsDeleted { get; set; }
        public virtual DbSet<MockPicks> MockPicks { get; set; }
        public virtual DbSet<MockPicksDeleted> MockPicksDeleted { get; set; }
        public virtual DbSet<MockRounds> MockRounds { get; set; }
        public virtual DbSet<MockRoundsDeleted> MockRoundsDeleted { get; set; }
        public virtual DbSet<MockTrades> MockTrades { get; set; }
        public virtual DbSet<MockTradesDeleted> MockTradesDeleted { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Picks> Picks { get; set; }
        public virtual DbSet<PicksTemp> PicksTemp { get; set; }
        public virtual DbSet<PlayerContent> PlayerContent { get; set; }
        public virtual DbSet<PlayerContentTypes> PlayerContentTypes { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<PositionsSub> PositionsSub { get; set; }
        public virtual DbSet<Ranks> Ranks { get; set; }
        public virtual DbSet<RanksTemp> RanksTemp { get; set; }
        public virtual DbSet<ResetPassword> ResetPassword { get; set; }
        public virtual DbSet<Rounds> Rounds { get; set; }
        public virtual DbSet<Rules> Rules { get; set; }
        public virtual DbSet<Schools> Schools { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Sports> Sports { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Staticpicks> Staticpicks { get; set; }
        public virtual DbSet<Suppicks> Suppicks { get; set; }
        public virtual DbSet<TeamDraftAnalysis> TeamDraftAnalysis { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<TeamsPreviousNames> TeamsPreviousNames { get; set; }
        public virtual DbSet<Tradecheck> Tradecheck { get; set; }
        public virtual DbSet<Trades> Trades { get; set; }
        public virtual DbSet<Tradetransactions> Tradetransactions { get; set; }
        public virtual DbSet<UserAuthTokens> UserAuthTokens { get; set; }
        public virtual DbSet<UserDraftVotes> UserDraftVotes { get; set; }
        public virtual DbSet<UserGamificationCalculation> UserGamificationCalculation { get; set; }
        public virtual DbSet<UserGamificationPoints> UserGamificationPoints { get; set; }
        public virtual DbSet<UserMockDrafts> UserMockDrafts { get; set; }
        public virtual DbSet<UserMockDraftsContest> UserMockDraftsContest { get; set; }
        public virtual DbSet<UserPlayerRankings> UserPlayerRankings { get; set; }
        public virtual DbSet<UserPlayers> UserPlayers { get; set; }
        public virtual DbSet<UserRedrafts> UserRedrafts { get; set; }
        public virtual DbSet<UserTeamDraftAnalysis> UserTeamDraftAnalysis { get; set; }
        public virtual DbSet<UserTeamDraftAnalysisPicks> UserTeamDraftAnalysisPicks { get; set; }
        public virtual DbSet<UserTeamPicks> UserTeamPicks { get; set; }
        public virtual DbSet<Userranks> Userranks { get; set; }
        public virtual DbSet<UserranksCopy> UserranksCopy { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=67.202.70.5;user id=comdraftsite_main_read;password=\"H;E8yDSi(#zz\";database=comdraft_main", x => x.ServerVersion("10.3.22-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("admin");

                entity.HasIndex(e => e.Username)
                    .HasName("username")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.FacebookUsername)
                    .HasColumnName("facebook_username")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Lastlogin)
                    .HasColumnName("lastlogin")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.TwitterHandler)
                    .HasColumnName("twitter_handler")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<AdminAuthTokens>(entity =>
            {
                entity.ToTable("admin_auth_tokens");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AdminId)
                    .HasColumnName("admin_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Expires)
                    .HasColumnName("expires")
                    .HasColumnType("datetime");

                entity.Property(e => e.HashedValidator)
                    .IsRequired()
                    .HasColumnName("hashed_validator")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Selector)
                    .IsRequired()
                    .HasColumnName("selector")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Ads>(entity =>
            {
                entity.ToTable("ads");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("blob");
            });

            modelBuilder.Entity<Authors>(entity =>
            {
                entity.ToTable("authors");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdminId)
                    .HasColumnName("admin_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Blogposts>(entity =>
            {
                entity.ToTable("blogposts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasColumnName("author")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.AuthorId)
                    .HasColumnName("author_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FeaturedImage)
                    .IsRequired()
                    .HasColumnName("featured_image")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LastModifiedBy)
                    .HasColumnName("last_modified_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Sport)
                    .HasColumnName("sport")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Writer)
                    .HasColumnName("writer")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<BlogpostsBak>(entity =>
            {
                entity.ToTable("blogposts_bak");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasColumnName("author")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Sport)
                    .HasColumnName("sport")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("mediumtext")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Writer)
                    .HasColumnName("writer")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<Conferences>(entity =>
            {
                entity.ToTable("conferences");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasColumnName("division")
                    .HasColumnType("varchar(6)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasColumnName("nickname")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.ToTable("countries");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasColumnName("nickname")
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<DraftContributors>(entity =>
            {
                entity.ToTable("draft_contributors");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.AdminId)
                    .HasColumnName("admin_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<DraftPicks>(entity =>
            {
                entity.HasKey(e => new { e.DraftId, e.Order })
                    .HasName("PRIMARY");

                entity.ToTable("draft_picks");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RoundId)
                    .HasColumnName("round_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TypeDesc)
                    .IsRequired()
                    .HasColumnName("type_desc")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<DraftPlayers>(entity =>
            {
                entity.HasKey(e => new { e.DraftId, e.RankType, e.Rank })
                    .HasName("PRIMARY");

                entity.ToTable("draft_players");

                entity.HasIndex(e => new { e.DraftId, e.RankType })
                    .HasName("draft_ranktype");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.RankType)
                    .HasColumnName("rank_type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("player_id")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<DraftVersions>(entity =>
            {
                entity.HasKey(e => new { e.DraftId, e.RankType })
                    .HasName("PRIMARY");

                entity.ToTable("draft_versions");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.RankType)
                    .HasColumnName("rank_type")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.LastModifiedBy)
                    .HasColumnName("last_modified_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.LastPublished)
                    .HasColumnName("last_published")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastSaved)
                    .HasColumnName("last_saved")
                    .HasColumnType("datetime");

                entity.Property(e => e.PublishedRounds)
                    .HasColumnName("published_rounds")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SavedRounds)
                    .HasColumnName("saved_rounds")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Drafts>(entity =>
            {
                entity.ToTable("drafts");

                entity.HasIndex(e => e.Year)
                    .HasName("year");

                entity.HasIndex(e => new { e.Sport, e.Status })
                    .HasName("sport");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Compensatory)
                    .HasColumnName("compensatory")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Displayfreeagents).HasColumnName("displayfreeagents");

                entity.Property(e => e.End)
                    .HasColumnName("end")
                    .HasColumnType("date");

                entity.Property(e => e.LastModifiedBy)
                    .HasColumnName("last_modified_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Livemockstartinground)
                    .HasColumnName("livemockstartinground")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ManageDraft).HasColumnName("manage_draft");

                entity.Property(e => e.Monthonly)
                    .HasColumnName("monthonly")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.OpenBy)
                    .HasColumnName("open_by")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Playerdisplay)
                    .HasColumnName("playerdisplay")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Rounddisplay)
                    .HasColumnName("rounddisplay")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Sport)
                    .HasColumnName("sport")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Start)
                    .HasColumnName("start")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TeamOrderChange)
                    .HasColumnName("team_order_change")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'");

                entity.Property(e => e.Tradesuppress)
                    .HasColumnName("tradesuppress")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Usermockplayerlimit)
                    .HasColumnName("usermockplayerlimit")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasColumnName("year")
                    .HasColumnType("char(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<DraftsUnpublished>(entity =>
            {
                entity.ToTable("drafts_unpublished");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PostVars)
                    .IsRequired()
                    .HasColumnName("post_vars")
                    .HasColumnType("blob");

                entity.Property(e => e.SportId)
                    .HasColumnName("sport_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Steps)
                    .HasColumnName("steps")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<Draftteams>(entity =>
            {
                entity.ToTable("draftteams");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Commentary)
                    .IsRequired()
                    .HasColumnName("commentary")
                    .HasColumnType("blob");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<Fantasy>(entity =>
            {
                entity.ToTable("fantasy");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DatePublished)
                    .HasColumnName("date_published")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasColumnName("last_modified_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Playerdisplay)
                    .HasColumnName("playerdisplay")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasColumnName("slug")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SportId)
                    .HasColumnName("sport_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasColumnName("year")
                    .HasColumnType("char(4)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<FantasyRankings>(entity =>
            {
                entity.ToTable("fantasy_rankings");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.FantasyId)
                    .HasColumnName("fantasy_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("player_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Positions)
                    .IsRequired()
                    .HasColumnName("positions")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<Games>(entity =>
            {
                entity.ToTable("games");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Globals>(entity =>
            {
                entity.ToTable("globals");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasColumnType("blob");

                entity.Property(e => e.Sponsortakeover)
                    .HasColumnName("sponsortakeover")
                    .HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<Leagues>(entity =>
            {
                entity.ToTable("leagues");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasColumnName("nickname")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LoginCookieData>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Series, e.Token })
                    .HasName("PRIMARY");

                entity.ToTable("login_cookie_data");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Series)
                    .HasColumnName("series")
                    .HasColumnType("int(6)");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("int(6)");

                entity.Property(e => e.Expires)
                    .HasColumnName("expires")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastVerified)
                    .HasColumnName("last_verified")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MockDrafts>(entity =>
            {
                entity.ToTable("mock_drafts");

                entity.HasIndex(e => new { e.DraftId, e.Version })
                    .HasName("draft_version")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasComment("1=Current Mock. 0=Prior Mock");

                entity.Property(e => e.DatePublished)
                    .HasColumnName("date_published")
                    .HasColumnType("datetime");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<MockDraftsDeleted>(entity =>
            {
                entity.ToTable("mock_drafts_deleted");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Current).HasColumnName("current");

                entity.Property(e => e.DatePublished)
                    .HasColumnName("date_published")
                    .HasColumnType("datetime");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<MockPicks>(entity =>
            {
                entity.HasKey(e => new { e.MockDraftId, e.Order })
                    .HasName("PRIMARY");

                entity.ToTable("mock_picks");

                entity.Property(e => e.MockDraftId)
                    .HasColumnName("mock_draft_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("player_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.RoundOrder)
                    .HasColumnName("round_order")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.TypeDesc)
                    .IsRequired()
                    .HasColumnName("type_desc")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MockPicksDeleted>(entity =>
            {
                entity.HasKey(e => new { e.MockDraftId, e.Order })
                    .HasName("PRIMARY");

                entity.ToTable("mock_picks_deleted");

                entity.Property(e => e.MockDraftId)
                    .HasColumnName("mock_draft_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("player_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.RoundOrder)
                    .HasColumnName("round_order")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.TypeDesc)
                    .IsRequired()
                    .HasColumnName("type_desc")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MockRounds>(entity =>
            {
                entity.HasKey(e => new { e.MockDraftId, e.Order })
                    .HasName("PRIMARY");

                entity.ToTable("mock_rounds");

                entity.Property(e => e.MockDraftId)
                    .HasColumnName("mock_draft_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MockRoundsDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mock_rounds_deleted");

                entity.Property(e => e.MockDraftId)
                    .HasColumnName("mock_draft_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("tinyint(3)");
            });

            modelBuilder.Entity<MockTrades>(entity =>
            {
                entity.HasKey(e => new { e.MockDraftId, e.PickOrder })
                    .HasName("PRIMARY");

                entity.ToTable("mock_trades");

                entity.Property(e => e.MockDraftId)
                    .HasColumnName("mock_draft_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.PickOrder)
                    .HasColumnName("pick_order")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.TeamIds)
                    .IsRequired()
                    .HasColumnName("team_ids")
                    .HasColumnType("tinytext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TradeTransId)
                    .HasColumnName("trade_trans_id")
                    .HasColumnType("mediumint(8)");
            });

            modelBuilder.Entity<MockTradesDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mock_trades_deleted");

                entity.Property(e => e.MockDraftId)
                    .HasColumnName("mock_draft_id")
                    .HasColumnType("mediumint(8)");

                entity.Property(e => e.PickOrder)
                    .HasColumnName("pick_order")
                    .HasColumnType("smallint(5)");

                entity.Property(e => e.TeamIds)
                    .IsRequired()
                    .HasColumnName("team_ids")
                    .HasColumnType("tinytext")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TradeTransId)
                    .HasColumnName("trade_trans_id")
                    .HasColumnType("mediumint(8)");
            });

            modelBuilder.Entity<Permissions>(entity =>
            {
                entity.ToTable("permissions");

                entity.HasIndex(e => e.Admin)
                    .HasName("admin")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Admin)
                    .HasColumnName("admin")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.AdminEdit)
                    .HasColumnName("admin_edit")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Ads)
                    .HasColumnName("ads")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Agreement)
                    .HasColumnName("agreement")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Delete)
                    .HasColumnName("delete")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.DraftsCreate)
                    .HasColumnName("drafts_create")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.DraftsEdit)
                    .HasColumnName("drafts_edit")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.DraftsImport)
                    .HasColumnName("drafts_import")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.DraftsStage4Edit)
                    .HasColumnName("drafts_stage_4_edit")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Players)
                    .HasColumnName("players")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PlayersMedia)
                    .HasColumnName("players_media")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Positions)
                    .HasColumnName("positions")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Posts)
                    .HasColumnName("posts")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Ranks)
                    .HasColumnName("ranks")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Redrafts)
                    .HasColumnName("redrafts")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Rule)
                    .HasColumnName("rule")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Schools)
                    .HasColumnName("schools")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SportAccess)
                    .IsRequired()
                    .HasColumnName("sport_access")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sports)
                    .HasColumnName("sports")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Teams)
                    .HasColumnName("teams")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.UserEdit)
                    .HasColumnName("user_edit")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.WhatsNew)
                    .HasColumnName("whats_new")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Picks>(entity =>
            {
                entity.ToTable("picks");

                entity.HasIndex(e => e.Team)
                    .HasName("team");

                entity.HasIndex(e => new { e.Round, e.Type })
                    .HasName("round_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("blob");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Pick)
                    .HasColumnName("pick")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Round)
                    .HasColumnName("round")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Typename)
                    .IsRequired()
                    .HasColumnName("typename")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PicksTemp>(entity =>
            {
                entity.ToTable("picks_temp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("blob");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Pick)
                    .HasColumnName("pick")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Round)
                    .HasColumnName("round")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Typename)
                    .IsRequired()
                    .HasColumnName("typename")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<PlayerContent>(entity =>
            {
                entity.ToTable("player_content");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("player_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("type_id")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(10)");
            });

            modelBuilder.Entity<PlayerContentTypes>(entity =>
            {
                entity.ToTable("player_content_types");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.Column)
                    .IsRequired()
                    .HasColumnName("column")
                    .HasColumnType("enum('1','2')")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.PlayerLimit)
                    .HasColumnName("player_limit")
                    .HasColumnType("tinyint(2)");

                entity.Property(e => e.ShowName)
                    .IsRequired()
                    .HasColumnName("show_name")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserLimit)
                    .HasColumnName("user_limit")
                    .HasColumnType("tinyint(2)");
            });

            modelBuilder.Entity<Players>(entity =>
            {
                entity.ToTable("players");

                entity.HasIndex(e => e.Highschool)
                    .HasName("highschool");

                entity.HasIndex(e => e.Position)
                    .HasName("position");

                entity.HasIndex(e => e.School)
                    .HasName("school");

                entity.HasIndex(e => e.Team)
                    .HasName("team");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasColumnType("char(2)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bats)
                    .HasColumnName("bats")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Commentary)
                    .IsRequired()
                    .HasColumnName("commentary")
                    .HasColumnType("blob");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Draftclass)
                    .IsRequired()
                    .HasColumnName("draftclass")
                    .HasColumnType("char(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fantasy)
                    .HasColumnName("fantasy")
                    .HasColumnType("tinyint(3)");

                entity.Property(e => e.FantasyPositions)
                    .HasColumnName("fantasy_positions")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FantasyTeam)
                    .HasColumnName("fantasy_team")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gradclass)
                    .IsRequired()
                    .HasColumnName("gradclass")
                    .HasColumnType("char(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Heightf)
                    .HasColumnName("heightf")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Heighti)
                    .HasColumnName("heighti")
                    .HasColumnType("double unsigned");

                entity.Property(e => e.Highschool)
                    .HasColumnName("highschool")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.LastModifiedBy)
                    .HasColumnName("last_modified_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Lastactivity)
                    .HasColumnName("lastactivity")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes")
                    .HasColumnType("blob");

                entity.Property(e => e.PlayerComparison)
                    .HasColumnName("player_comparison")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Prehighschool)
                    .HasColumnName("prehighschool")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Preposition)
                    .HasColumnName("preposition")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Preschool)
                    .HasColumnName("preschool")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Preteam)
                    .HasColumnName("preteam")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Redshirt)
                    .HasColumnName("redshirt")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.School)
                    .HasColumnName("school")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Shoots)
                    .HasColumnName("shoots")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Sport)
                    .HasColumnName("sport")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Stats)
                    .IsRequired()
                    .HasColumnName("stats")
                    .HasColumnType("blob");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Throws)
                    .HasColumnName("throws")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TwitterHandler)
                    .HasColumnName("twitter_handler")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<Positions>(entity =>
            {
                entity.ToTable("positions");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasColumnName("fullname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Game)
                    .HasColumnName("game")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasColumnType("tinyint(2)");
            });

            modelBuilder.Entity<PositionsSub>(entity =>
            {
                entity.ToTable("positions_sub");

                entity.HasComment("Sub positions drawing from main position table");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("full name")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainPositions)
                    .HasColumnName("main positions")
                    .HasColumnType("tinyint(4)")
                    .HasComment("main pos reference num");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(10)")
                    .HasComment("abbreviated name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Ranks>(entity =>
            {
                entity.ToTable("ranks");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.HasIndex(e => new { e.Draft, e.Type })
                    .HasName("draft");

                entity.HasIndex(e => new { e.Draft, e.Type, e.Rank })
                    .HasName("draft_type_rank");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Player)
                    .HasColumnName("player")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<RanksTemp>(entity =>
            {
                entity.ToTable("ranks_temp");

                entity.HasIndex(e => e.Type)
                    .HasName("type");

                entity.HasIndex(e => new { e.Draft, e.Type })
                    .HasName("draft");

                entity.HasIndex(e => new { e.Draft, e.Type, e.Rank })
                    .HasName("draft_type_rank");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(8) unsigned");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Player)
                    .HasColumnName("player")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<ResetPassword>(entity =>
            {
                entity.ToTable("reset_password");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("timestamp")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Used).HasColumnName("used");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<Rounds>(entity =>
            {
                entity.ToTable("rounds");

                entity.HasIndex(e => new { e.Draft, e.Round })
                    .HasName("draft_round");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Round)
                    .HasColumnName("round")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Rules>(entity =>
            {
                entity.ToTable("rules");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Sport)
                    .HasColumnName("sport")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("mediumblob");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Schools>(entity =>
            {
                entity.ToTable("schools");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Conference)
                    .HasColumnName("conference")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Display)
                    .IsRequired()
                    .HasColumnName("display")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastModifiedBy)
                    .HasColumnName("last_modified_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(90)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Private)
                    .HasColumnName("private")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.Teamname)
                    .IsRequired()
                    .HasColumnName("teamname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.ToTable("settings");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("text")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Sports>(entity =>
            {
                entity.ToTable("sports");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.HasIndex(e => e.Nickname)
                    .HasName("nickname")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Game)
                    .HasColumnName("game")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasColumnType("blob");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasColumnName("nickname")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Sponsortakeover)
                    .HasColumnName("sponsortakeover")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasColumnType("tinyint(1) unsigned");
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.ToTable("states");

                entity.HasIndex(e => e.Abbrev)
                    .HasName("abbrev")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Abbrev)
                    .IsRequired()
                    .HasColumnName("abbrev")
                    .HasColumnType("char(2)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("mediumint(9)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("char(40)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<Staticpicks>(entity =>
            {
                entity.ToTable("staticpicks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("blob");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Pick)
                    .HasColumnName("pick")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Player)
                    .HasColumnName("player")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Round)
                    .HasColumnName("round")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.Tradelink)
                    .HasColumnName("tradelink")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Tradetext)
                    .IsRequired()
                    .HasColumnName("tradetext")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Typename)
                    .IsRequired()
                    .HasColumnName("typename")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Suppicks>(entity =>
            {
                entity.ToTable("suppicks");

                entity.HasIndex(e => new { e.Draft, e.Pick })
                    .HasName("draft_pick");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Pick)
                    .HasColumnName("pick")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Round)
                    .HasColumnName("round")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<TeamDraftAnalysis>(entity =>
            {
                entity.ToTable("team_draft_analysis");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Analysis)
                    .IsRequired()
                    .HasColumnName("analysis")
                    .HasColumnType("blob");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Positions)
                    .IsRequired()
                    .HasColumnName("positions")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Preview)
                    .IsRequired()
                    .HasColumnName("preview")
                    .HasColumnType("blob");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.ToTable("teams");

                entity.HasIndex(e => e.Successor)
                    .HasName("successor");

                entity.HasIndex(e => new { e.Sport, e.League, e.Active })
                    .HasName("sport_league_active");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Display)
                    .IsRequired()
                    .HasColumnName("display")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Home)
                    .IsRequired()
                    .HasColumnName("home")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastModifiedBy)
                    .HasColumnName("last_modified_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.League)
                    .HasColumnName("league")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sport)
                    .HasColumnName("sport")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Successor)
                    .HasColumnName("successor")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<TeamsPreviousNames>(entity =>
            {
                entity.ToTable("teams_previous_names");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Display)
                    .IsRequired()
                    .HasColumnName("display")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndYear)
                    .IsRequired()
                    .HasColumnName("end_year")
                    .HasColumnType("char(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Home)
                    .IsRequired()
                    .HasColumnName("home")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastModifiedBy)
                    .HasColumnName("last_modified_by")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StartYear)
                    .IsRequired()
                    .HasColumnName("start_year")
                    .HasColumnType("char(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<Tradecheck>(entity =>
            {
                entity.ToTable("tradecheck");

                entity.HasIndex(e => new { e.Trans, e.Check })
                    .HasName("trans");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(10) unsigned");

                entity.Property(e => e.Check).HasColumnName("check");

                entity.Property(e => e.Trans)
                    .HasColumnName("trans")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<Trades>(entity =>
            {
                entity.ToTable("trades");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("blob");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Sport)
                    .HasColumnName("sport")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<Tradetransactions>(entity =>
            {
                entity.ToTable("tradetransactions");

                entity.HasIndex(e => e.From)
                    .HasName("from");

                entity.HasIndex(e => new { e.Round, e.Fromoriginal, e.From })
                    .HasName("round_fromorig_from");

                entity.HasIndex(e => new { e.Round, e.Fromoriginal, e.From, e.Type })
                    .HasName("round_fromorig_from_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Check)
                    .HasColumnName("check")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.From)
                    .HasColumnName("from")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Fromoriginal)
                    .HasColumnName("fromoriginal")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Futuredraft)
                    .IsRequired()
                    .HasColumnName("futuredraft")
                    .HasColumnType("char(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Picktype)
                    .HasColumnName("picktype")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Player)
                    .IsRequired()
                    .HasColumnName("player")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PlayersTo)
                    .IsRequired()
                    .HasColumnName("players_to")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Round)
                    .HasColumnName("round")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Specialpickinstance)
                    .HasColumnName("specialpickinstance")
                    .HasColumnType("tinyint(2) unsigned");

                entity.Property(e => e.To)
                    .HasColumnName("to")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Trade)
                    .HasColumnName("trade")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<UserAuthTokens>(entity =>
            {
                entity.ToTable("user_auth_tokens");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Expires)
                    .HasColumnName("expires")
                    .HasColumnType("datetime");

                entity.Property(e => e.HashedValidator)
                    .IsRequired()
                    .HasColumnName("hashed_validator")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Selector)
                    .IsRequired()
                    .HasColumnName("selector")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<UserDraftVotes>(entity =>
            {
                entity.HasKey(e => new { e.VotingUserId, e.OwnerUserId, e.DraftId })
                    .HasName("PRIMARY");

                entity.ToTable("user_draft_votes");

                entity.HasIndex(e => new { e.OwnerUserId, e.DraftId })
                    .HasName("owner_user_id");

                entity.Property(e => e.VotingUserId)
                    .HasColumnName("voting_user_id")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OwnerUserId)
                    .HasColumnName("owner_user_id")
                    .HasColumnType("varchar(10)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("varchar(8)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rating).HasColumnName("rating");
            });

            modelBuilder.Entity<UserGamificationCalculation>(entity =>
            {
                entity.ToTable("user_gamification_calculation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.CorrectMocks)
                    .HasColumnName("correct_mocks")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CreateMocks)
                    .HasColumnName("create_mocks")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MockVotes)
                    .HasColumnName("mock_votes")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.MocksVoted)
                    .HasColumnName("mocks_voted")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PlayerAdditions)
                    .HasColumnName("player_additions")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PlayerComparison)
                    .HasColumnName("player_comparison")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScoutingReports)
                    .HasColumnName("scouting_reports")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.TeamNeeds)
                    .HasColumnName("team_needs")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.TeamPreview)
                    .HasColumnName("team_preview")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Total)
                    .HasColumnName("total")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Videos)
                    .HasColumnName("videos")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<UserGamificationPoints>(entity =>
            {
                entity.ToTable("user_gamification_points");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UserMockDrafts>(entity =>
            {
                entity.ToTable("user_mock_drafts");

                entity.HasIndex(e => new { e.DraftId, e.UserId })
                    .HasName("draft_user")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.CommentStatus)
                    .HasColumnName("comment_status")
                    .HasColumnType("tinyint(1) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.SharedStatus)
                    .HasColumnName("shared_status")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.UserRoundLimit).HasColumnName("user_round_limit");
            });

            modelBuilder.Entity<UserMockDraftsContest>(entity =>
            {
                entity.ToTable("user_mock_drafts_contest");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<UserPlayerRankings>(entity =>
            {
                entity.ToTable("user_player_rankings");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("player_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Visibility)
                    .IsRequired()
                    .HasColumnName("visibility")
                    .HasColumnType("enum('1','0')")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<UserPlayers>(entity =>
            {
                entity.ToTable("user_players");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Draftclass)
                    .HasColumnName("draftclass")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gradclass)
                    .HasColumnName("gradclass")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Heightf)
                    .HasColumnName("heightf")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Heighti)
                    .HasColumnName("heighti")
                    .HasColumnType("double unsigned");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.PlayerId)
                    .HasColumnName("player_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.School)
                    .HasColumnName("school")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Sport)
                    .HasColumnName("sport")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.TwitterHandler)
                    .IsRequired()
                    .HasColumnName("twitter_handler")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<UserRedrafts>(entity =>
            {
                entity.ToTable("user_redrafts");

                entity.HasIndex(e => new { e.DraftId, e.UserId })
                    .HasName("draft_user")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.SharedStatus)
                    .HasColumnName("shared_status")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.UserRoundLimit).HasColumnName("user_round_limit");
            });

            modelBuilder.Entity<UserTeamDraftAnalysis>(entity =>
            {
                entity.ToTable("user_team_draft_analysis");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Analysis)
                    .IsRequired()
                    .HasColumnName("analysis")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DraftId)
                    .HasColumnName("draft_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Preview)
                    .IsRequired()
                    .HasColumnName("preview")
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.SharedStatus)
                    .HasColumnName("shared_status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TeamId)
                    .HasColumnName("team_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("user_id")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<UserTeamDraftAnalysisPicks>(entity =>
            {
                entity.ToTable("user_team_draft_analysis_picks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Order)
                    .HasColumnName("order")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.PositionId)
                    .HasColumnName("position_id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.UserTeamDraftAnalysisId)
                    .HasColumnName("user_team_draft_analysis_id")
                    .HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<UserTeamPicks>(entity =>
            {
                entity.ToTable("user_team_picks");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Round)
                    .HasColumnName("round")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RoundId)
                    .HasColumnName("round_id")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Team)
                    .HasColumnName("team")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.TypeDesc)
                    .IsRequired()
                    .HasColumnName("type_desc")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<Userranks>(entity =>
            {
                entity.ToTable("userranks");

                entity.HasIndex(e => new { e.Draft, e.User })
                    .HasName("draft_user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("blob");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Player)
                    .HasColumnName("player")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<UserranksCopy>(entity =>
            {
                entity.ToTable("userranks_copy");

                entity.HasIndex(e => new { e.Draft, e.User })
                    .HasName("draft_user");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnName("comments")
                    .HasColumnType("blob");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Lastupdate)
                    .HasColumnName("lastupdate")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Player)
                    .HasColumnName("player")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("mediumint(8) unsigned");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Username)
                    .HasName("username")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(10) unsigned");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Dob)
                    .IsRequired()
                    .HasColumnName("dob")
                    .HasColumnType("varchar(4)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(70)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FacebookUsername)
                    .HasColumnName("facebook_username")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Featured).HasColumnName("featured");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasColumnType("varchar(70)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Joindate)
                    .HasColumnName("joindate")
                    .HasColumnType("date");

                entity.Property(e => e.Lastlogin)
                    .HasColumnName("lastlogin")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("'0000-00-00 00:00:00'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasColumnType("varchar(70)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Maillist)
                    .HasColumnName("maillist")
                    .HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(60)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Securityanswer)
                    .IsRequired()
                    .HasColumnName("securityanswer")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Securityphrase)
                    .IsRequired()
                    .HasColumnName("securityphrase")
                    .HasColumnType("blob");

                entity.Property(e => e.Sportorder)
                    .IsRequired()
                    .HasColumnName("sportorder")
                    .HasColumnType("char(15)")
                    .HasDefaultValueSql("'1,5,3,2,4,6,7,8'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Teammlb)
                    .HasColumnName("teammlb")
                    .HasColumnType("mediumint(5) unsigned");

                entity.Property(e => e.Teammls)
                    .HasColumnName("teammls")
                    .HasColumnType("mediumint(5) unsigned");

                entity.Property(e => e.Teamnba)
                    .HasColumnName("teamnba")
                    .HasColumnType("mediumint(5) unsigned");

                entity.Property(e => e.Teamnfl)
                    .HasColumnName("teamnfl")
                    .HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Teamnhl)
                    .HasColumnName("teamnhl")
                    .HasColumnType("mediumint(5) unsigned");

                entity.Property(e => e.Teamwnba)
                    .HasColumnName("teamwnba")
                    .HasColumnType("mediumint(5) unsigned");

                entity.Property(e => e.TwitterHandle)
                    .HasColumnName("twitter_handle")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("zip")
                    .HasColumnType("varchar(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
