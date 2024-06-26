﻿// <auto-generated />
using ContactsWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactsWebApp.Migrations
{
    [DbContext(typeof(ContactsContext))]
    partial class ContactsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContactsWebApp.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "101 Main St, West Des Moines, IA 50266",
                            Name = "Nat Ferguson",
                            Note = "Best Friend",
                            PhoneNumber = "5151239876"
                        },
                        new
                        {
                            Id = 2,
                            Address = "1000 Ghost Rider St, West Des Moines, IA 50266",
                            Name = "Johnny Cash",
                            Note = "Greatest country singer",
                            PhoneNumber = "5159871234"
                        },
                        new
                        {
                            Id = 3,
                            Address = "2525 Broadway, Metropolis, NY 10025",
                            Name = "Clark Kent",
                            Note = "Don't need any introduction",
                            PhoneNumber = "5151020304"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
