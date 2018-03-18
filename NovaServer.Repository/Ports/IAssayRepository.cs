using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface IAssayRepository
  {
    AssayEntity GetById(int id);

    IEnumerable<AssayEntity> GetAll();

    int Insert(AssayEntity taskEntity);

    void Update(AssayEntity taskEntity);

    bool Delete(AssayEntity taskEntity);
  }
}
