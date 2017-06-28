using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LabTrack.Models
{
    public partial class LabTrackContext : DbContext
    {
        public virtual DbSet<Frig> Frig { get; set; }
        public virtual DbSet<LabTrack> LabTrack { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<RackTypes> RackTypes { get; set; }
        public virtual DbSet<Racks> Racks { get; set; }
        public virtual DbSet<Sections> Sections { get; set; }
        public virtual DbSet<Specs> Specs { get; set; }

        public LabTrackContext(DbContextOptions<LabTrackContext> options) : base(options)
        {
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //    optionsBuilder.UseSqlServer(@"Server=WEBSQL01;Database=LabTrack;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Frig>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FrigShelf)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LabTrack>(entity =>
            {
                entity.HasIndex(e => e.Rack)
                    .HasName("rack");

                entity.HasIndex(e => e.Specnum)
                    .HasName("specnum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("ntext");

                entity.Property(e => e.Entdate)
                    .HasColumnName("entdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Expdate)
                    .HasColumnName("expdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Frig)
                    .HasColumnName("frig")
                    .HasMaxLength(50);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(50);

                entity.Property(e => e.Locnum)
                    .HasColumnName("locnum")
                    .HasMaxLength(50);

                entity.Property(e => e.Rack)
                    .HasColumnName("rack")
                    .HasMaxLength(50);

                entity.Property(e => e.Section)
                    .HasColumnName("section")
                    .HasMaxLength(50);

                entity.Property(e => e.Specnum)
                    .HasColumnName("specnum")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<RackTypes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RackType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Racks>(entity =>
            {
                entity.HasIndex(e => e.FrigId)
                    .HasName("IX_Racks_2");

                entity.HasIndex(e => e.LocationId)
                    .HasName("IX_Racks");

                entity.HasIndex(e => e.SectionId)
                    .HasName("IX_Racks_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.FrigId).HasColumnName("FrigID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Rack)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RackTypeId).HasColumnName("RackTypeID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");
            });

            modelBuilder.Entity<Sections>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Specs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasMaxLength(1024);

                entity.Property(e => e.Position).HasMaxLength(10);

                entity.Property(e => e.RackId).HasColumnName("RackID");

                entity.Property(e => e.Specnum).HasMaxLength(11);
            });
        }
    }
}