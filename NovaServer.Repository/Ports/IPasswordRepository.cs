using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface IPasswordRepository
  {
    PasswordEntity GetById(int id);

    IEnumerable<PasswordEntity> GetAll();

    int Insert(PasswordEntity taskEntity);

    void Update(PasswordEntity taskEntity);

    bool Delete(PasswordEntity taskEntity);
  }
}
