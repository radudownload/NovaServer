﻿using System;

namespace NovaServer.Core.Models
{
  public class InstrumentManagement
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public int ConnectionId { get; set; }

    public bool IsDisabled { get; set; }
  }
}
