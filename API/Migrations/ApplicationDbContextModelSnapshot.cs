﻿// <auto-generated />
using MangaAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MangaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MangaAPI.Collection", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idCollection");

                    b.Property<int>("idLivre")
                        .HasColumnType("int");

                    b.Property<int>("idTome")
                        .HasColumnType("int");

                    b.Property<int>("idUtilisateur")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idLivre");

                    b.HasIndex("idTome");

                    b.HasIndex("idUtilisateur");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("MangaAPI.Livre", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idLivre");

                    b.Property<string>("edition")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("prix")
                        .HasColumnType("double");

                    b.Property<string>("resumer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Livres");
                });

            modelBuilder.Entity("MangaAPI.Tome", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idTome");

                    b.Property<int>("idLivre")
                        .HasColumnType("int");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("numtome")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idLivre");

                    b.ToTable("Tomes");
                });

            modelBuilder.Entity("MangaAPI.Utilisateur", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("idUtilisateur");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("MangaAPI.Collection", b =>
                {
                    b.HasOne("MangaAPI.Livre", "Livre")
                        .WithMany()
                        .HasForeignKey("idLivre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MangaAPI.Tome", "Tome")
                        .WithMany()
                        .HasForeignKey("idTome")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MangaAPI.Utilisateur", "Utilisateur")
                        .WithMany()
                        .HasForeignKey("idUtilisateur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");

                    b.Navigation("Tome");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("MangaAPI.Tome", b =>
                {
                    b.HasOne("MangaAPI.Livre", "Livre")
                        .WithMany()
                        .HasForeignKey("idLivre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");
                });
#pragma warning restore 612, 618
        }
    }
}
