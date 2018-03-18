using System;

namespace NovaServer.Core.Models
{
  public class ConnectionManagement
  {
    public int Id { get; set; }

    public bool IsInstrument { get; set; }

    public string TcpIp { get; set; }

    public int TcpPort { get; set; }
  }
}
