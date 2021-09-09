﻿// <auto-generated />
using System;
using Botsboxadminbot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Botsboxadminbot.Migrations
{
    [DbContext(typeof(BotContext))]
    [Migration("20210903165706_ffff")]
    partial class ffff
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Botsboxadminbot.Models.Entities.BotsBoxMessageEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("BranchId")
                        .HasColumnType("integer");

                    b.Property<string>("CLientAnswer")
                        .HasColumnType("text");

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("File")
                        .HasColumnType("text");

                    b.Property<bool>("IHaveBeenInvoked")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("boolean");

                    b.Property<string>("MethodName")
                        .HasColumnType("text");

                    b.Property<bool>("NeedsToChange")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Botsboxadminbot.Models.Entities.BranchEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Botsboxadminbot.Models.Entities.BotsBoxMessageEntity", b =>
                {
                    b.HasOne("Botsboxadminbot.Models.Entities.BranchEntity", "Branch")
                        .WithMany("Parts")
                        .HasForeignKey("BranchId");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Botsboxadminbot.Models.Entities.BranchEntity", b =>
                {
                    b.Navigation("Parts");
                });
#pragma warning restore 612, 618
        }
    }
}