using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace NovaServer.Repository.Entity
{
	[Table("dbo.User")]
  public class UserEntity
  {
		[Key]
		
		public int Id { get; set; }

    public string Username { get; set; }

    public int PasswordId { get; set; }

    public DateTime AccountExpiration { get; set; }

    public int RoleId { get; set; }

    public string Email { get; set; }
  }
}
