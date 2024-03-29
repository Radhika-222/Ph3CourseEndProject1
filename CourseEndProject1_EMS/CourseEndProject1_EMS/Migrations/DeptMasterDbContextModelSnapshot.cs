﻿// <auto-generated />
using System;
using CourseEndProject1_EMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CourseEndProject1_EMS.Migrations
{
    [DbContext(typeof(DeptMasterDbContext))]
    partial class DeptMasterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CourseEndProject1_EMS.Models.DeptMaster", b =>
                {
                    b.Property<int>("DeptCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptCode"), 1L, 1);

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptCode");

                    b.ToTable("DeptMaster");
                });

            modelBuilder.Entity("CourseEndProject1_EMS.Models.EmpProfile", b =>
                {
                    b.Property<int>("EmpCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpCode"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeptCode")
                        .HasColumnType("int");

                    b.Property<int>("DeptMasterDeptCode")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpCode");

                    b.HasIndex("DeptMasterDeptCode");

                    b.ToTable("EmpProfile");
                });

            modelBuilder.Entity("CourseEndProject1_EMS.Models.EmpProfile", b =>
                {
                    b.HasOne("CourseEndProject1_EMS.Models.DeptMaster", "DeptMaster")
                        .WithMany("EmpProfiles")
                        .HasForeignKey("DeptMasterDeptCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeptMaster");
                });

            modelBuilder.Entity("CourseEndProject1_EMS.Models.DeptMaster", b =>
                {
                    b.Navigation("EmpProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
