using System;

namespace NovaServer.Core.Models
{
  public class PasswordManagement
  {
    public int Id { get; set; }

    public string PasswordHash { get; set; }

    public DateTime PasswordExpiration { get; set; }

    public int UserId { get; set; }
  }
}
