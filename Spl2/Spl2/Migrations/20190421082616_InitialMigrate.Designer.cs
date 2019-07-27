﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Spl2.Models;

namespace Spl2.Migrations
{
    [DbContext(typeof(Spl2Context))]
    [Migration("20190421082616_InitialMigrate")]
    partial class InitialMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Spl2.Models.DailyStudentServiceList", b =>
                {
                    b.Property<int>("DailyStudentServixeListId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DrugList")
                        .IsRequired()
                        .HasColumnType("varchar(7000)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("problemDetails")
                        .IsRequired()
                        .HasColumnType("varchar(600)");

                    b.Property<string>("studentname")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("DailyStudentServixeListId");

                    b.ToTable("dailyStudentServiceLists");
                });
#pragma warning restore 612, 618
        }
    }
}
