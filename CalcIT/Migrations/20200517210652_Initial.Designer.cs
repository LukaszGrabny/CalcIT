﻿// <auto-generated />
using System;
using CalcIT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CalcIT.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20200517210652_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CalcIt.Models.AuditTrail", b =>
                {
                    b.Property<long>("at_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("date_time")
                        .HasColumnType("datetime2");

                    b.Property<long>("doctor_id")
                        .HasColumnType("bigint");

                    b.Property<string>("events")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("at_id");

                    b.ToTable("AuditTrails");
                });

            modelBuilder.Entity("CalcIt.Models.Calculation", b =>
                {
                    b.Property<long>("calculation_id")
                        .HasColumnType("bigint");

                    b.Property<string>("calculation_data")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("calculation_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("calculation_type")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long>("doctor_id")
                        .HasColumnType("bigint");

                    b.Property<long>("patient_id")
                        .HasColumnType("bigint");

                    b.Property<string>("result")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("calculation_id");

                    b.ToTable("Calculations");
                });

            modelBuilder.Entity("CalcIt.Models.Department", b =>
                {
                    b.Property<long>("department_id")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("department_id");

                    b.ToTable("Departmens");
                });

            modelBuilder.Entity("CalcIt.Models.Doctor", b =>
                {
                    b.Property<long>("doctor_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("doctor_id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("CalcIt.Models.Patient", b =>
                {
                    b.Property<long>("patient_id")
                        .HasColumnType("bigint");

                    b.Property<long>("PESEL")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("birthdate")
                        .HasColumnType("datetime2");

                    b.Property<long>("departament_id")
                        .HasColumnType("bigint");

                    b.Property<double>("height")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("registration_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<double>("weight")
                        .HasColumnType("float")
                        .HasMaxLength(50);

                    b.HasKey("patient_id");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
