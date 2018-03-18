using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace NovaServer.Repository.Entity
{
	[Table("dbo.OrderStatus")]
  public class OrderStatusEntity
  {
		[Key]
		public int Id { get; set; }

    public string Value { get; set; }
  }
}
