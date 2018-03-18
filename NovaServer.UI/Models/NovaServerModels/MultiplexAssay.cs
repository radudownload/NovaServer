using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaServer.UI.Models.NovaServerModels
{
  public class MultiplexAssay
  {
    public int Id { get; set; }

    public int AssayId { get; set; }

    public int ConstituentId { get; set; }
  }
}