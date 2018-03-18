using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;
using System.Linq;

namespace NovaServer.Repository
{
  public class RoleRepository : IRoleRepository
  {
    #region Attributes

    private readonly IRepository<RoleEntity> _roleRepository;

    #endregion Attributes


    #region Constructor

    public RoleRepository(IRepository<RoleEntity> roleRepository)
    {
      _roleRepository = roleRepository;
    }

    #endregion Constructor


    #region Public Methods

    public List<RoleEntity> GetAll()
    {
      return _roleRepository.GetAll().ToList();
    }

    #endregion Public Methods
  }
}
