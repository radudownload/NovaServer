using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NovaServer.UI.Models.NovaServerModels
{
  public class NovaServerContext : DbContext
  {
    public NovaServerContext() : base("NovaServerContext")
    {
    }

    public virtual DbSet<Assay> Assay { get; set; }
    public virtual DbSet<Connection> Connection { get; set; }
    public virtual DbSet<Lis> Lis { get; set; }
    public virtual DbSet<QualitativeAssayResult> QualitativeAssayResult { get; set; }

    public virtual DbSet<Order> Order { get; set; }
    public virtual DbSet<Result> Result { get; set; }
    public virtual DbSet<Instrument> Instrument { get; set; }
    
  }
}