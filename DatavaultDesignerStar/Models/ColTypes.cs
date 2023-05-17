using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatavaultDesignerStar.Models;

[Table("ColTypes", Schema = "meta")]
public partial class ColType
{
    [Key]
    public int ColTypeId { get; set; }

    public string? ColTypeName { get; set; }
    public string? DatabricksName { get; set; }
    public string? AzureSqlName { get; set; }
    public bool IsChar { get; set; }
    public int? DefaultLen { get; set; }


    [InverseProperty("ColType")]
    public virtual ICollection<ReleaseTblCol> ReleaseTblCols { get; } = new List<ReleaseTblCol>();



}
