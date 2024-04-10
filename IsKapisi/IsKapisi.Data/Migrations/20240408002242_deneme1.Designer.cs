﻿// <auto-generated />
using System;
using IsKapisi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IsKapisi.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240408002242_deneme1")]
    partial class deneme1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.15");

            modelBuilder.Entity("IsKapisi.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9489),
                            Description = "Eğitim Kategorisi",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9504),
                            Name = "Öğretmen",
                            Url = "ogretmen"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9510),
                            Description = "Hukuk",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9510),
                            Name = "Avukat",
                            Url = "avukat"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9512),
                            Description = "Bilgi İşlem",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9512),
                            Name = "Yazılım Geliştirme Uzmanı",
                            Url = "yazilim-geliştirme-uzmani"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9513),
                            Description = "İnsan Kaynaklari Uzmani",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9514),
                            Name = "İnsan Kaynaklari Uzmanı",
                            Url = "insan-kaynaklari-uzmani"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9515),
                            Description = "Developer",
                            IsActive = true,
                            IsDelete = false,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 832, DateTimeKind.Local).AddTicks(9515),
                            Name = "Back-End Developer",
                            Url = "back-end-developer"
                        });
                });

            modelBuilder.Entity("IsKapisi.Entity.CategoryJob", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JobId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId", "JobId");

                    b.HasIndex("JobId");

                    b.ToTable("CategoryJob", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            JobId = 1
                        },
                        new
                        {
                            CategoryId = 4,
                            JobId = 2
                        },
                        new
                        {
                            CategoryId = 2,
                            JobId = 3
                        },
                        new
                        {
                            CategoryId = 3,
                            JobId = 4
                        },
                        new
                        {
                            CategoryId = 5,
                            JobId = 4
                        },
                        new
                        {
                            CategoryId = 5,
                            JobId = 5
                        },
                        new
                        {
                            CategoryId = 3,
                            JobId = 6
                        },
                        new
                        {
                            CategoryId = 3,
                            JobId = 7
                        },
                        new
                        {
                            CategoryId = 3,
                            JobId = 8
                        },
                        new
                        {
                            CategoryId = 5,
                            JobId = 8
                        },
                        new
                        {
                            CategoryId = 4,
                            JobId = 9
                        },
                        new
                        {
                            CategoryId = 3,
                            JobId = 10
                        },
                        new
                        {
                            CategoryId = 1,
                            JobId = 11
                        });
                });

            modelBuilder.Entity("IsKapisi.Entity.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Jobs", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(363),
                            ImageUrl = "1.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(365),
                            Name = "Kimya Öğretmeni",
                            Properties = "Deneyimli Öğretmen",
                            Url = "kimya-ogretmen"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(372),
                            ImageUrl = "2.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(373),
                            Name = "İnsan Kaynakları Uzmanı",
                            Properties = " En az 3 yıl tecrübeli",
                            Url = "insan-kaynaklari-uzmani"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(374),
                            ImageUrl = "3.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(375),
                            Name = "Kıdemli Avukat",
                            Properties = "Deneyimi 5 - 10 yıl arası",
                            Url = "avukat"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(376),
                            ImageUrl = "4.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(377),
                            Name = "Yazılım Destek Elemanı",
                            Properties = "Tecrübeli/Tecrübesiz",
                            Url = "yazilim-destek-uzmani"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(378),
                            ImageUrl = "5.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(378),
                            Name = "Backend Developer (İstanbul-Ankara-İzmir)",
                            Properties = "  En az 3 yıl deneyimli,",
                            Url = "back-end-gelistirici"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(380),
                            ImageUrl = "6.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(380),
                            Name = "React Front-End Geliştirici",
                            Properties = "2 - 6 yıl arası",
                            Url = "react-front-end"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(381),
                            ImageUrl = "7.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(382),
                            Name = "React Native Developer",
                            Properties = "En az 3 yıl deneyimli",
                            Url = "react-native"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(383),
                            ImageUrl = "8.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = false,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(383),
                            Name = "Data Science Professionals - Discovery (İstanbul, Ankara, İzmir)",
                            Properties = "Uzman",
                            Url = "data-science"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(385),
                            ImageUrl = "9.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(385),
                            Name = "İdari İşler Profesyonelleri ",
                            Properties = "Minimum 7 yıl idari işler alanında deneyimli",
                            Url = "idari-isler"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(386),
                            ImageUrl = "10.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(387),
                            Name = "Front-end Developer ",
                            Properties = "Minimum 7 yıl react üzerinde çalışmış",
                            Url = "idari-isler"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(388),
                            ImageUrl = "11.png",
                            IsActive = true,
                            IsDelete = false,
                            IsHome = true,
                            ModifiedDate = new DateTime(2024, 4, 8, 3, 22, 42, 833, DateTimeKind.Local).AddTicks(389),
                            Name = "Müzük Öğretmeni",
                            Properties = "En az 10 yıl tecrübeli",
                            Url = "muzik-ogretmen"
                        });
                });

            modelBuilder.Entity("IsKapisi.Entity.CategoryJob", b =>
                {
                    b.HasOne("IsKapisi.Entity.Category", "Category")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IsKapisi.Entity.Job", "Job")
                        .WithMany("CategoryJobs")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("IsKapisi.Entity.Category", b =>
                {
                    b.Navigation("CategoryProducts");
                });

            modelBuilder.Entity("IsKapisi.Entity.Job", b =>
                {
                    b.Navigation("CategoryJobs");
                });
#pragma warning restore 612, 618
        }
    }
}
