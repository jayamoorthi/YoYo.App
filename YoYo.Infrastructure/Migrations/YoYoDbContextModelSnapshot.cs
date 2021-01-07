﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YoYo.Infrastructure.YoyoTestDbContext;

namespace YoYo.Infrastructure.Migrations
{
    [DbContext(typeof(YoYoDbContext))]
    partial class YoYoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("YoYo.Domain.Entities.YoYoPerson.FitnessTest", b =>
                {
                    b.Property<int>("FitnessTestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime");

                    b.Property<string>("EndDtTime")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStarted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStoped")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWarned")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWarning")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.Property<string>("StartDtTime")
                        .HasColumnType("text");

                    b.HasKey("FitnessTestID");

                    b.ToTable("FitnessTests");
                });

            modelBuilder.Entity("YoYo.Domain.Entities.YoYoPerson.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("PersonID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("YoYo.Domain.Entities.YoYoPerson.Shuttle", b =>
                {
                    b.Property<int>("ShuttleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AccumulatedShuttleDistance")
                        .HasColumnType("text");

                    b.Property<string>("ApproxVo2Max")
                        .HasColumnType("text");

                    b.Property<string>("CommulativeTime")
                        .HasColumnType("text");

                    b.Property<string>("CompletionTime")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CreatedBy")
                        .HasColumnType("datetime");

                    b.Property<int>("FitnessTestID")
                        .HasColumnType("int");

                    b.Property<bool>("IsBeep")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStoped")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWarned")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWarning")
                        .HasColumnType("bit");

                    b.Property<string>("LevelTime")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ModifiedBy")
                        .HasColumnType("datetime");

                    b.Property<int>("ShuttleNo")
                        .HasColumnType("int");

                    b.Property<string>("Speed")
                        .HasColumnType("text");

                    b.Property<string>("SpeedLevel")
                        .HasColumnType("text");

                    b.Property<string>("StartTime")
                        .HasColumnType("text");

                    b.HasKey("ShuttleID");

                    b.ToTable("Shuttles");
                });
#pragma warning restore 612, 618
        }
    }
}
