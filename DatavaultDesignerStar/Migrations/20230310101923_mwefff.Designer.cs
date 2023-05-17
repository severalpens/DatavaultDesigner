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
    [Migration("20230310101923_mwefff")]
    partial class mwefff
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DatavaultDesignerStar.Models.AdfConfig.AdfConfig", b =>
                {
                    b.Property<int>("AdfConfigId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdfConfigId"));

                    b.Property<int?>("ParameterCodeId")
                        .HasColumnType("int");

                    b.Property<string>("Pattern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdfConfigId");

                    b.ToTable("AdfConfigs", "adfc");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.AdfConfig.HubInfo", b =>
                {
                    b.Property<int>("HubInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HubInfoId"));

                    b.Property<int?>("AdfConfigId")
                        .HasColumnType("int");

                    b.HasKey("HubInfoId");

                    b.ToTable("HubInfos", "adfc");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.AdfConfig.HubInfoHub", b =>
                {
                    b.Property<int>("HubInfoHubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HubInfoHubId"));

                    b.Property<int?>("HubInfoId")
                        .HasColumnType("int");

                    b.Property<string>("HubName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HubInfoHubId");

                    b.ToTable("HubInfoHubs", "adfc");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.AdfConfig.HubInfoHubKey", b =>
                {
                    b.Property<int>("HubInfoHubKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HubInfoHubKeyId"));

                    b.Property<int?>("HubInfoHubId")
                        .HasColumnType("int");

                    b.Property<string>("HubKeyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HubInfoHubKeyId");

                    b.ToTable("HubInfoHubKeys", "adfc");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.AdfConfig.KeyMapping", b =>
                {
                    b.Property<int>("KeyMappingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KeyMappingId"));

                    b.Property<int?>("HubInfoId")
                        .HasColumnType("int");

                    b.Property<int?>("KeyMappingValueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KeyMappingId");

                    b.ToTable("KeyMappings", "adfc");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.AdfConfig.KeyMappingValue", b =>
                {
                    b.Property<int>("KeyMappingValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KeyMappingValueId"));

                    b.Property<int?>("KeyMappingId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KeyMappingValueId");

                    b.ToTable("KeyMappingValues", "adfc");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.AdfConfig.AdfConfigOriginal", b =>
                {
                    b.Property<int>("AdfConfigOriginalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdfConfigOriginalId"));

                    b.Property<int?>("OldId")
                        .HasColumnType("int");

                    b.Property<string>("ParameterCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParameterValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pattern")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdfConfigOriginalId");

                    b.ToTable("AdfConfigOriginals", "adfc");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.AdfConfig.ParameterCode", b =>
                {
                    b.Property<int>("ParameterCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParameterCodeId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParameterCodeId");

                    b.ToTable("ParameterCodes", "adfc");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.ColType", b =>
                {
                    b.Property<int>("ColTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColTypeId"));

                    b.Property<string>("AzureSqlName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatabricksName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DefaultLen")
                        .HasColumnType("int");

                    b.Property<bool>("IsChar")
                        .HasColumnType("bit");

                    b.HasKey("ColTypeId");

                    b.ToTable("ColTypes", "meta");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Release", b =>
                {
                    b.Property<int>("ReleaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReleaseId"));

                    b.Property<string>("Architecture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatabricksNotebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Pattern")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReleaseId");

                    b.ToTable("Releases", "meta");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.ReleaseTblCol", b =>
                {
                    b.Property<int>("ReleaseTblColId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReleaseTblColId"));

                    b.Property<bool>("CandidateField")
                        .HasColumnType("bit");

                    b.Property<string>("ColName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ColTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ColTypeLen")
                        .HasColumnType("int");

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

                    b.Property<bool>("IncludedField")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<bool>("Pk")
                        .HasColumnType("bit");

                    b.Property<int?>("ReleaseId")
                        .HasColumnType("int");

                    b.Property<int?>("TblId")
                        .HasColumnType("int");

                    b.HasKey("ReleaseTblColId");

                    b.HasIndex("ColTypeId");

                    b.HasIndex("ReleaseId");

                    b.HasIndex("TblId");

                    b.ToTable("ReleaseTblCols", "meta");
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
                        .HasColumnType("bit");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("SchemaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TblName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TblId");

                    b.ToTable("Tbls", "meta");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.ReleaseTblCol", b =>
                {
                    b.HasOne("DatavaultDesignerStar.Models.ColType", "ColType")
                        .WithMany("ReleaseTblCols")
                        .HasForeignKey("ColTypeId")
                        .HasConstraintName("fk_TblCollReleases_ColTypes");

                    b.HasOne("DatavaultDesignerStar.Models.Release", "Release")
                        .WithMany("ReleaseTblCols")
                        .HasForeignKey("ReleaseId")
                        .HasConstraintName("fk_ReleaseTblCols_Releases");

                    b.HasOne("DatavaultDesignerStar.Models.Tbl", "Tbl")
                        .WithMany("ReleaseTblCols")
                        .HasForeignKey("TblId")
                        .HasConstraintName("fk_TblCollReleases_Tbls");

                    b.Navigation("ColType");

                    b.Navigation("Release");

                    b.Navigation("Tbl");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.ColType", b =>
                {
                    b.Navigation("ReleaseTblCols");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Release", b =>
                {
                    b.Navigation("ReleaseTblCols");
                });

            modelBuilder.Entity("DatavaultDesignerStar.Models.Tbl", b =>
                {
                    b.Navigation("ReleaseTblCols");
                });
#pragma warning restore 612, 618
        }
    }
}
