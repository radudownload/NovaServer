using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaServer.UI.Models.NovaServerModels
{
  public class Connection
  {
    public int Id { get; set; }

    public bool IsInstrument { get; set; }

    public string TcpIp { get; set; }

    public int TcpPort { get; set; }
  }
}