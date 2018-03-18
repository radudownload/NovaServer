using System;

namespace NovaServer.Core.Models
{
  public class AssayManagement
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
