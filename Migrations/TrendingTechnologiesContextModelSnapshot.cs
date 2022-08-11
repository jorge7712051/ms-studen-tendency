﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ms_studentTendency.Context;

namespace ms_studentTendency.Migrations
{
    [DbContext(typeof(TrendingTechnologiesContext))]
    partial class TrendingTechnologiesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CategoryTechnology", b =>
                {
                    b.Property<int>("Categoriesid")
                        .HasColumnType("int");

                    b.Property<int>("Technologiesid")
                        .HasColumnType("int");

                    b.HasKey("Categoriesid", "Technologiesid");

                    b.HasIndex("Technologiesid");

                    b.ToTable("TechnologyCategory");
                });

            modelBuilder.Entity("TechnologyUser", b =>
                {
                    b.Property<int>("Technologiesid")
                        .HasColumnType("int");

                    b.Property<int>("Usersid")
                        .HasColumnType("int");

                    b.HasKey("Technologiesid", "Usersid");

                    b.HasIndex("Usersid");

                    b.ToTable("TechnologyUser");
                });

            modelBuilder.Entity("ms_studentTendency.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ms_studentTendency.Models.Technology", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<string>("technology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Technology");
                });

            modelBuilder.Entity("ms_studentTendency.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("privacyPolicy")
                        .HasColumnType("bit");

                    b.Property<string>("userEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("userLastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("userResponse")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ms_studentTendency.Models.UserResponse", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Userid")
                        .HasColumnType("int");

                    b.Property<string>("answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idUser")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Userid");

                    b.ToTable("UserResponse");
                });

            modelBuilder.Entity("CategoryTechnology", b =>
                {
                    b.HasOne("ms_studentTendency.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("Categoriesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ms_studentTendency.Models.Technology", null)
                        .WithMany()
                        .HasForeignKey("Technologiesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TechnologyUser", b =>
                {
                    b.HasOne("ms_studentTendency.Models.Technology", null)
                        .WithMany()
                        .HasForeignKey("Technologiesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ms_studentTendency.Models.User", null)
                        .WithMany()
                        .HasForeignKey("Usersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ms_studentTendency.Models.UserResponse", b =>
                {
                    b.HasOne("ms_studentTendency.Models.User", "User")
                        .WithMany("userResponses")
                        .HasForeignKey("Userid");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ms_studentTendency.Models.User", b =>
                {
                    b.Navigation("userResponses");
                });
#pragma warning restore 612, 618
        }
    }
}
