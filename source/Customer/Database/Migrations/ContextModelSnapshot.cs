﻿// <auto-generated />
using Microservices.Customer.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Microservices.Customer.Database.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microservices.Customer.Domain.CustomerEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Customers","Customers");

                    b.HasData(
                        new
                        {
                            Id = 1L
                        },
                        new
                        {
                            Id = 2L
                        },
                        new
                        {
                            Id = 3L
                        });
                });

            modelBuilder.Entity("Microservices.Customer.Domain.CustomerEntity", b =>
                {
                    b.OwnsOne("Microservices.Shared.Domain.Email", "Email", b1 =>
                        {
                            b1.Property<long>("CustomerEntityId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnName("Email")
                                .HasColumnType("nvarchar(250)")
                                .HasMaxLength(250);

                            b1.HasKey("CustomerEntityId");

                            b1.HasIndex("Value")
                                .IsUnique()
                                .HasFilter("[Email] IS NOT NULL");

                            b1.ToTable("Customers");

                            b1.WithOwner()
                                .HasForeignKey("CustomerEntityId");

                            b1.HasData(
                                new
                                {
                                    CustomerEntityId = 1L,
                                    Value = "albert.einstein@email.com"
                                },
                                new
                                {
                                    CustomerEntityId = 2L,
                                    Value = "stephen.hawking@email.com"
                                },
                                new
                                {
                                    CustomerEntityId = 3L,
                                    Value = "ada.lovelace@email.com"
                                });
                        });

                    b.OwnsOne("Microservices.Shared.Domain.Name", "Name", b1 =>
                        {
                            b1.Property<long>("CustomerEntityId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("bigint")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Forename")
                                .IsRequired()
                                .HasColumnName("Forename")
                                .HasColumnType("nvarchar(250)")
                                .HasMaxLength(250);

                            b1.Property<string>("Surname")
                                .IsRequired()
                                .HasColumnName("Surname")
                                .HasColumnType("nvarchar(250)")
                                .HasMaxLength(250);

                            b1.HasKey("CustomerEntityId");

                            b1.ToTable("Customers");

                            b1.WithOwner()
                                .HasForeignKey("CustomerEntityId");

                            b1.HasData(
                                new
                                {
                                    CustomerEntityId = 1L,
                                    Forename = "Albert",
                                    Surname = "Einstein"
                                },
                                new
                                {
                                    CustomerEntityId = 2L,
                                    Forename = "Stephen",
                                    Surname = "Hawking"
                                },
                                new
                                {
                                    CustomerEntityId = 3L,
                                    Forename = "Ada",
                                    Surname = "Lovelace"
                                });
                        });
                });
#pragma warning restore 612, 618
        }
    }
}