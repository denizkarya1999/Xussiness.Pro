﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Omega.Data.ITCompanies;

#nullable disable

namespace Project.Omega.Web.Migrations
{
    [DbContext(typeof(CompaniesDBContext))]
    [Migration("20220726194943_Seed.Data.Created")]
    partial class SeedDataCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Project.Omega.Data.ITCompanies.General", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AreaOfService")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BlacklistedOrNot")
                        .HasColumnType("bit");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FoundationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("int");

                    b.Property<bool>("PreviouslyWorkedOrNot")
                        .HasColumnType("bit");

                    b.Property<double>("Revenue")
                        .HasColumnType("float");

                    b.Property<bool>("SelectedOrNot")
                        .HasColumnType("bit");

                    b.Property<string>("WebsiteLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompaniesGeneral");

                    b.HasData(
                        new
                        {
                            Id = new Guid("275d02a9-1664-40cd-b2b8-b03259b8eb6a"),
                            AreaOfService = "Global",
                            BlacklistedOrNot = false,
                            CompanyName = "Omega Consulting LLC. (Sample)",
                            CompanyType = "Business Solutions",
                            FoundationDate = new DateTime(2022, 7, 26, 12, 49, 43, 537, DateTimeKind.Local).AddTicks(2411),
                            NumberOfEmployees = 15000,
                            PreviouslyWorkedOrNot = true,
                            Revenue = 120.0,
                            SelectedOrNot = true,
                            WebsiteLink = "https://www.dev-27.azurewebsites.net"
                        });
                });

            modelBuilder.Entity("Project.Omega.Data.ITCompanies.Specific", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AreaOfService")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("int");

                    b.Property<double>("Revenue")
                        .HasColumnType("float");

                    b.Property<string>("WebsiteLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompaniesSpecific");
                });
#pragma warning restore 612, 618
        }
    }
}
