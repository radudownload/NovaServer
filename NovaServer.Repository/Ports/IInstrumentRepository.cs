using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface IInstrumentRepository
  {
    InstrumentEntity GetById(int id);

    IEnumerable<InstrumentEntity> GetAll();

    int Insert(InstrumentEntity taskEntity);

    void Update(InstrumentEntity taskEntity);

    bool Delete(InstrumentEntity taskEntity);
  }
}
