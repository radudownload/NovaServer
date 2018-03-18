using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace NovaServer.Repository.Entity
{
	[Table("dbo.Result")]
  public class LisEntity
  {
		[Key]
		
		public int Id { get; set; }

    public string Name { get; set; }
		
    public int ConnectionId { get; set; }

    public bool IsDisabled { get; set; }
  }
}
