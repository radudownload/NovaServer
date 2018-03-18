using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace NovaServer.Repository.Entity
{
	[Table("dbo.Password")]
  public class PasswordEntity
  {
		[Key]
		
		public int Id { get; set; }

    public string PasswordHash { get; set; }
		
    public DateTime PasswordExpiration { get; set; }
		
    public int UserId { get; set; }
  }
}
