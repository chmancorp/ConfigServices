using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Blink.Data.DataAcces
{
    public partial class ConfigServiceDataBaseContext : DbContext
    {
        public ConfigServiceDataBaseContext()
        {
        }

        public ConfigServiceDataBaseContext(DbContextOptions<ConfigServiceDataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlockUserDb> BlockUserDb { get; set; }
        public virtual DbSet<CodeAuthDb> CodeAuthDb { get; set; }
        public virtual DbSet<FrequencyRequestDB> FrequencyRequestDB { get; set; }
        public virtual DbSet<MessageSystemDb> MessageSystemDb { get; set; }
        public virtual DbSet<ValidationDb> ValidationDb { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlockUserDb>(entity =>
            {
                entity.HasKey(e => e.BlockUserId);

                entity.ToTable("BlockUserDB");
            });

            modelBuilder.Entity<CodeAuthDb>(entity =>
            {
                entity.HasKey(e => e.CodeAuthId);

                entity.ToTable("CodeAuthDB");

                entity.Property(e => e.CodeAuthId).ValueGeneratedNever();
            });

            modelBuilder.Entity<FrequencyRequestDB>(entity =>
            {
                entity.HasKey(e => e.FrequencyId);
            });

            modelBuilder.Entity<MessageSystemDb>(entity =>
            {
                entity.HasKey(e => e.MessageSystemId);

                entity.ToTable("MessageSystemDB");

                entity.Property(e => e.Language).HasMaxLength(10);

                entity.Property(e => e.Message).HasMaxLength(200);
            });

            modelBuilder.Entity<ValidationDb>(entity =>
            {
                entity.HasKey(e => e.ValidaConfigId);

                entity.ToTable("ValidationDB");

                entity.Property(e => e.Description).HasMaxLength(50);
            });
        }
    }
}
