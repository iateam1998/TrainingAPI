using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataService.DBEntity
{
    public partial class TrainingAPIContext : DbContext
    {
        public TrainingAPIContext()
        {
        }

        public TrainingAPIContext(DbContextOptions<TrainingAPIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Major> Major { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<SubjectTeacher> SubjectTeacher { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<TeacherClasses> TeacherClasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=113.161.84.245,1444;Database=TrainingAPI;Trusted_Connection=False;uid=sa;pwd=zaQ@1234");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Classes>(entity =>
            {
                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Major>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Major1)
                    .IsRequired()
                    .HasColumnName("Major")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MajorId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mssv)
                    .IsRequired()
                    .HasColumnName("MSSV")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Note).IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.SinhVien)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SinhVien_Classes");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.SinhVien)
                    .HasForeignKey(d => d.MajorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SinhVien_Major");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.MajorId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Subject1)
                    .IsRequired()
                    .HasColumnName("Subject")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Subject)
                    .HasForeignKey(d => d.MajorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subject_Major");
            });

            modelBuilder.Entity<SubjectTeacher>(entity =>
            {
                entity.HasKey(e => new { e.SubjectId, e.TeacherId });

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.SubjectTeacher)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubjectTeacher_Subject");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.SubjectTeacher)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubjectTeacher_Teacher");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TeacherClasses>(entity =>
            {
                entity.HasKey(e => new { e.TeacherId, e.ClassId });

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TeacherClasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherClasses_Classes");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherClasses)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeacherClasses_Teacher");
            });
        }
    }
}
