﻿// <auto-generated />
using System;
using Deep_Patel_Backend_Challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Deep_Patel_Backend_Challenge.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Deep_Patel_Backend_Challenge.Models.Entities.FavouriteInventoryDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("InventoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.ToTable("FavouriteCollection");
                });

            modelBuilder.Entity("Deep_Patel_Backend_Challenge.Models.Entities.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Deep_Patel_Backend_Challenge.Models.Entities.FavouriteInventoryDTO", b =>
                {
                    b.HasOne("Deep_Patel_Backend_Challenge.Models.Entities.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId");

                    b.Navigation("Inventory");
                });
#pragma warning restore 612, 618
        }
    }
}
