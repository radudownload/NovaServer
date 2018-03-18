using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace NovaServer.Repository.Entity
{
	[Table("dbo.Result")]
  public class RoleEntity
  {
		[Key]

		public int Id { get; set; }

    public string Value { get; set; }
  }
}
