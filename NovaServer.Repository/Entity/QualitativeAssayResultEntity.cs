using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace NovaServer.Repository.Entity
{
	[Table("dbo.QualitativeAssayResult")]
  public class QualitativeAssayResultEntity
  {
		[Key]

		public int Id { get; set; }

    public int AssayId { get; set; }

    public string SupportedValue { get; set; }
  }
}
