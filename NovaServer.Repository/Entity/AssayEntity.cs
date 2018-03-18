using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace NovaServer.Repository.Entity
{
  [Table("dbo.Assay")]
  public class AssayEntity
  {
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public bool IsQualitative { get; set; }

    public float MinResultValue { get; set; }

    public float MaxResultValue { get; set; }

    public DateTime LastUpdate { get; set; }

    public bool IsMultiplex { get; set; }
  }
}
