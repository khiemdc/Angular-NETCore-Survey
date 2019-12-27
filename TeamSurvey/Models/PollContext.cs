using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TeamSurvey.Models
{
    public partial class PollContext : DbContext
    {
        public PollContext()
        {
        }

        public PollContext(DbContextOptions<PollContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IplTeams> IplTeams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Poll;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<IplTeams>(entity =>
            {
                entity.HasKey(e => e.TeamId)
                    .HasName("PK__IplTeams__123AE799CE7108CF");

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
