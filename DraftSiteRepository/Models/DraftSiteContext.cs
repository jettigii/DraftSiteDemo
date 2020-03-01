using DraftSiteModels.Data;
using DraftSiteModels.DraftSiteModels;
using DraftSiteModels.Entities;
using Marques.EFCore.SnakeCase;
using Microsoft.EntityFrameworkCore;

namespace DraftSiteRepository.Models
{
    public partial class DraftSiteContext : DbContext
    {
        public DraftSiteContext() { }

        public DraftSiteContext(DbContextOptions<DraftSiteContext> options) : base(options) { }

        // MultiDraft Tables
        public virtual DbSet<MultiplayerDraft> MultiPlayerDrafts { get; set; }
        public virtual DbSet<DraftTeamUser> DraftTeamUsers { get; set; }
        public virtual DbSet<DraftTeamUserPlayer> DraftTeamUserPlayers { get; set; }

        // Data Tables
        public virtual DbSet<DraftStartType> DraftStartTypes { get; set; }
        public virtual DbSet<DraftStatus> DraftStatuses { get; set; }
        public virtual DbSet<DraftTime> DraftTimes { get; set; }

        // Has call to MultiPlayerDraftOnModelBuilding
        #region DraftSite.com
        //public virtual DbSet<Admin> Admin { get; set; }
        //public virtual DbSet<AdminAuthTokens> AdminAuthTokens { get; set; }
        //public virtual DbSet<Ads> Ads { get; set; }
        //public virtual DbSet<Authors> Authors { get; set; }
        //public virtual DbSet<Blogposts> Blogposts { get; set; }
        //public virtual DbSet<BlogpostsBak> BlogpostsBak { get; set; }
        //public virtual DbSet<Conferences> Conferences { get; set; }
        //public virtual DbSet<Countries> Countries { get; set; }
        //public virtual DbSet<DraftContributors> DraftContributors { get; set; }
        //public virtual DbSet<DraftPicks> DraftPicks { get; set; }
        //public virtual DbSet<DraftPlayers> DraftPlayers { get; set; }
        //public virtual DbSet<DraftVersions> DraftVersions { get; set; }
        //public virtual DbSet<Drafts> Drafts { get; set; }
        //public virtual DbSet<DraftsUnpublished> DraftsUnpublished { get; set; }
        //public virtual DbSet<Draftteams> Draftteams { get; set; }
        //public virtual DbSet<Fantasy> Fantasy { get; set; }
        //public virtual DbSet<FantasyRankings> FantasyRankings { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Globals> Globals { get; set; }
        public virtual DbSet<Leagues> Leagues { get; set; }
        public virtual DbSet<LoginCookieData> LoginCookieData { get; set; }
        //public virtual DbSet<MockDrafts> MockDrafts { get; set; }
        //public virtual DbSet<MockDraftsDeleted> MockDraftsDeleted { get; set; }
        //public virtual DbSet<MockPicks> MockPicks { get; set; }
        //public virtual DbSet<MockPicksDeleted> MockPicksDeleted { get; set; }
        //public virtual DbSet<MockRounds> MockRounds { get; set; }
        //public virtual DbSet<MockRoundsDeleted> MockRoundsDeleted { get; set; }
        //public virtual DbSet<MockTrades> MockTrades { get; set; }
        //public virtual DbSet<MockTradesDeleted> MockTradesDeleted { get; set; }
        //public virtual DbSet<Permissions> Permissions { get; set; }
        //public virtual DbSet<Picks> Picks { get; set; }
        //public virtual DbSet<PicksTemp> PicksTemp { get; set; }
        public virtual DbSet<PlayerContent> PlayerContent { get; set; }
        public virtual DbSet<PlayerContentTypes> PlayerContentTypes { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<PositionsSub> PositionsSub { get; set; }
        public virtual DbSet<Ranks> Ranks { get; set; }
        public virtual DbSet<RanksTemp> RanksTemp { get; set; }
        //public virtual DbSet<ResetPassword> ResetPassword { get; set; }
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
        //public virtual DbSet<Tradecheck> Tradecheck { get; set; }
        //public virtual DbSet<Trades> Trades { get; set; }
        //public virtual DbSet<Tradetransactions> Tradetransactions { get; set; }
        public virtual DbSet<UserAuthTokens> UserAuthTokens { get; set; }
        //public virtual DbSet<UserDraftVotes> UserDraftVotes { get; set; }
        //public virtual DbSet<UserGamificationCalculation> UserGamificationCalculation { get; set; }
        //public virtual DbSet<UserGamificationPoints> UserGamificationPoints { get; set; }
        //public virtual DbSet<UserMockDrafts> UserMockDrafts { get; set; }
        //public virtual DbSet<UserMockDraftsContest> UserMockDraftsContest { get; set; }
        //public virtual DbSet<UserPlayerRankings> UserPlayerRankings { get; set; }
        //public virtual DbSet<UserPlayers> UserPlayers { get; set; }
        //public virtual DbSet<UserRedrafts> UserRedrafts { get; set; }
        //public virtual DbSet<UserTeamDraftAnalysis> UserTeamDraftAnalysis { get; set; }
        //public virtual DbSet<UserTeamDraftAnalysisPicks> UserTeamDraftAnalysisPicks { get; set; }
        //public virtual DbSet<UserTeamPicks> UserTeamPicks { get; set; }
        //public virtual DbSet<Userranks> Userranks { get; set; }
        //public virtual DbSet<UserranksCopy> UserranksCopy { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MultiplayerDraft>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<DraftTeamUser>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<DraftTeamUserPlayer>()
                .HasKey(entity => new { entity.DraftTeamUserId, entity.PlayerId });

            modelBuilder.Entity<DraftTeamUser>()
                .HasMany(entity => entity.DraftTeamUserPlayers)
                .WithOne(foreignEntity => foreignEntity.DraftTeamUser)
                .HasForeignKey(entity => entity.DraftTeamUserId);

            modelBuilder.Entity<MultiplayerDraft>()
                .HasOne(entity => entity.PickTime)
                .WithMany(foreignEntity => foreignEntity.Drafts)
                .HasForeignKey(entity => entity.PickTimeId);

            modelBuilder.Entity<MultiplayerDraft>()
                .HasOne(entity => entity.DraftStartType)
                .WithMany(foreignEntity => foreignEntity.Drafts)
                .HasForeignKey(entity => entity.DraftStartTypeId);

            modelBuilder.Entity<MultiplayerDraft>()
                .HasOne(entity => entity.Owner)
                .WithMany(foreignEntity => foreignEntity.MultiPlayerDrafts)
                .HasForeignKey(entity => entity.OwnerId);

            modelBuilder.Entity<DraftTime>()
                .HasMany(entity => entity.Drafts)
                .WithOne(foreignEntity => foreignEntity.PickTime)
                .HasForeignKey(entity => entity.PickTimeId);

            modelBuilder.Entity<DraftStatus>()
                .HasMany(entity => entity.Drafts)
                .WithOne(foreignEntity => foreignEntity.DraftStatus)
                .HasForeignKey(entity => entity.DraftStatusId);

            modelBuilder.Entity<DraftTeamUser>()
                .HasOne(entity => entity.MultiPlayerDraft)
                .WithMany(foreignEntity => foreignEntity.DraftTeamUsers)
                .HasForeignKey(entity => entity.MultiPlayerDraftId);

            modelBuilder.Entity<DraftTeamUser>()
                .HasOne(entity => entity.Team)
                .WithMany(foreignEntity => foreignEntity.DraftTeamUsers)
                .HasForeignKey(entity => entity.TeamsId);

            modelBuilder.Entity<DraftTeamUser>()
                .HasOne(entity => entity.User)
                .WithMany(foreignEntity => foreignEntity.DraftTeamUsers)
                .HasForeignKey(entity => entity.UsersId);

            modelBuilder.Entity<DraftTeamUserPlayer>()
                .HasOne(entity => entity.DraftTeamUser)
                .WithMany(foreignEntity => foreignEntity.DraftTeamUserPlayers)
                .HasForeignKey(entity => entity.DraftTeamUserId);

            modelBuilder.Entity<DraftTeamUserPlayer>()
                .HasOne(entity => entity.Player)
                .WithMany(foreignEntity => foreignEntity.DraftTeamUserPlayers)
                .HasForeignKey(entity => entity.PlayerId);

            modelBuilder.Entity<Users>()
                .HasMany(entity => entity.MultiPlayerDrafts)
                .WithOne(foreignEntity => foreignEntity.Owner)
                .HasForeignKey(entity => entity.OwnerId);

            modelBuilder.Entity<Users>()
                .HasMany(entity => entity.DraftTeamUsers)
                .WithOne(foreignEntity => foreignEntity.User)
                .HasForeignKey(entity => entity.UsersId);

            modelBuilder.Entity<DraftStartType>().HasData(DraftStartTypeData.DraftStartTypes);
            modelBuilder.Entity<DraftStatus>().HasData(DraftStatusData.DraftStatuses);
            modelBuilder.Entity<DraftTime>().HasData(DraftTimeData.DraftTimes);

            base.OnModelCreating(modelBuilder);

            modelBuilder.ToSnakeCase();
        }
    }
}
