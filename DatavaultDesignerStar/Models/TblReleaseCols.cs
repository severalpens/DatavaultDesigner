using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatavaultDesignerStar.Models;

[Table("ReleaseTblCols", Schema = "meta")]
public partial class ReleaseTblCol
{
    [Key]
    public int ReleaseTblColId { get; set; }
    public int? TblId { get; set; }
    public int? ReleaseId { get; set; }

    public string? ColName { get; set; }
    public int? ColTypeId { get; set; }
    public int? ColTypeLen { get; set; }

    public bool Fk { get; set; }

    public string? FkCol { get; set; }

    public int? FkColId { get; set; }

    public string? FkTbl { get; set; }

    public int? FkTblId { get; set; }

    public bool HshDiff { get; set; }

    public bool HshDiffMember { get; set; }

    public bool HshKy { get; set; }

    public bool HshKyMember { get; set; }

    public bool Pk { get; set; }

    public bool IsActive { get; set; }
    public int? OrderId { get; set; }

    public bool CandidateField { get; set; }
    public bool IncludedField { get; set; }


    [ForeignKey("ColTypeId")]
    [InverseProperty("ReleaseTblCols")]
    public virtual ColType? ColType { get; set; }

    [ForeignKey("TblId")]
    [InverseProperty("ReleaseTblCols")]
    public virtual Tbl? Tbl { get; set; }

    [ForeignKey("ReleaseId")]
    [InverseProperty("ReleaseTblCols")]
    public virtual Release? Release { get; set; }
}
