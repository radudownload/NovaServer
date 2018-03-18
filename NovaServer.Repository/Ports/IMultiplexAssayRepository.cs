using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface IMultiplexAssayRepository
  {
    MultiplexAssayEntity GetById(int id);

    IEnumerable<MultiplexAssayEntity> GetAll();

    int Insert(MultiplexAssayEntity taskEntity);

    void Update(MultiplexAssayEntity taskEntity);

    bool Delete(MultiplexAssayEntity taskEntity);
  }
}
