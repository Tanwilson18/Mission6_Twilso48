﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_Twilso48.Models;

namespace Mission6_Twilso48.Migrations
{
    [DbContext(typeof(context))]
    [Migration("20230214151055_intialmigrate")]
    partial class intialmigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30");

            modelBuilder.Entity("Mission6_Twilso48.Models.applicationResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Edited")
                        .HasColumnType("TEXT");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("response");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Family",
                            Director = "John Lasseter",
                            Notes = "Best Movie Ever",
                            Rating = "G",
                            Title = "Cars",
                            Year = 2006
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Action",
                            Director = "Cary Joji Fukunaga",
                            Notes = "Enough to make a man cry",
                            Rating = "PG-13",
                            Title = "007: No Time to Die",
                            Year = 2021
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Family",
                            Director = "John Lasseter",
                            Notes = "Not as good as the first",
                            Rating = "G",
                            Title = "Cars 2",
                            Year = 2011
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
