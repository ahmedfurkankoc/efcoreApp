﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using efcoreApp.Data;

#nullable disable

namespace efcoreApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("efcoreApp.Data.Kurs", b =>
                {
                    b.Property<int>("KursId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Baslik")
                        .HasColumnType("TEXT");

                    b.HasKey("KursId");

                    b.ToTable("Kurslar");
                });

            modelBuilder.Entity("efcoreApp.Data.KursKayit", b =>
                {
                    b.Property<int>("KayitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("KursId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OgrenciKimlik")
                        .HasColumnType("INTEGER");

                    b.HasKey("KayitId");

                    b.ToTable("KursKayitlari");
                });

            modelBuilder.Entity("efcoreApp.Data.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciKimlik")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgrenciAd")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgrenciSoyad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("OgrenciKimlik");

                    b.ToTable("Ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}
