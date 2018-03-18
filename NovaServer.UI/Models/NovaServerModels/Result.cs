using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaServer.UI.Models.NovaServerModels
{
  public class Result
  {
    public int Id { get; set; }

    public int AssayId { get; set; }

    public string SampleId { get; set; }

    public string Value { get; set; }

    public int InstrumentId { get; set; }

    public DateTime InstrumentDate { get; set; }

    public int OrderId { get; set; }

    public int StatusId { get; set; }

    public bool IsDeleted { get; set; }
  }
}