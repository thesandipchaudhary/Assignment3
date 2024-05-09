﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Vidhyalaya.Migrations
{
    [DbContext(typeof(VidhyalayaDbContext))]
    partial class VidhyalayaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Grade", b =>
                {
                    b.Property<int>("Label")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassTeacher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Medium")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Session")
                        .HasColumnType("TEXT");

                    b.Property<string>("Subjects")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Label");

                    b.ToTable("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
