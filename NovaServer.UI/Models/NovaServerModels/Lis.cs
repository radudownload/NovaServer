using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaServer.UI.Models.NovaServerModels
{
  public class Lis
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public int ConnectionId { get; set; }

    public bool IsDisabled { get; set; }
  }
}