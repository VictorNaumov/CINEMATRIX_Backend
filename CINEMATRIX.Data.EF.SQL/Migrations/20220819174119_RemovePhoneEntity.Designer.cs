﻿// <auto-generated />
using System;
using CINEMATRIX.Data.EF.SQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CINEMATRIX.Data.EF.SQL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220819174119_RemovePhoneEntity")]
    partial class RemovePhoneEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Food", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UrlPicture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Hall", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Projector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Screen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenResolution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoundSystem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.PersonalData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonalData");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Poster", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsRentMovie")
                        .HasColumnType("bit");

                    b.Property<long>("MovieId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Posters");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Seat", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("HallId")
                        .HasColumnType("bigint");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.Property<long>("SeatTypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("SeatTypeId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.SeatType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("SeatTypes");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Session", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("HallId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<long>("MovieId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Ticket", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("SeatId")
                        .HasColumnType("bigint");

                    b.Property<long>("SessionId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SeatId");

                    b.HasIndex("SessionId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PersonalDataId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalDataId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Seat", b =>
                {
                    b.HasOne("CINEMATRIX.Data.Domain.Models.Hall", "Hall")
                        .WithMany("Seats")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CINEMATRIX.Data.Domain.Models.SeatType", "SeatType")
                        .WithMany()
                        .HasForeignKey("SeatTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");

                    b.Navigation("SeatType");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Session", b =>
                {
                    b.HasOne("CINEMATRIX.Data.Domain.Models.Hall", "Hall")
                        .WithMany("Sessions")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Ticket", b =>
                {
                    b.HasOne("CINEMATRIX.Data.Domain.Models.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CINEMATRIX.Data.Domain.Models.Session", "Session")
                        .WithMany("Tickets")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Seat");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.User", b =>
                {
                    b.HasOne("CINEMATRIX.Data.Domain.Models.PersonalData", "PersonalData")
                        .WithMany()
                        .HasForeignKey("PersonalDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CINEMATRIX.Data.Domain.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalData");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Hall", b =>
                {
                    b.Navigation("Seats");

                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("CINEMATRIX.Data.Domain.Models.Session", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
