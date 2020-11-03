﻿// <auto-generated />
using Dimension_Data_MVC_CORE_Project2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dimension_Data_MVC_CORE_Project2.Data.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dimension_Data_MVC_CORE_Project2.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Age")
                        .HasColumnType("real");

                    b.Property<string>("BusinessTravel")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<float>("EducationField")
                        .HasColumnType("real");

                    b.Property<float>("EmployeeNumber")
                        .HasColumnType("real");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<float>("HourlyRate")
                        .HasColumnType("real");

                    b.Property<float>("JobSatisfaction")
                        .HasColumnType("real");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(255)");

                    b.Property<float>("MonthlyIncome")
                        .HasColumnType("real");

                    b.Property<float>("RelationshipSatisfaction")
                        .HasColumnType("real");

                    b.Property<float>("StandardHours")
                        .HasColumnType("real");

                    b.Property<float>("StockOptionLevel")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}