using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatavaultDesignerStar.Models;

[Table("Tbls", Schema = "meta")]
public partial class Tbl
{
    [Key]
    public int TblId { get; set; }

    public string? DbName { get; set; }

    public string? SchemaName { get; set; }

    public string? TblName { get; set; }
    public bool IsActive { get; set; }
    public int OrderId { get; set; }




    [InverseProperty("Tbl")]
    public virtual ICollection<ReleaseTblCol> ReleaseTblCols { get; } = new List<ReleaseTblCol>();
}
