using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WpfApp6.Models;

namespace WpfApp6.DbConnector;

public partial class Kolokolcev223ToysShopDb : DbContext
{
    public Kolokolcev223ToysShopDb()
    {
    }

    public Kolokolcev223ToysShopDb(DbContextOptions<Kolokolcev223ToysShopDb> options)
        : base(options)
    {
    }

    public virtual DbSet<Accident> Accidents { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<DriveHistory> DriveHistories { get; set; }

    public virtual DbSet<Parking> Parkings { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }


    public virtual DbSet<User> Users { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=83.147.246.87;Database=kolokolcev_223_toys_shop_db;Username=kolokolcev_223_toys_shop;Password=12345");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accident>(entity =>
        {
            entity.HasKey(e => e.AccidentsId).HasName("Accidents_pk");

            entity.Property(e => e.AccidentsId).HasColumnName("accidentsID");
            entity.Property(e => e.CarId).HasColumnName("carID");
            entity.Property(e => e.Damage)
                .HasMaxLength(100)
                .HasColumnName("damage");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Report)
                .HasMaxLength(300)
                .HasColumnName("report");

            entity.HasOne(d => d.Car).WithMany(p => p.Accidents)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Accidents_Cars__carID_fk");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("Cars_pk");

            entity.Property(e => e.CarId).HasColumnName("carID");
            entity.Property(e => e.Fuel).HasColumnName("fuel");
            entity.Property(e => e.Mileage).HasColumnName("mileage");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .HasColumnName("model");
            entity.Property(e => e.Price)
                .HasPrecision(8, 2)
                .HasColumnName("price");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasColumnName("status");
        });

        modelBuilder.Entity<DriveHistory>(entity =>
        {
            entity.HasKey(e => e.DriveHistoryId).HasName("DriveHistory_pk");

            entity.ToTable("DriveHistory");

            entity.Property(e => e.DriveHistoryId).HasColumnName("driveHistoryID");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Route)
                .HasMaxLength(100)
                .HasColumnName("route");
            entity.Property(e => e.TotalPrice)
                .HasPrecision(8, 2)
                .HasColumnName("total_price");
            entity.Property(e => e.TripDuration).HasColumnName("trip_duration");
            entity.Property(e => e.UserId).HasColumnName("userID");

            entity.HasOne(d => d.User).WithMany(p => p.DriveHistories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DriveHistory_User_userID_fk");
        });

        modelBuilder.Entity<Parking>(entity =>
        {
            entity.HasKey(e => e.ParkingId).HasName("Parking_pk");

            entity.ToTable("Parking");

            entity.Property(e => e.ParkingId).HasColumnName("parkingID");
            entity.Property(e => e.Adress)
                .HasMaxLength(50)
                .HasColumnName("adress");
            entity.Property(e => e.CarId).HasColumnName("carID");
            entity.Property(e => e.ParkingPrice)
                .HasPrecision(8, 2)
                .HasColumnName("parking_price");
            entity.Property(e => e.ParkingTime).HasColumnName("parking_time");

            entity.HasOne(d => d.Car).WithMany(p => p.Parkings)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Parking_Cars_carID_fk");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("Payment_pk");

            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId).HasColumnName("paymentID");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(50)
                .HasColumnName("payment_type");
            entity.Property(e => e.SumPayment)
                .HasPrecision(8, 2)
                .HasColumnName("sum_payment");
            entity.Property(e => e.UserId).HasColumnName("userID");

            entity.HasOne(d => d.User).WithMany(p => p.Payments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Payment_User_userID_fk");
        });

        //modelBuilder.Entity<Product>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("products_pk");

        //    entity.ToTable("products");

        //    entity.Property(e => e.Id).HasColumnName("id");
        //    entity.Property(e => e.Amount).HasColumnName("amount");
        //    entity.Property(e => e.Name)
        //        .HasMaxLength(50)
        //        .HasColumnName("name");
        //    entity.Property(e => e.Price).HasColumnName("price");
        //    entity.Property(e => e.Rating).HasColumnName("rating");
        //});

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("User_pk");

            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.BirthDate).HasColumnName("birth_date");
            entity.Property(e => e.EMail)
                .HasMaxLength(50)
                .HasColumnName("e_mail");
            entity.Property(e => e.FName)
                .HasMaxLength(20)
                .HasColumnName("f_name");
            entity.Property(e => e.LName)
                .HasMaxLength(30)
                .HasColumnName("l_name");
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .HasColumnName("sex");
        }); }

    //    modelBuilder.Entity<Vkuso4kaSotrudniki>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("vkuso4ka_sotrudniki_pk");

    //        entity.ToTable("vkuso4ka_sotrudniki");

    //        entity.Property(e => e.Id).HasColumnName("id");
    //        entity.Property(e => e.Age).HasColumnName("age");
    //        entity.Property(e => e.Name)
    //            .HasMaxLength(50)
    //            .HasColumnName("name");
    //        entity.Property(e => e.Rating).HasColumnName("rating");
    //        entity.Property(e => e.Salary).HasColumnName("salary");
    //        entity.Property(e => e.Sex).HasColumnName("sex");
    //        entity.Property(e => e.Smena).HasColumnName("smena");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
