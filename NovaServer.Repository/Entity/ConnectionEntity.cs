using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace NovaServer.Repository.Entity
{
	[Table("dbo.Connection")]
  public class ConnectionEntity
  {
		[Key]
		
    public int Id { get; set; }

    public bool IsInstrument { get; set; }	

    public string TcpIp { get; set; }

    public int TcpPort { get; set; }
  }
}
