using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface IResultRepository
  {
    ResultEntity GetById(int id);

    IEnumerable<ResultEntity> GetAll();

    int Insert(ResultEntity taskEntity);

    void Update(ResultEntity taskEntity);

    bool Delete(ResultEntity taskEntity);
  }
}
