﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoListApi.Data;

#nullable disable

namespace ToDoListApi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230906072256_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ToDoListApi.Data.ToDoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ToDoItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Done = false,
                            Title = "Morning exercise"
                        },
                        new
                        {
                            Id = 2,
                            Done = false,
                            Title = "Read for 30 minutes"
                        },
                        new
                        {
                            Id = 3,
                            Done = false,
                            Title = "Work on project tasks"
                        },
                        new
                        {
                            Id = 4,
                            Done = false,
                            Title = "Lunch break"
                        },
                        new
                        {
                            Id = 5,
                            Done = true,
                            Title = "Attend team meeting"
                        },
                        new
                        {
                            Id = 6,
                            Done = true,
                            Title = "Complete work tasks"
                        },
                        new
                        {
                            Id = 7,
                            Done = true,
                            Title = "Dinner"
                        },
                        new
                        {
                            Id = 8,
                            Done = true,
                            Title = "Relax and unwind"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
