﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StroopTest.Models;

namespace StroopTest.Migrations
{
    [DbContext(typeof(StroopTestContext))]
    [Migration("20190812040953_AddingActivityRecords")]
    partial class AddingActivityRecords
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StroopTest.Models.ActivityRecord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ink");

                    b.Property<int>("Phase");

                    b.Property<string>("Status");

                    b.Property<string>("Text");

                    b.Property<DateTime>("Time");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.ToTable("ActivityRecord");
                });

            modelBuilder.Entity("StroopTest.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Gener");

                    b.Property<string>("Lastname");

                    b.Property<string>("Name");

                    b.Property<DateTime>("RegisterDate");

                    b.HasKey("ID");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
