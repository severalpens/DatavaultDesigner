using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatavaultDesignerStar.Models;

[Table("Releases", Schema = "meta")]
public partial class Release
{
    [Key]
    public int ReleaseId { get; set; }

    public string? ReleaseDescription { get; set; }

    public int ReleaseOrderId { get; set; }

    public string? Branch { get; set; }

    public string? ReleaseName { get; set; }

    public string? DatabricksNotebook { get; set; }
    public string? Pattern { get; set; }

    public string? Architecture { get; set; }

    public string? Source { get; set; }

    public string? Pipeline { get; set; }

    public string? PipelineTrigger { get; set; }

    public string? BranchName { get; set; }

    public bool IsActive { get; set; }

    [InverseProperty("Release")]
    public virtual ICollection<ReleaseTblCol> ReleaseTblCols { get; } = new List<ReleaseTblCol>();
}
