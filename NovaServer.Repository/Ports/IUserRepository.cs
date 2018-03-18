using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface IUserRepository
  {
    UserEntity GetById(int id);

    IEnumerable<UserEntity> GetAll();

    int Insert(UserEntity taskEntity);

    void Update(UserEntity taskEntity);

    bool Delete(UserEntity taskEntity);
  }
}
