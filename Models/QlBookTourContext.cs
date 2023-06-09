using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Webdemo.Models
{
    public partial class QlBookTourContext : DbContext
    {
        public QlBookTourContext()
        {
        }

        public QlBookTourContext(DbContextOptions<QlBookTourContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TAnhChiTietTour> TAnhChiTietTours { get; set; } = null!;
        public virtual DbSet<TAnhTour> TAnhTours { get; set; } = null!;
        public virtual DbSet<TChiTietHoaDon> TChiTietHoaDons { get; set; } = null!;
        public virtual DbSet<TChiTietTour> TChiTietTours { get; set; } = null!;
        public virtual DbSet<TDiaDiem> TDiaDiems { get; set; } = null!;
        public virtual DbSet<THoaDon> THoaDons { get; set; } = null!;
        public virtual DbSet<TKhachHang> TKhachHangs { get; set; } = null!;
        public virtual DbSet<TKhachSan> TKhachSans { get; set; } = null!;
        public virtual DbSet<TLoaiTour> TLoaiTours { get; set; } = null!;
        public virtual DbSet<TNguoi> TNguois { get; set; } = null!;
        public virtual DbSet<TNhanVien> TNhanViens { get; set; } = null!;
        public virtual DbSet<TPhuongTien> TPhuongTiens { get; set; } = null!;
        public virtual DbSet<TSoCho> TSoChos { get; set; } = null!;
        public virtual DbSet<TThoiGian> TThoiGians { get; set; } = null!;
        public virtual DbSet<TTour> TTours { get; set; } = null!;
        public virtual DbSet<TUser> TUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ThuwThuw;Initial Catalog=QlBookTour;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAnhChiTietTour>(entity =>
            {
                entity.HasKey(e => e.MaChiTietTour);

                entity.ToTable("tAnhChiTietTour");

                entity.Property(e => e.MaChiTietTour).ValueGeneratedNever();

                entity.Property(e => e.ViTri).HasMaxLength(50);
            });

            modelBuilder.Entity<TAnhTour>(entity =>
            {
                entity.HasKey(e => e.MaTour);

                entity.ToTable("tAnhTour");

                entity.Property(e => e.MaTour).ValueGeneratedNever();

                entity.Property(e => e.Vitri).HasMaxLength(50);

                entity.HasOne(d => d.MaTourNavigation)
                    .WithOne(p => p.TAnhTour)
                    .HasForeignKey<TAnhTour>(d => d.MaTour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tAnhTour_tTour");
            });

            modelBuilder.Entity<TChiTietHoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.ToTable("tChiTietHoaDon");

                entity.Property(e => e.MaHd)
                    .ValueGeneratedNever()
                    .HasColumnName("MaHD");

                entity.HasOne(d => d.MaChiTietTourNavigation)
                    .WithMany(p => p.TChiTietHoaDons)
                    .HasForeignKey(d => d.MaChiTietTour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tChiTietHoaDon_tChiTietTour");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithOne(p => p.TChiTietHoaDon)
                    .HasForeignKey<TChiTietHoaDon>(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tChiTietHoaDon_tHoaDon");
            });

            modelBuilder.Entity<TChiTietTour>(entity =>
            {
                entity.HasKey(e => e.MaChiTietTour);

                entity.ToTable("tChiTietTour");

                entity.Property(e => e.MaChiTietTour).ValueGeneratedNever();

                entity.Property(e => e.MaTg).HasColumnName("MaTG");

                entity.HasOne(d => d.MaChiTietTourNavigation)
                    .WithOne(p => p.TChiTietTour)
                    .HasForeignKey<TChiTietTour>(d => d.MaChiTietTour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tChiTietTour_tAnhChiTietTour");

                entity.HasOne(d => d.MaSoChoNavigation)
                    .WithMany(p => p.TChiTietTours)
                    .HasForeignKey(d => d.MaSoCho)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tChiTietTour_tSoCho");

                entity.HasOne(d => d.MaTgNavigation)
                    .WithMany(p => p.TChiTietTours)
                    .HasForeignKey(d => d.MaTg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tChiTietTour_tThoiGian");

                entity.HasOne(d => d.MaTourNavigation)
                    .WithMany(p => p.TChiTietTours)
                    .HasForeignKey(d => d.MaTour)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tChiTietTour_tTour");
            });

            modelBuilder.Entity<TDiaDiem>(entity =>
            {
                entity.HasKey(e => e.MaDd);

                entity.ToTable("tDiaDiem");

                entity.Property(e => e.MaDd)
                    .ValueGeneratedNever()
                    .HasColumnName("MaDD");
            });

            modelBuilder.Entity<THoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.ToTable("tHoaDon");

                entity.Property(e => e.MaHd)
                    .ValueGeneratedNever()
                    .HasColumnName("MaHD");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.NgayHd)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayHD");

                entity.Property(e => e.PhuongThucThanhToan).HasMaxLength(50);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.THoaDons)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHoaDon_tKhachHang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.THoaDons)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHoaDon_tNhanVien");
            });

            modelBuilder.Entity<TKhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.ToTable("tKhachHang");

                entity.Property(e => e.MaKh)
                    .ValueGeneratedNever()
                    .HasColumnName("MaKH");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.LoaiKh)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiKH");

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TenKh).HasColumnName("TenKH");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.TKhachHangs)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK_tKhachHang_tUser");
            });

            modelBuilder.Entity<TKhachSan>(entity =>
            {
                entity.HasKey(e => e.MaKs);

                entity.ToTable("tKhachSan");

                entity.Property(e => e.MaKs)
                    .ValueGeneratedNever()
                    .HasColumnName("MaKS");

                entity.Property(e => e.TenKs).HasColumnName("TenKS");
            });

            modelBuilder.Entity<TLoaiTour>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.ToTable("tLoaiTour");

                entity.Property(e => e.MaLoai).ValueGeneratedNever();

                entity.Property(e => e.LoaiTour).HasMaxLength(50);
            });

            modelBuilder.Entity<TNguoi>(entity =>
            {
                entity.HasKey(e => e.MaNguoi);

                entity.ToTable("tNguoi");

                entity.Property(e => e.MaNguoi).ValueGeneratedNever();

                entity.Property(e => e.LoaiNguoi).HasMaxLength(300);
            });

            modelBuilder.Entity<TNhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.ToTable("tNhanVien");

                entity.Property(e => e.MaNv)
                    .ValueGeneratedNever()
                    .HasColumnName("MaNV");

                entity.Property(e => e.ChucVu).HasMaxLength(50);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt1).HasColumnName("SDT1");

                entity.Property(e => e.Sdt2).HasColumnName("SDT2");

                entity.Property(e => e.TenNv).HasColumnName("TenNV");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.TNhanViens)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tNhanVien_tUser");
            });

            modelBuilder.Entity<TPhuongTien>(entity =>
            {
                entity.HasKey(e => e.MaPt);

                entity.ToTable("tPhuongTien");

                entity.Property(e => e.MaPt)
                    .ValueGeneratedNever()
                    .HasColumnName("MaPT");

                entity.Property(e => e.LoaiPt)
                    .HasMaxLength(50)
                    .HasColumnName("LoaiPT");
            });

            modelBuilder.Entity<TSoCho>(entity =>
            {
                entity.HasKey(e => e.MaSoCho);

                entity.ToTable("tSoCho");

                entity.Property(e => e.MaSoCho).ValueGeneratedNever();
            });

            modelBuilder.Entity<TThoiGian>(entity =>
            {
                entity.HasKey(e => e.MaTg);

                entity.ToTable("tThoiGian");

                entity.Property(e => e.MaTg)
                    .ValueGeneratedNever()
                    .HasColumnName("MaTG");

                entity.Property(e => e.ThoiGian).HasMaxLength(50);
            });

            modelBuilder.Entity<TTour>(entity =>
            {
                entity.HasKey(e => e.MaTour);

                entity.ToTable("tTour");

                entity.Property(e => e.MaTour).ValueGeneratedNever();

                entity.Property(e => e.MaDd).HasColumnName("MaDD");

                entity.Property(e => e.MaKs).HasColumnName("MaKS");

                entity.Property(e => e.MaPt).HasColumnName("MaPT");

                entity.Property(e => e.MaTg).HasColumnName("MaTG");

                entity.Property(e => e.NgayKh)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKH");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKT");

                entity.HasOne(d => d.MaDdNavigation)
                    .WithMany(p => p.TTours)
                    .HasForeignKey(d => d.MaDd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTour_tDiaDiem");

                entity.HasOne(d => d.MaKsNavigation)
                    .WithMany(p => p.TTours)
                    .HasForeignKey(d => d.MaKs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTour_tKhachSan");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.TTours)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTour_tLoaiTour");

                entity.HasOne(d => d.MaNguoiNavigation)
                    .WithMany(p => p.TTours)
                    .HasForeignKey(d => d.MaNguoi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTour_tNguoi");

                entity.HasOne(d => d.MaPtNavigation)
                    .WithMany(p => p.TTours)
                    .HasForeignKey(d => d.MaPt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tTour_tPhuongTien");
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("tUser");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.LoaiUser).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
