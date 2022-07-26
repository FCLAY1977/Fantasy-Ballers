﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FantasyBallers.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("FantasyTeam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Defense")
                        .HasColumnType("TEXT");

                    b.Property<string>("Flex")
                        .HasColumnType("TEXT");

                    b.Property<string>("Kicker")
                        .HasColumnType("TEXT");

                    b.Property<string>("QB1")
                        .HasColumnType("TEXT");

                    b.Property<string>("QB2")
                        .HasColumnType("TEXT");

                    b.Property<string>("RB1")
                        .HasColumnType("TEXT");

                    b.Property<string>("RB2")
                        .HasColumnType("TEXT");

                    b.Property<double?>("SkillLevel")
                        .HasColumnType("REAL");

                    b.Property<string>("TE")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TouchDownsProjected")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TouchdownsScoredLastYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WR1")
                        .HasColumnType("TEXT");

                    b.Property<string>("WR2")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("FantasyTeams");
                });
#pragma warning restore 612, 618
        }
    }
}
