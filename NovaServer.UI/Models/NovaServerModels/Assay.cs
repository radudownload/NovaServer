using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaServer.UI.Models.NovaServerModels
{
  public class Assay
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public bool IsQualitative { get; set; }

    public float MinResultValue { get; set; }

    public float MaxResultValue { get; set; }

    public DateTime LastUpdate { get; set; }

    public bool IsMultiplex { get; set; }
  }
}