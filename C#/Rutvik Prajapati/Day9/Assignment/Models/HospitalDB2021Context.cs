using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Day9Task.Assignment.Models
{
    public partial class HospitalDB2021Context : DbContext
    {
        public HospitalDB2021Context()
        {
        }

        public HospitalDB2021Context(DbContextOptions<HospitalDB2021Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Assistant> Assistant { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<DoctorPatientData> DoctorPatientData { get; set; }
        public virtual DbSet<DoctorPatientsList> DoctorPatientsList { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientMedicine> PatientMedicine { get; set; }
        public virtual DbSet<PatientMedicinesList> PatientMedicinesList { get; set; }
        public virtual DbSet<PatientReport> PatientReport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=HospitalDB2021;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assistant>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Assistant)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctor_Assistant");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_Doctor");
            });

            modelBuilder.Entity<DoctorPatientData>(entity =>
            {
                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.DoctorPatientData)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctor_DoctorPatientData");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.DoctorPatientData)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_DoctorPatientData");
            });

            modelBuilder.Entity<DoctorPatientsList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DoctorPatientsList");

                entity.Property(e => e.DoctorName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Assistant)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.AssistantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assistant_Patient");
            });

            modelBuilder.Entity<PatientMedicine>(entity =>
            {
                entity.Property(e => e.DayPart).HasComment("Morning=1,Afternoon=2,Night=3");

                entity.HasOne(d => d.Medicine)
                    .WithMany(p => p.PatientMedicine)
                    .HasForeignKey(d => d.MedicineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicine_PatientMedicine");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicine)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_PatientMedicine");
            });

            modelBuilder.Entity<PatientMedicinesList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PatientMedicinesList");

                entity.Property(e => e.MedicineName)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientReport>(entity =>
            {
                entity.Property(e => e.Status).HasComment("Accelent=1,Poor=2,Average=3");

                entity.Property(e => e.VisitDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.PatientReport)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctor_PatientReport");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientReport)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_PatientReport");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
