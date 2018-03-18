using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface IConnectionRepository
  {
    ConnectionEntity GetById(int id);

    IEnumerable<ConnectionEntity> GetAll();

    int Insert(ConnectionEntity taskEntity);

    void Update(ConnectionEntity taskEntity);

    bool Delete(ConnectionEntity taskEntity);
  }
}
