using Hitabi.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Hitabi.Backend.DBContext;

public partial class HitabiDBContext : DbContext
{
    public HitabiDBContext()
    {
    }

    public HitabiDBContext(DbContextOptions<HitabiDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<CopyInfo> CopyInfos { get; set; }

    public virtual DbSet<Follower> Followers { get; set; }

    public virtual DbSet<LoginType> LoginTypes { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MemberAccessToken> MemberAccessTokens { get; set; }

    public virtual DbSet<MemberBudget> MemberBudgets { get; set; }

    public virtual DbSet<MemberTransportation> MemberTransportations { get; set; }

    public virtual DbSet<Pretecture> Pretectures { get; set; }

    public virtual DbSet<TripAchievement> TripAchievements { get; set; }

    public virtual DbSet<TripAchievementComment> TripAchievementComments { get; set; }

    public virtual DbSet<TripAchievementPhoto> TripAchievementPhotos { get; set; }

    public virtual DbSet<TripMember> TripMembers { get; set; }

    public virtual DbSet<TripSchedule> TripSchedules { get; set; }

    public virtual DbSet<TripScheduleDetail> TripScheduleDetails { get; set; }

    public virtual DbSet<TripScheduleDetailComment> TripScheduleDetailComments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<CopyInfo>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PK_CopyInto");

            entity.ToTable("CopyInfo");

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.DateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Member).WithMany(p => p.CopyInfos)
                .HasForeignKey(d => d.MemberGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CopyInfo_Members");

            entity.HasOne(d => d.TripSchedule).WithMany(p => p.CopyInfos)
                .HasForeignKey(d => d.TripScheduleGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CopyInfo_TripSchedules");
        });

        modelBuilder.Entity<Follower>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.DateTime).HasColumnType("datetime");

            entity.HasOne(d => d.FollowerMember).WithMany(p => p.FollowerFollowerMembers)
                .HasForeignKey(d => d.FollowerMemberGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Followers_Members1");

            entity.HasOne(d => d.Member).WithMany(p => p.FollowerMembers)
                .HasForeignKey(d => d.MemberGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Followers_Members");
        });

        modelBuilder.Entity<LoginType>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.LoginType).WithMany(p => p.Members)
                .HasForeignKey(d => d.LoginTypeGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Members_LoginTypes");
        });

        modelBuilder.Entity<MemberAccessToken>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Expires).HasColumnType("datetime");
            entity.Property(e => e.Token)
                .HasMaxLength(128)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberAccessTokens_Members");
        });

        modelBuilder.Entity<MemberBudget>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();

            entity.HasOne(d => d.Member).WithMany(p => p.MemberBudgets)
                .HasForeignKey(d => d.MemberGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberBudgets_Members");
        });

        modelBuilder.Entity<MemberTransportation>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Member).WithMany(p => p.MemberTransportations)
                .HasForeignKey(d => d.MemberGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberTransportations_Members");
        });

        modelBuilder.Entity<Pretecture>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.Icon)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Area).WithMany(p => p.Pretectures)
                .HasForeignKey(d => d.AreaGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pretectures_Areas");
        });

        modelBuilder.Entity<TripAchievement>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();

            entity.HasOne(d => d.TripSchedule).WithMany(p => p.TripAchievements)
                .HasForeignKey(d => d.TripScheduleGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripAchievements_TripSchedules");
        });

        modelBuilder.Entity<TripAchievementComment>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.Comment).HasColumnType("ntext");

            entity.HasOne(d => d.Member).WithMany(p => p.TripAchievementComments)
                .HasForeignKey(d => d.MemberGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripAchievementComments_TripAchievements");

            entity.HasOne(d => d.TripAchievement).WithMany(p => p.TripAchievementComments)
                .HasForeignKey(d => d.TripAchievementGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripAchievementComments_TripAchievements1");
        });

        modelBuilder.Entity<TripAchievementPhoto>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.ToTable("TripAchievementPhoto");

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.PhotoUrl)
                .HasMaxLength(100)
                .HasColumnName("PhotoURL");

            entity.HasOne(d => d.TripAchievement).WithMany(p => p.TripAchievementPhotos)
                .HasForeignKey(d => d.TripAchievementGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripAchievementPhoto_TripAchievements");
        });

        modelBuilder.Entity<TripMember>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();

            entity.HasOne(d => d.Member).WithMany(p => p.TripMembers)
                .HasForeignKey(d => d.MemberGuid)
                .HasConstraintName("FK_TripMembers_TripSchedules");

            entity.HasOne(d => d.TripSchedule).WithMany(p => p.TripMembers)
                .HasForeignKey(d => d.TripScheduleGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripMembers_TripSchedules1");
        });

        modelBuilder.Entity<TripSchedule>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();

            entity.HasOne(d => d.DestinationPrefecture).WithMany(p => p.TripSchedules)
                .HasForeignKey(d => d.DestinationPrefectureGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripSchedules_Pretectures");

            entity.HasOne(d => d.Owner).WithMany(p => p.TripSchedules)
                .HasForeignKey(d => d.OwnerGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripSchedules_Members");
        });

        modelBuilder.Entity<TripScheduleDetail>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.Destination).HasMaxLength(100);
            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.HasOne(d => d.TripSchedule).WithMany(p => p.TripScheduleDetails)
                .HasForeignKey(d => d.TripScheduleGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripScheduleDetails_TripSchedules");
        });

        modelBuilder.Entity<TripScheduleDetailComment>(entity =>
        {
            entity.HasKey(e => e.Guid);

            entity.Property(e => e.Guid).ValueGeneratedNever();
            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Url)
                .HasColumnType("ntext")
                .HasColumnName("URL");

            entity.HasOne(d => d.Member).WithMany(p => p.TripScheduleDetailComments)
                .HasForeignKey(d => d.MemberGuid)
                .HasConstraintName("FK_TripScheduleDetailComments_TripScheduleDetails");

            entity.HasOne(d => d.TripScheduleDatail).WithMany(p => p.TripScheduleDetailComments)
                .HasForeignKey(d => d.TripScheduleDatailGuid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TripScheduleDetailComments_TripScheduleDetails1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
