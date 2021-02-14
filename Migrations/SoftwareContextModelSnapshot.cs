﻿// <auto-generated />
using MMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MMS.Migrations
{
    [DbContext(typeof(SoftwareContext))]
    partial class SoftwareContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("MMS.Models.Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Deployment")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("FreeTrial")
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("StartingPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("Support")
                        .HasColumnType("TEXT");

                    b.Property<string>("Training")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Software");
                });
#pragma warning restore 612, 618
        }
    }
}
