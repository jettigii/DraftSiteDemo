﻿using DraftSiteModels.Entities;
using DraftSiteModels.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DraftSiteRepository
{
    public class DraftSiteContext : DbContext
    {
        public DraftSiteContext(DbContextOptions<DraftSiteContext> options) : base(options) { }

        // Pre-existing tables
        public DbSet<DraftSiteUser> DraftSiteUsers { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        // MultiDraft Tables
        public DbSet<Draft> Drafts { get; set; }
        public DbSet<DraftUser> DraftUsers { get; set; }
        public DbSet<DraftTeamUser> DraftTeamUsers { get; set; }
        public DbSet<DraftTeamUserPlayer> DraftTeamUserPlayers { get; set; }

        // Data Tables
        public DbSet<DraftTime> DraftTimes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = ConfigurePrimaryKeys(modelBuilder);

            modelBuilder = ConfigureForeignKeys(modelBuilder);

            modelBuilder = SeedDraftTimeData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private ModelBuilder ConfigurePrimaryKeys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DraftSiteUser>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<Player>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<Team>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<Draft>()
                .HasKey(entity => entity.Id);

            modelBuilder.Entity<DraftUser>()
                .HasKey(entity => new { entity.DraftId, entity.UserId });

            modelBuilder.Entity<DraftTeamUser>()
                .HasKey(entity => new { entity.DraftId, entity.UserId, entity.TeamId });

            modelBuilder.Entity<DraftTeamUserPlayer>()
                .HasKey(entity => new { entity.DraftId, entity.UserId, entity.TeamId, entity.PlayerId });

            return modelBuilder;
        }

        private ModelBuilder ConfigureForeignKeys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Draft>()
                .HasOne(entity => entity.PickTime)
                .WithMany(foreignEntity => foreignEntity.Drafts)
                .HasForeignKey(entity => entity.PickTimeId);

            modelBuilder.Entity<DraftTime>()
                .HasMany(entity => entity.Drafts)
                .WithOne(foreignEntity => foreignEntity.PickTime)
                .HasForeignKey(entity => entity.PickTimeId);

            modelBuilder.Entity<Draft>()
                .HasOne(entity => entity.Owner)
                .WithMany(foreignEntity => foreignEntity.Drafts)
                .HasForeignKey(entity => entity.OwnerId);

            modelBuilder.Entity<DraftUser>()
            .HasOne(entity => entity.User)
            .WithMany(foreignEntity => foreignEntity.DraftUsers)
            .HasForeignKey(entity => entity.UserId);

            modelBuilder.Entity<DraftUser>()
                .HasOne(entity => entity.Draft)
                .WithMany(foreignEntity => foreignEntity.DraftUsers)
                .HasForeignKey(entity => entity.DraftId);

            modelBuilder.Entity<DraftTeamUser>()
                .HasOne(entity => entity.DraftUser)
                .WithMany(foreignEntity => foreignEntity.DraftTeamUsers)
                .HasForeignKey(entity => new { entity.DraftId, entity.UserId });

            modelBuilder.Entity<DraftTeamUser>()
                .HasOne(entity => entity.Team)
                .WithMany(foreignEntity => foreignEntity.DraftTeamUsers)
                .HasForeignKey(entity => entity.TeamId);

            modelBuilder.Entity<DraftTeamUserPlayer>()
                .HasOne(entity => entity.DraftTeamUser)
                .WithMany(foreignEntity => foreignEntity.DraftTeamUserPlayers)
                .HasForeignKey(entity => new { entity.DraftId, entity.TeamId, entity.UserId });

            modelBuilder.Entity<DraftTeamUserPlayer>()
                .HasOne(entity => entity.Player)
                .WithMany(foreignEntity => foreignEntity.DraftTeamUserPlayers)
                .HasForeignKey(entity => entity.PlayerId);

            return modelBuilder;
        }

        private ModelBuilder SeedDraftTimeData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DraftTime>().HasData(DraftTimeData);

            return modelBuilder;
        }

        public List<DraftTime> DraftTimeData = new List<DraftTime>()
        {
            new DraftTime() { Id = 1, Name = "ThirtySeconds", TimeInSeconds = 30, Value = "30 Seconds" },
            new DraftTime() { Id = 2, Name = "OneMinute", TimeInSeconds = 60, Value = "1 Minute" },
            new DraftTime() { Id = 3, Name = "FiveMinutes", TimeInSeconds = 300, Value = "5 Minutes" },
            new DraftTime() { Id = 4, Name = "OneHour", TimeInSeconds = 3600, Value = "1 Hour" },
            new DraftTime() { Id = 5, Name = "Unlimited", TimeInSeconds = 0, Value = "Unlimited" }
        };
    }
}
