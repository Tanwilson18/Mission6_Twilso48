﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_Twilso48.Models;

namespace Mission6_Twilso48.Migrations
{
    [DbContext(typeof(context))]
    partial class contextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30");

            modelBuilder.Entity("Mission6_Twilso48.Models.applicationResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Major")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Stalker")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("phone")
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.ToTable("response");
                });
#pragma warning restore 612, 618
        }
    }
}
