﻿// <auto-generated />
using Dimension_Data_MVC_CORE_Project2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dimension_Data_MVC_CORE_Project2.Data.Migrations
{
    [DbContext(typeof(ManagerContext))]
    partial class ManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dimension_Data_MVC_CORE_Project2.Models.Manager", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Attrition")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<float>("DailyRate")
                        .HasColumnType("real");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<float>("EmployeeCount")
                        .HasColumnType("real");

                    b.Property<float>("EmployeeNumber")
                        .HasColumnType("real");

                    b.Property<float>("HourlyRate")
                        .HasColumnType("real");

                    b.Property<float>("JobInvolvement")
                        .HasColumnType("real");

                    b.Property<string>("JobRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<float>("MonthlyIncome")
                        .HasColumnType("real");

                    b.Property<float>("MonthlyRate")
                        .HasColumnType("real");

                    b.Property<string>("OverTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<float>("PercentSalaryHike")
                        .HasColumnType("real");

                    b.Property<float>("PerformanceRating")
                        .HasColumnType("real");

                    b.Property<float>("StandardHours")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Managers");
                });
#pragma warning restore 612, 618
        }
    }
}