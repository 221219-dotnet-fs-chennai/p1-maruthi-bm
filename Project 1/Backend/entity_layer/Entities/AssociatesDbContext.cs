using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace entity_layer.Entities;

public partial class AssociatesDbContext : DbContext
{
    public AssociatesDbContext()
    {
    }

    public AssociatesDbContext(DbContextOptions<AssociatesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<UserDetail> UserDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:associateserver.database.windows.net,1433;Initial Catalog=AssociatesDb;Persist Security Info=False;User ID=associate;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK__Company__3E267235C3086EF5");

            entity.ToTable("Company", "Maruthi");

            entity.Property(e => e.CompanyId)
                .ValueGeneratedNever()
                .HasColumnName("company_id");
            entity.Property(e => e.EndDate)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("end_date");
            entity.Property(e => e.Industry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("industry");
            entity.Property(e => e.StratDate)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("strat_date");
            entity.Property(e => e.TrainerCompany)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TrainerId).HasColumnName("Trainer_id");

            entity.HasOne(d => d.Trainer).WithMany(p => p.Companies)
                .HasForeignKey(d => d.TrainerId)
                .HasConstraintName("FK__Company__Trainer__162F4418");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK__contact__024E7A86931AA6CC");

            entity.ToTable("contact", "Maruthi");

            entity.Property(e => e.ContactId)
                .ValueGeneratedNever()
                .HasColumnName("contact_id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone_no");
            entity.Property(e => e.SocialMedia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Social_Media");
            entity.Property(e => e.TrainerId).HasColumnName("Trainer_id");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("website");

            entity.HasOne(d => d.Trainer).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.TrainerId)
                .HasConstraintName("FK__contact__Trainer__1352D76D");
        });

        modelBuilder.Entity<Education>(entity =>
        {
            entity.HasKey(e => e.EducationId).HasName("PK__Educatio__45C0CFE7C7E29A9A");

            entity.ToTable("Education", "Maruthi");

            entity.Property(e => e.EducationId)
                .ValueGeneratedNever()
                .HasColumnName("education_id");
            entity.Property(e => e.Cgpa)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CGPA");
            entity.Property(e => e.Degree)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EndDate)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("end_date");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.InstituteName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("institute_name");
            entity.Property(e => e.StartDate)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("start_date");
            entity.Property(e => e.TrainerId).HasColumnName("Trainer_id");

            entity.HasOne(d => d.Trainer).WithMany(p => p.Educations)
                .HasForeignKey(d => d.TrainerId)
                .HasConstraintName("FK__Education__Train__190BB0C3");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.SkillsId).HasName("PK__Skills__6A4DBE2B4F30CB63");

            entity.ToTable("Skills", "Maruthi");

            entity.Property(e => e.SkillsId)
                .ValueGeneratedNever()
                .HasColumnName("skills_id");
            entity.Property(e => e.Certificate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Skills1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("skills_1");
            entity.Property(e => e.Skills2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("skills_2");
            entity.Property(e => e.TrainerId).HasColumnName("Trainer_id");

            entity.HasOne(d => d.Trainer).WithMany(p => p.Skills)
                .HasForeignKey(d => d.TrainerId)
                .HasConstraintName("FK_Skills.Trainer_id");
        });

        modelBuilder.Entity<UserDetail>(entity =>
        {
            entity.HasKey(e => e.TrainerId).HasName("PK__User_Det__8B0DBD698BE4A033");

            entity.ToTable("User_Details", "Maruthi");

            entity.Property(e => e.TrainerId)
                .ValueGeneratedNever()
                .HasColumnName("Trainer_id");
            entity.Property(e => e.Address)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Domain)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
