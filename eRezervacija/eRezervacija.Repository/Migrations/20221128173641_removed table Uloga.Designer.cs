﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eRezervacija.Repository;

#nullable disable

namespace eRezervacija.Repository.Migrations
{
    [DbContext(typeof(eRezervacijaDbContext))]
    [Migration("20221128173641_removed table Uloga")]
    partial class removedtableUloga
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eRezervacija.Core.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Admini");
                });

            modelBuilder.Entity("eRezervacija.Core.Autentikacija.AutentifikacijaToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Vrijednost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ipAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikID");

                    b.ToTable("AutentifikacijaTokeni");
                });

            modelBuilder.Entity("eRezervacija.Core.Drzava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drzave");
                });

            modelBuilder.Entity("eRezervacija.Core.Gost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Gosti");
                });

            modelBuilder.Entity("eRezervacija.Core.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gradovi");
                });

            modelBuilder.Entity("eRezervacija.Core.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Broj_telefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPromjene")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datum_rodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uloga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("eRezervacija.Core.Vlasnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrojBankovnogRacuna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojLicneKarte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<byte[]>("VlasnickiList")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Vlasnici");
                });

            modelBuilder.Entity("eRezervacija.Core.Admin", b =>
                {
                    b.HasOne("eRezervacija.Core.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("eRezervacija.Core.Autentikacija.AutentifikacijaToken", b =>
                {
                    b.HasOne("eRezervacija.Core.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("eRezervacija.Core.Gost", b =>
                {
                    b.HasOne("eRezervacija.Core.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("eRezervacija.Core.Vlasnik", b =>
                {
                    b.HasOne("eRezervacija.Core.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });
#pragma warning restore 612, 618
        }
    }
}
