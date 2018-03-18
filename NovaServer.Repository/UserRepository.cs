using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;

namespace NovaServer.Repository
{
  public class UserRepository : IUserRepository
  {
    #region Attributes

    private readonly IRepository<UserEntity> _userRepository;

    #endregion Attributes


    #region Constructor

    public UserRepository(IRepository<UserEntity> userRepository)
    {
      _userRepository = userRepository;
    }

    #endregion Constructor


    #region Public Methods

    public bool Delete(UserEntity userEntity)
    {
      _userRepository.Delete(userEntity);

      return true;
    }

    public IEnumerable<UserEntity> GetAll()
    {
      return _userRepository.GetAll();
    }

    public UserEntity GetById(int id)
    {
      return _userRepository.Get(id);
    }

    public int Insert(UserEntity userEntity)
    {
      return _userRepository.Add(userEntity);
    }

    public void Update(UserEntity userEntity)
    {
      _userRepository.Update(userEntity);
    }

    #endregion Public Methods
  }
}
