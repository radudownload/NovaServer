using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface ILisRepository
  {
    LisEntity GetById(int id);

    IEnumerable<LisEntity> GetAll();

    int Insert(LisEntity taskEntity);

    void Update(LisEntity taskEntity);

    bool Delete(LisEntity taskEntity);
  }
}
