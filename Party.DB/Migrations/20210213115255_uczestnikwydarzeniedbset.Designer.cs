﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Party.DB;

namespace Party.DB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210213115255_uczestnikwydarzeniedbset")]
    partial class uczestnikwydarzeniedbset
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Party.DB.Kategoria", b =>
                {
                    b.Property<int>("IdKategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Nazwa")
                        .HasColumnType("int");

                    b.Property<int?>("WydarzenieIdWydarzenie")
                        .HasColumnType("int");

                    b.HasKey("IdKategoria");

                    b.HasIndex("WydarzenieIdWydarzenie");

                    b.ToTable("Kategoria");
                });

            modelBuilder.Entity("Party.DB.Kometaz", b =>
                {
                    b.Property<int>("IdKometaz")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int?>("WydarzenieIdWydarzenie")
                        .HasColumnType("int");

                    b.HasKey("IdKometaz");

                    b.HasIndex("WydarzenieIdWydarzenie");

                    b.ToTable("Kometaz");
                });

            modelBuilder.Entity("Party.DB.Miejsce", b =>
                {
                    b.Property<int>("IdMiejsce")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Latitude")
                        .HasColumnType("int");

                    b.Property<int>("Longitude")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("IdMiejsce");

                    b.ToTable("Miejsca");
                });

            modelBuilder.Entity("Party.DB.Ocena", b =>
                {
                    b.Property<int>("IdOcena")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<int?>("WydarzenieIdWydarzenie")
                        .HasColumnType("int");

                    b.HasKey("IdOcena");

                    b.HasIndex("WydarzenieIdWydarzenie");

                    b.ToTable("Ocena");
                });

            modelBuilder.Entity("Party.DB.Preferencja", b =>
                {
                    b.Property<int>("IdPreferencja")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategoriaIdKategoria")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPreferencja");

                    b.HasIndex("KategoriaIdKategoria");

                    b.ToTable("Preferencja");
                });

            modelBuilder.Entity("Party.DB.PreferencjaUczestnika", b =>
                {
                    b.Property<int>("IdPreferencja")
                        .HasColumnType("int");

                    b.Property<int>("IdUczestnik")
                        .HasColumnType("int");

                    b.Property<int>("IdPreferencjaUczestnika")
                        .HasColumnType("int");

                    b.HasKey("IdPreferencja", "IdUczestnik");

                    b.HasIndex("IdUczestnik");

                    b.ToTable("PreferencjaUczestnika");
                });

            modelBuilder.Entity("Party.DB.Skarga", b =>
                {
                    b.Property<int>("IdSkarga")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WydarzenieIdWydarzenie")
                        .HasColumnType("int");

                    b.HasKey("IdSkarga");

                    b.HasIndex("WydarzenieIdWydarzenie");

                    b.ToTable("Skarga");
                });

            modelBuilder.Entity("Party.DB.Tworca", b =>
                {
                    b.Property<int>("IdTworca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NrKonta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("StanKonta")
                        .HasColumnType("float");

                    b.HasKey("IdTworca");

                    b.ToTable("Tworca");
                });

            modelBuilder.Entity("Party.DB.Uczestnik", b =>
                {
                    b.Property<int>("IdUczestnik")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUczestnik");

                    b.ToTable("Uczestnik");
                });

            modelBuilder.Entity("Party.DB.UczestnikWydarzenie", b =>
                {
                    b.Property<int>("IdWydarzenie")
                        .HasColumnType("int");

                    b.Property<int>("IdUczestnik")
                        .HasColumnType("int");

                    b.Property<int>("IdUczestnikWydarzenie")
                        .HasColumnType("int");

                    b.HasKey("IdWydarzenie", "IdUczestnik");

                    b.HasIndex("IdUczestnik");

                    b.ToTable("UczestnikWydarzenie");
                });

            modelBuilder.Entity("Party.DB.Wydarzenie", b =>
                {
                    b.Property<int>("IdWydarzenie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPrzeprowadzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TworcaIdTworca")
                        .HasColumnType("int");

                    b.Property<int>("Typ")
                        .HasColumnType("int");

                    b.HasKey("IdWydarzenie");

                    b.HasIndex("TworcaIdTworca");

                    b.ToTable("Wydarzenies");
                });

            modelBuilder.Entity("Party.DB.WydarzenieKategoria", b =>
                {
                    b.Property<int>("IdWydarzenie")
                        .HasColumnType("int");

                    b.Property<int>("IdKategoria")
                        .HasColumnType("int");

                    b.Property<int>("IdWydarzenieKategoria")
                        .HasColumnType("int");

                    b.HasKey("IdWydarzenie", "IdKategoria");

                    b.HasIndex("IdKategoria");

                    b.ToTable("WydarzenieKategoria");
                });

            modelBuilder.Entity("Party.DB.WydarzenieMiejsce", b =>
                {
                    b.Property<int>("IdWydarzenie")
                        .HasColumnType("int");

                    b.Property<int>("IdMiejsce")
                        .HasColumnType("int");

                    b.Property<int>("IdWydarzenieMiejsce")
                        .HasColumnType("int");

                    b.HasKey("IdWydarzenie", "IdMiejsce");

                    b.HasIndex("IdMiejsce");

                    b.ToTable("WydarzenieMiejsce");
                });

            modelBuilder.Entity("Party.DB.Kategoria", b =>
                {
                    b.HasOne("Party.DB.Wydarzenie", null)
                        .WithMany("Kategoria")
                        .HasForeignKey("WydarzenieIdWydarzenie");
                });

            modelBuilder.Entity("Party.DB.Kometaz", b =>
                {
                    b.HasOne("Party.DB.Wydarzenie", "Wydarzenie")
                        .WithMany("Kometaze")
                        .HasForeignKey("WydarzenieIdWydarzenie");
                });

            modelBuilder.Entity("Party.DB.Ocena", b =>
                {
                    b.HasOne("Party.DB.Wydarzenie", "Wydarzenie")
                        .WithMany("Oceny")
                        .HasForeignKey("WydarzenieIdWydarzenie");
                });

            modelBuilder.Entity("Party.DB.Preferencja", b =>
                {
                    b.HasOne("Party.DB.Kategoria", "Kategoria")
                        .WithMany()
                        .HasForeignKey("KategoriaIdKategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Party.DB.PreferencjaUczestnika", b =>
                {
                    b.HasOne("Party.DB.Preferencja", "IdPreferencjaNavigation")
                        .WithMany("PreferencjaUczestnika")
                        .HasForeignKey("IdPreferencja")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Party.DB.Uczestnik", "IdUczestnikNavigation")
                        .WithMany("PreferencjaUczestnika")
                        .HasForeignKey("IdUczestnik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Party.DB.Skarga", b =>
                {
                    b.HasOne("Party.DB.Wydarzenie", "Wydarzenie")
                        .WithMany("Skarga")
                        .HasForeignKey("WydarzenieIdWydarzenie");
                });

            modelBuilder.Entity("Party.DB.UczestnikWydarzenie", b =>
                {
                    b.HasOne("Party.DB.Uczestnik", "IdUczestnikNavigation")
                        .WithMany("UczestnikWydarzenie")
                        .HasForeignKey("IdUczestnik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Party.DB.Wydarzenie", "IdWydarzenieNavigation")
                        .WithMany("UczestnikWydarzenie")
                        .HasForeignKey("IdWydarzenie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Party.DB.Wydarzenie", b =>
                {
                    b.HasOne("Party.DB.Tworca", "Tworca")
                        .WithMany("Wydarzenia")
                        .HasForeignKey("TworcaIdTworca");
                });

            modelBuilder.Entity("Party.DB.WydarzenieKategoria", b =>
                {
                    b.HasOne("Party.DB.Kategoria", "IdKategoriaNavigation")
                        .WithMany("WydarzenieKategoria")
                        .HasForeignKey("IdKategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Party.DB.Wydarzenie", "IdWydarzenieNavigation")
                        .WithMany("WydarzenieKategoria")
                        .HasForeignKey("IdWydarzenie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Party.DB.WydarzenieMiejsce", b =>
                {
                    b.HasOne("Party.DB.Miejsce", "IdMiejsceNavigation")
                        .WithMany("WydarzenieMiejsce")
                        .HasForeignKey("IdMiejsce")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Party.DB.Wydarzenie", "IdWydarzenieNavigation")
                        .WithMany("WydarzenieMiejsce")
                        .HasForeignKey("IdWydarzenie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
