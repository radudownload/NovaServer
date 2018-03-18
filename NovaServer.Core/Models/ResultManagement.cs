using System;

namespace NovaServer.Core.Models
{
  public class ResultManagement
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
