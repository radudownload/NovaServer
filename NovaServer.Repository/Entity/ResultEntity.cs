using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace NovaServer.Repository.Entity
{
	[Table("dbo.Result")]
  public class ResultEntity
  {
		[Key]
		
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
