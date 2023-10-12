﻿// <auto-generated />
using Letra.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Letra.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Letra.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Letra.Models.Ekibimiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UyeAdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UyeFotograf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UyeGithub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UyeLinkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UyeMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UyePozisyon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ekibimiz");
                });

            modelBuilder.Entity("Letra.Models.Hakkimizda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hakkimizda");
                });

            modelBuilder.Entity("Letra.Models.Oyunlarimiz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OyunAciklamasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OyunAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OyunFotografi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OyunLinki")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Oyunlarimiz");
                });

            modelBuilder.Entity("Letra.Models.İletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailAdresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mesaj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("İletisim");
                });
#pragma warning restore 612, 618
        }
    }
}
