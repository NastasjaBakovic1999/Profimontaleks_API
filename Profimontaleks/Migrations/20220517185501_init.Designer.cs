﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Profimontaleks.Data;

namespace Profimontaleks.Migrations
{
    [DbContext(typeof(ProfimontaleksContext))]
    [Migration("20220517185501_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Profimontaleks.Data.Phase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("Phase");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Secenje i drenaza"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Celicno ojacavanje"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Varenje uglova"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Ciscenje i okivanje"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Sklapanje proizvoda"
                        });
                });

            modelBuilder.Entity("Profimontaleks.Data.PhaseStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("PhaseStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Zapoceto"
                        },
                        new
                        {
                            Id = 2,
                            Description = "U toku"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Na cekanju"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Otkazano"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Zavrseno"
                        });
                });

            modelBuilder.Entity("Profimontaleks.Data.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("Position");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Secenje"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Brusenje"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Varenje"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Ciscenje"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Sklapanje"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Pakovanje"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Prijem"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Razvozenje"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Administracija"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Menadzment 1. nivoa"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Menadzment 2. nivoa"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Menadzment 3. nivoa"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Utovar"
                        });
                });

            modelBuilder.Entity("Profimontaleks.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("GlassThickness")
                        .HasColumnType("decimal(38,17)")
                        .HasColumnName("GlassThickness");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(38,17)")
                        .HasColumnName("Height");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(38,17)")
                        .HasColumnName("Length");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int")
                        .HasColumnName("ProductTypeId");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(38,17)")
                        .HasColumnName("Weight");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GlassThickness = 0.18m,
                            Height = 80m,
                            Length = 49m,
                            ProductTypeId = 1,
                            Weight = 2.2m
                        },
                        new
                        {
                            Id = 2,
                            GlassThickness = 0.18m,
                            Height = 80m,
                            Length = 98m,
                            ProductTypeId = 2,
                            Weight = 4.5m
                        },
                        new
                        {
                            Id = 3,
                            GlassThickness = 0.18m,
                            Height = 70m,
                            Length = 49m,
                            ProductTypeId = 3,
                            Weight = 2.2m
                        },
                        new
                        {
                            Id = 4,
                            GlassThickness = 0.18m,
                            Height = 70m,
                            Length = 98m,
                            ProductTypeId = 2,
                            Weight = 4.5m
                        },
                        new
                        {
                            Id = 5,
                            GlassThickness = 0m,
                            Height = 130m,
                            Length = 102m,
                            ProductTypeId = 6,
                            Weight = 22m
                        },
                        new
                        {
                            Id = 6,
                            GlassThickness = 0m,
                            Height = 133m,
                            Length = 109m,
                            ProductTypeId = 7,
                            Weight = 23m
                        },
                        new
                        {
                            Id = 7,
                            GlassThickness = 0m,
                            Height = 130m,
                            Length = 94m,
                            ProductTypeId = 6,
                            Weight = 20m
                        },
                        new
                        {
                            Id = 8,
                            GlassThickness = 0m,
                            Height = 80m,
                            Length = 104m,
                            ProductTypeId = 12,
                            Weight = 6.3m
                        },
                        new
                        {
                            Id = 9,
                            GlassThickness = 0m,
                            Height = 110m,
                            Length = 104m,
                            ProductTypeId = 12,
                            Weight = 7.1m
                        },
                        new
                        {
                            Id = 10,
                            GlassThickness = 0m,
                            Height = 80m,
                            Length = 49m,
                            ProductTypeId = 12,
                            Weight = 4.6m
                        });
                });

            modelBuilder.Entity("Profimontaleks.Data.ProductCardboard", b =>
                {
                    b.Property<int>("PCCNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PCCNumber")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductId");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PCCNumber");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductCardboard");
                });

            modelBuilder.Entity("Profimontaleks.Data.ProductCardboardPhase", b =>
                {
                    b.Property<int>("PhaseId")
                        .HasColumnType("int")
                        .HasColumnName("PhaseId");

                    b.Property<int>("PCCNumber")
                        .HasColumnType("int")
                        .HasColumnName("ProductCardboardId");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("StatusId");

                    b.HasKey("PhaseId", "PCCNumber");

                    b.HasIndex("PCCNumber");

                    b.HasIndex("StatusId");

                    b.ToTable("ProductCardboardPhase");
                });

            modelBuilder.Entity("Profimontaleks.Data.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Colour")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Colour");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("ProductType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Jednokrilni PVC prozor"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dvokrilni PVC prozor"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Jednokrilni ALU prozor"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Dvokrilni ALU prozor"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Sobna PVC vrata"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Sobna ALU vrata"
                        },
                        new
                        {
                            Id = 7,
                            Colour = "Braon",
                            Description = "PVC ulazna vrata Trocal 70"
                        },
                        new
                        {
                            Id = 8,
                            Colour = "Crna",
                            Description = "PVC ulazna vrata Trocal 76"
                        },
                        new
                        {
                            Id = 9,
                            Colour = "Bela",
                            Description = "PVC ulazna vrata Trocal 88"
                        },
                        new
                        {
                            Id = 10,
                            Colour = "Bordo",
                            Description = "ALU ulazna vrata ETEM E-45"
                        },
                        new
                        {
                            Id = 11,
                            Colour = "Braon",
                            Description = "ALU ulazna vrata ALUMIL 60"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Rolo komarnik"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Fiksni komarnik"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Americki komarnik"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Plisirani komarnik"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Venecijaner 25mm"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Venecijaner 16mm"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Venecijaner 16x25mm"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Venecijaner 50mm"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Okapnica"
                        },
                        new
                        {
                            Id = 21,
                            Description = "Podprozorska daska"
                        },
                        new
                        {
                            Id = 22,
                            Description = "ALU roletne"
                        },
                        new
                        {
                            Id = 23,
                            Description = "PVC roletne"
                        });
                });

            modelBuilder.Entity("Profimontaleks.Data.Worker", b =>
                {
                    b.Property<int>("JMBG")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Coefficient")
                        .HasColumnType("decimal(38,17)")
                        .HasColumnName("Coefficient");

                    b.Property<DateTime>("DateOfEmployment")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameAndSurname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("PositionId")
                        .HasColumnType("int")
                        .HasColumnName("PositionId");

                    b.Property<int>("WorkerStatusId")
                        .HasColumnType("int")
                        .HasColumnName("WorkerStatusId");

                    b.HasKey("JMBG");

                    b.HasIndex("PositionId");

                    b.HasIndex("WorkerStatusId");

                    b.ToTable("Worker");
                });

            modelBuilder.Entity("Profimontaleks.Data.WorkerStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("Description");

                    b.HasKey("Id");

                    b.ToTable("WorkerStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Privremeno"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Za stalno"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Praksa"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Pripravnistvo"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Zamena"
                        });
                });

            modelBuilder.Entity("Profimontaleks.Data.Product", b =>
                {
                    b.HasOne("Profimontaleks.Data.ProductType", "Type")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Profimontaleks.Data.ProductCardboard", b =>
                {
                    b.HasOne("Profimontaleks.Data.Product", "Product")
                        .WithOne("ProductCardboard")
                        .HasForeignKey("Profimontaleks.Data.ProductCardboard", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Profimontaleks.Data.ProductCardboardPhase", b =>
                {
                    b.HasOne("Profimontaleks.Data.ProductCardboard", "ProductCardboard")
                        .WithMany("Phases")
                        .HasForeignKey("PCCNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Profimontaleks.Data.Phase", null)
                        .WithMany("ProductCardboards")
                        .HasForeignKey("PhaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Profimontaleks.Data.PhaseStatus", "Status")
                        .WithMany("Phases")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductCardboard");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Profimontaleks.Data.Worker", b =>
                {
                    b.HasOne("Profimontaleks.Data.Position", "Position")
                        .WithMany("Workers")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Profimontaleks.Data.WorkerStatus", "Status")
                        .WithMany("Workers")
                        .HasForeignKey("WorkerStatusId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Position");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("Profimontaleks.Data.Phase", b =>
                {
                    b.Navigation("ProductCardboards");
                });

            modelBuilder.Entity("Profimontaleks.Data.PhaseStatus", b =>
                {
                    b.Navigation("Phases");
                });

            modelBuilder.Entity("Profimontaleks.Data.Position", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("Profimontaleks.Data.Product", b =>
                {
                    b.Navigation("ProductCardboard");
                });

            modelBuilder.Entity("Profimontaleks.Data.ProductCardboard", b =>
                {
                    b.Navigation("Phases");
                });

            modelBuilder.Entity("Profimontaleks.Data.ProductType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Profimontaleks.Data.WorkerStatus", b =>
                {
                    b.Navigation("Workers");
                });
#pragma warning restore 612, 618
        }
    }
}
