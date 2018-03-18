using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovaServer.UI.Models.NovaServerModels
{
  public class Order
  {
    public int Id { get; set; }

    public int AssayId { get; set; }

    public string SampleId { get; set; }

    public string UserOrderId { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime IssueDate { get; set; }

    public int StatusId { get; set; }

    public bool IsDeleted { get; set; }
  }
}