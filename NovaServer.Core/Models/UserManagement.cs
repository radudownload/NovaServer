using System;

namespace NovaServer.Core.Models
{
  public class UserManagement
  {
    public int Id { get; set; }

    public string Username { get; set; }

    public int PasswordId { get; set; }

    public DateTime AccountExpiration { get; set; }

    public int RoleId { get; set; }

    public string Email { get; set; }
  }
}
