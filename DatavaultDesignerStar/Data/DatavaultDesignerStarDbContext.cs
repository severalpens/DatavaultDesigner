using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using DatavaultDesignerStar.Migrations;
using DatavaultDesignerStar.Models;
using DatavaultDesignerStar.Models.AdfConfig;
using Microsoft.EntityFrameworkCore;

namespace DatavaultDesignerStar.Data;

public partial class DatavaultDesignerStarDbContext : DbContext
{
    public DatavaultDesignerStarDbContext()
    {
    }

    public DatavaultDesignerStarDbContext(DbContextOptions<DatavaultDesignerStarDbContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Release> Releases { get; set; }
    public virtual DbSet<ColType> ColTypes { get; set; }
    public virtual DbSet<Tbl> Tbls { get; set; }
    public virtual DbSet<ReleaseTblCol> ReleaseTblCols { get; set; }
    public virtual DbSet<AdfConfig> AdfConfigs { get; set; }
    public virtual DbSet<ParameterCode> ParameterCodes { get; set; }
    public virtual DbSet<HubInfo> HubInfos { get; set; }
    public virtual DbSet<KeyMapping> KeyMappings { get; set; }
    public virtual DbSet<KeyMappingValue> KeyMappingValues { get; set; }
    public virtual DbSet<HubInfoHub> HubInfoHubs    { get; set; }
    public virtual DbSet<HubInfoHubKey> HubInfoHubKeys { get; set; }
    public virtual DbSet<AdfConfigOriginal> AdfConfigOriginals { get; set; }
    public virtual DbSet<Models.AdfConfig.AdfConfigExtract> AdfConfigExtracts { get; set; }
    public virtual DbSet<Models.AdfConfig.SchemaExtract> SchemaExtracts { get; set; }



    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DatavaultDesignerStar");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


            modelBuilder.Entity<ReleaseTblCol>(entity =>
            {
                entity.HasOne(d => d.Release).WithMany(p => p.ReleaseTblCols).HasConstraintName("fk_ReleaseTblCols_Releases");

                entity.HasOne(d => d.Tbl).WithMany(p => p.ReleaseTblCols).HasConstraintName("fk_TblCollReleases_Tbls");
                entity.HasOne(d => d.ColType).WithMany(p => p.ReleaseTblCols).HasConstraintName("fk_TblCollReleases_ColTypes");
            });



        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
