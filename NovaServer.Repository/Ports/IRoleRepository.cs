using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface IRoleRepository
  {
    List<RoleEntity> GetAll();
  }
}
