﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Olympics.Data;

#nullable disable

namespace Olympics.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240707202255_AddFavorites")]
    partial class AddFavorites
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Olympics.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SportTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("SportTypeId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryCode = "CA",
                            GameId = 2,
                            Name = "Canada",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            CountryCode = "SE",
                            GameId = 2,
                            Name = "Sweden",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            CountryCode = "GB",
                            GameId = 2,
                            Name = "Great Britain",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 4,
                            CountryCode = "JM",
                            GameId = 2,
                            Name = "Jamaica",
                            SportTypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            CountryCode = "IT",
                            GameId = 2,
                            Name = "Italy",
                            SportTypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            CountryCode = "JP",
                            GameId = 2,
                            Name = "Japan",
                            SportTypeId = 2
                        },
                        new
                        {
                            Id = 7,
                            CountryCode = "DE",
                            GameId = 1,
                            Name = "Germany",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 8,
                            CountryCode = "CN",
                            GameId = 1,
                            Name = "China",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 9,
                            CountryCode = "MX",
                            GameId = 1,
                            Name = "Mexico",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 10,
                            CountryCode = "BR",
                            GameId = 1,
                            Name = "Brazil",
                            SportTypeId = 2
                        },
                        new
                        {
                            Id = 11,
                            CountryCode = "NL",
                            GameId = 1,
                            Name = "Netherlands",
                            SportTypeId = 2
                        },
                        new
                        {
                            Id = 12,
                            CountryCode = "US",
                            GameId = 1,
                            Name = "USA",
                            SportTypeId = 2
                        },
                        new
                        {
                            Id = 13,
                            CountryCode = "TH",
                            GameId = 3,
                            Name = "Thailand",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 14,
                            CountryCode = "UY",
                            GameId = 3,
                            Name = "Uruguay",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 15,
                            CountryCode = "UA",
                            GameId = 3,
                            Name = "Ukraine",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 16,
                            CountryCode = "AT",
                            GameId = 3,
                            Name = "Austria",
                            SportTypeId = 2
                        },
                        new
                        {
                            Id = 17,
                            CountryCode = "PK",
                            GameId = 3,
                            Name = "Pakistan",
                            SportTypeId = 2
                        },
                        new
                        {
                            Id = 18,
                            CountryCode = "ZW",
                            GameId = 3,
                            Name = "Zimbabwe",
                            SportTypeId = 2
                        },
                        new
                        {
                            Id = 19,
                            CountryCode = "FR",
                            GameId = 4,
                            Name = "France",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 20,
                            CountryCode = "CY",
                            GameId = 4,
                            Name = "Cyprus",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 21,
                            CountryCode = "RU",
                            GameId = 4,
                            Name = "Russia",
                            SportTypeId = 1
                        },
                        new
                        {
                            Id = 22,
                            CountryCode = "FI",
                            GameId = 4,
                            Name = "Finland",
                            SportTypeId = 2
                        },
                        new
                        {
                            Id = 23,
                            CountryCode = "SK",
                            GameId = 4,
                            Name = "Slovakia",
                            SportTypeId = 2
                        },
                        new
                        {
                            Id = 24,
                            CountryCode = "PT",
                            GameId = 4,
                            Name = "Portugal",
                            SportTypeId = 2
                        });
                });

            modelBuilder.Entity("Olympics.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Summer Olympics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Winter Olympics"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Paralympics"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("Olympics.Models.SportType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SportTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Indoor"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Outdoor"
                        });
                });

            modelBuilder.Entity("Olympics.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PointValue")
                        .HasColumnType("int");

                    b.Property<int>("SprintNumber")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Olympics.Models.Country", b =>
                {
                    b.HasOne("Olympics.Models.Game", "Game")
                        .WithMany("Countries")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Olympics.Models.SportType", "SportType")
                        .WithMany("Countries")
                        .HasForeignKey("SportTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("SportType");
                });

            modelBuilder.Entity("Olympics.Models.Game", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("Olympics.Models.SportType", b =>
                {
                    b.Navigation("Countries");
                });
#pragma warning restore 612, 618
        }
    }
}
