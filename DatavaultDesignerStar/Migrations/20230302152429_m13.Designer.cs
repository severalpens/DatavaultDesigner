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
    [Migration("20230302152429_m13")]
    partial class m13
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DatavaultDesignerStar.Models.Col", b =>
                {
                    b.Property<int>("ColId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColId"));

                    b.Property<string>("ColName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatatypeDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("ColId");

                    b.ToTable("Cols", "meta");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Prop", b =>
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

            modelBuilder.Entity("DatavaultDesignerStar.Models.Tbl", b =>
                {
                    b.Property<int>("TblId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TblId"));

                    b.Property<string>("DbName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("(CONVERT([bit],(0)))");

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

                    b.HasIndex("ColId");

                    b.HasIndex("TblId");

                    b.ToTable("TblCols", "meta");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.TblRelease", b =>
                {
                    b.Property<int>("TblReleaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TblReleaseId"));

                    b.Property<int?>("ReleaseId")
                        .HasColumnType("int");

                    b.Property<string>("ReleaseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TblId")
                        .HasColumnType("int");

                    b.Property<string>("TblName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TblReleaseId");

                    b.HasIndex("ReleaseId");

                    b.HasIndex("TblId");

                    b.ToTable("TblReleases", "meta");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.TblCol", b =>
                {
                    b.HasOne("DatavaultDesignerStar.Models.Col", "Col")
                        .WithMany("TblCols")
                        .HasForeignKey("ColId")
                        .HasConstraintName("fk_TblCols_Cols");

                    b.HasOne("DatavaultDesignerStar.Models.Tbl", "Tbl")
                        .WithMany("TblCols")
                        .HasForeignKey("TblId")
                        .HasConstraintName("fk_TblCols_Tbls");

                    b.Navigation("Col");

                    b.Navigation("Tbl");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.TblRelease", b =>
                {
                    b.HasOne("DatavaultDesignerStar.Models.Release", "Release")
                        .WithMany("TblReleases")
                        .HasForeignKey("ReleaseId")
                        .HasConstraintName("fk_TblReleases_Releases");

                    b.HasOne("DatavaultDesignerStar.Models.Tbl", "Tbl")
                        .WithMany("TblReleases")
                        .HasForeignKey("TblId")
                        .HasConstraintName("fk_TblReleases_Tbls");

                    b.Navigation("Release");

                    b.Navigation("Tbl");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Col", b =>
                {
                    b.Navigation("TblCols");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Release", b =>
                {
                    b.Navigation("TblReleases");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Tbl", b =>
                {
                    b.Navigation("TblCols");

                    b.Navigation("TblReleases");
                });
#pragma warning restore 612, 618
        }
    }
}
