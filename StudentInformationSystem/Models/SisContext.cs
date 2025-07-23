using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentInformationSystem.Models;

public partial class SisContext : DbContext
{
    public SisContext()
    {
    }

    public SisContext(DbContextOptions<SisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserLogin> UserLogins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-BU1PG9R\\SQLEXPRESS;Initial Catalog=SIS;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // === BASE ENTITY ===
        modelBuilder.Entity<User>(entity =>
        {
            // === BASE ENTITY ===
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasIndex(e => e.Phone).IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.Property(e => e.FullName).HasColumnName("full_name").HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Email).HasColumnName("email").HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.Phone).HasColumnName("phone").HasMaxLength(20).IsUnicode(false);
                entity.Property(e => e.Gender).HasColumnName("gender").HasMaxLength(20).IsUnicode(false);
                entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth").HasColumnType("datetime");
                entity.Property(e => e.Usertype).HasColumnName("usertype").HasMaxLength(20).IsUnicode(false);
                entity.Property(e => e.CreatedAt).HasColumnName("created_at").HasDefaultValueSql("(getdate())").HasColumnType("datetime");
            });

            // === DERIVED ENTITIES ===
            // Admin
            modelBuilder.Entity<Admin>().ToTable("Admin");

            // Student (adds Address, Status, EnrollmentDate)
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");
                entity.Property(e => e.Address).HasColumnName("address").HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.EnrollmentDate).HasColumnName("enrollment_date").HasColumnType("datetime");
                entity.Property(e => e.Status).HasColumnName("status");
            });

            // Teacher (adds Department, Specialization, HireDate, Status)
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");
                entity.Property(e => e.Department).HasColumnName("department").HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Specialization).HasColumnName("specialization").HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.HireDate).HasColumnName("hire_date").HasColumnType("datetime");
                entity.Property(e => e.Status).HasColumnName("status");
            });

            // === LOGIN ===
            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable("User_Login");
                entity.HasIndex(e => e.Username).IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");
                entity.Property(e => e.Username).HasColumnName("username").HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.PasswordHash).HasColumnName("password_hash").HasMaxLength(128).IsUnicode(false);

                entity.HasOne(e => e.User)
                    .WithOne(u => u.UserLogin)
                    .HasForeignKey<UserLogin>(e => e.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLogin_User");
            });

            // === COURSE ===
            modelBuilder.Entity<Course>(entity =>
            {
                entity.ToTable("Course");
                entity.HasKey(e => e.CourseId);
                entity.HasIndex(e => e.CourseCode).IsUnique();

                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.CourseName).HasColumnName("course_name").HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.CourseCode).HasColumnName("course_code").HasMaxLength(15).IsUnicode(false);
                entity.Property(e => e.Description).HasColumnName("description").HasMaxLength(150).IsUnicode(false);
                entity.Property(e => e.Credits).HasColumnName("credits");
                entity.Property(e => e.TeacherId).HasColumnName("teacher_id");

                entity.HasOne(d => d.Teacher).WithMany(p => p.Courses)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Course_Teacher");
            });

            // === GRADE ===
            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("Grade");
                entity.HasKey(e => e.GradeId);

                entity.Property(e => e.GradeId).HasColumnName("grade_id");
                entity.Property(e => e.StudentId).HasColumnName("student_id");
                entity.Property(e => e.CourseId).HasColumnName("course_id");
                entity.Property(e => e.Grade1).HasColumnName("grade");
                entity.Property(e => e.Semester).HasColumnName("semester");
                entity.Property(e => e.GradeDate).HasColumnName("grade_date").HasColumnType("datetime");

                entity.HasOne(d => d.Student).WithMany(p => p.Grades)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Grade_Student");

                entity.HasOne(d => d.Course).WithMany(p => p.Grades)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Grade_Course");
            });

            OnModelCreatingPartial(modelBuilder);
        });
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
