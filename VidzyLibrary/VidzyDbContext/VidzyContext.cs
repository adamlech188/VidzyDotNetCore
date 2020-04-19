using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using VidzyApp;
using VidzyLibrary.Models;

namespace VidzyLibrary.VidzyDbContext
{
    public partial class VidzyContext : DbContext
    {
        private IConfiguration Configuration { get; }
        public VidzyContext()
        {
            Configuration = AppConfigurationProvider.BuildConfigurtions();
        }
        public VidzyContext(IConfiguration configuration)
        {
            
        }
        public VidzyContext(DbContextOptions<VidzyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("VidzyDB"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genres>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Videos>(entity =>
            {
                entity.Property(e => e.Classification).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.GenreId)
                    .HasConstraintName("FK__Videos__GenreId__2B3F6F97");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
