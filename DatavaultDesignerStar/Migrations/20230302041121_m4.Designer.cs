﻿// <auto-generated />
using System;
using DatavaultDesignerStar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatavaultDesignerStar.Migrations
{
    [DbContext(typeof(DatavaultDesignerStarDbContext))]
    [Migration("20230302041121_m4")]
    partial class m4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DatavaultDesignerStar.Models.Cols", b =>
                {
                    b.Property<int>("ColId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColId"));

                    b.Property<string>("ColName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColNameV2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColOrderId")
                        .HasColumnType("int");

                    b.Property<string>("DatatypeDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("ColId");

                    b.ToTable("Cols", "meta");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Props", b =>
                {
                    b.Property<int>("PropId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropId"));

                    b.Property<string>("Architecture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ColId")
                        .HasColumnType("int");

                    b.Property<string>("DbName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Fk")
                        .HasColumnType("bit");

                    b.Property<string>("FkCol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FkColId")
                        .HasColumnType("int");

                    b.Property<string>("FkTbl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FkTblId")
                        .HasColumnType("int");

                    b.Property<bool>("HshDiff")
                        .HasColumnType("bit");

                    b.Property<bool>("HshDiffMember")
                        .HasColumnType("bit");

                    b.Property<bool>("HshKy")
                        .HasColumnType("bit");

                    b.Property<bool>("HshKyMember")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsReleased")
                        .HasColumnType("bit");

                    b.Property<string>("Notebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pattern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pipeline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Pk")
                        .HasColumnType("bit");

                    b.Property<int>("ReleaseId")
                        .HasColumnType("int");

                    b.Property<string>("SchemaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TblId")
                        .HasColumnType("int");

                    b.Property<string>("Trigger")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PropId")
                        .HasName("PK__Props");

                    b.HasIndex("ColId");

                    b.HasIndex("ReleaseId");

                    b.HasIndex("TblId");

                    b.ToTable("Props", "meta");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Release", b =>
                {
                    b.Property<int>("ReleaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReleaseId"));

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatabricksNotebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Pipeline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PipelineTrigger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseOrderId")
                        .HasColumnType("int");

                    b.HasKey("ReleaseId");

                    b.ToTable("Releases", "meta");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Tbls", b =>
                {
                    b.Property<int>("TblId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TblId"));

                    b.Property<string>("DbName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("SchemaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TblName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TblNameV2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TblOrderId")
                        .HasColumnType("int");

                    b.HasKey("TblId");

                    b.ToTable("Tbls", "meta");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.TblCol", b =>
                {
                    b.Property<int>("TblColId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TblColId"));

                    b.Property<int?>("ColId")
                        .HasColumnType("int");

                    b.Property<string>("ColName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TblId")
                        .HasColumnType("int");

                    b.Property<string>("TblName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TblColId");

                    b.ToTable("TblCol", "meta");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Props", b =>
                {
                    b.HasOne("DatavaultDesignerStar.Models.Cols", "Cols")
                        .WithMany("Props")
                        .HasForeignKey("ColId")
                        .IsRequired()
                        .HasConstraintName("fk_Facts_Cols");

                    b.HasOne("DatavaultDesignerStar.Models.Release", "Release")
                        .WithMany("Props")
                        .HasForeignKey("ReleaseId")
                        .IsRequired()
                        .HasConstraintName("fk_Facts_Releases");

                    b.HasOne("DatavaultDesignerStar.Models.Tbls", "Tbls")
                        .WithMany("Props")
                        .HasForeignKey("TblId")
                        .IsRequired()
                        .HasConstraintName("fk_Facts_Tbls");

                    b.Navigation("Cols");

                    b.Navigation("Release");

                    b.Navigation("Tbls");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Cols", b =>
                {
                    b.Navigation("Props");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Release", b =>
                {
                    b.Navigation("Props");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Tbls", b =>
                {
                    b.Navigation("Props");
                });
#pragma warning restore 612, 618
        }
    }
}
