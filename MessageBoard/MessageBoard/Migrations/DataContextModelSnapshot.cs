﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MessageBoard;

namespace MessageBoard.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("MessageBoard.ChatInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("IP")
                        .HasMaxLength(20);

                    b.Property<bool>("Sex");

                    b.Property<string>("UserName")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("ChatInfo");
                });

            modelBuilder.Entity("MessageBoard.LogInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("IP")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("LogInfos");
                });

            modelBuilder.Entity("MessageBoard.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("IP")
                        .HasMaxLength(20);

                    b.Property<string>("UserName")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });
        }
    }
}
