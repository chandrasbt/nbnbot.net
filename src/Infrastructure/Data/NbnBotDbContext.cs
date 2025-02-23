using NbnBotClean.Application.Common.Interfaces;
using NbnBotClean.Domain.Entities.NbnBotDb;
using Microsoft.EntityFrameworkCore;

namespace NbnBotClean.Infrastructure.Data;

	public class NbnBotDbContext(DbContextOptions<NbnBotDbContext> options) : DbContext(options), INbnBotDbContext
	{
		
    public virtual DbSet<ServiceClass> ServiceClasses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ServiceClass>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("service_classes_PRIMARY")
                .IsClustered(false);

            entity.ToTable("service_classes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.OrderTypes)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("order_types");
            entity.Property(e => e.ServiceClass1).HasColumnName("service_class");
            entity.Property(e => e.Technology)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("technology");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("updated_by");
        });

    }

	}
