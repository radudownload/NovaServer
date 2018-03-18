using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace NovaServer.Repository.Entity
{
	[Table("dbo.MultiplexAssay")]
  public class MultiplexAssayEntity
  {
		[Key]
		
		public int Id { get; set; }
		
		public int AssayId { get; set; }
		
		public int ConstituentId { get; set; }
  }
}
