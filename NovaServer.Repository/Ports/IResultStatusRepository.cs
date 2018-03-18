using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface IResultStatusRepository
  {
    List<ResultStatusEntity> GetAll();
  }
}
