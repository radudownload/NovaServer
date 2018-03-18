using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaServer.UI.Models.NovaServerModels
{
  public class QualitativeAssayResult
  {
    public int Id { get; set; }

    public int AssayId { get; set; }

    public string SupportedValue { get; set; }
  }
}