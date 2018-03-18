using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;

namespace NovaServer.Repository
{
  public class ConnectionRepository : IConnectionRepository
  {
    #region Attributes

    private readonly IRepository<ConnectionEntity> _connectionRepository;

    #endregion Attributes


    #region Constructor

    public ConnectionRepository(IRepository<ConnectionEntity> connectionRepository)
    {
      _connectionRepository = connectionRepository;
    }

    #endregion Constructor


    #region Public Methods

    public bool Delete(ConnectionEntity connectionEntity)
    {
      _connectionRepository.Delete(connectionEntity);

      return true;
    }

    public IEnumerable<ConnectionEntity> GetAll()
    {
      return _connectionRepository.GetAll();
    }

    public ConnectionEntity GetById(int id)
    {
      return _connectionRepository.Get(id);
    }

    public int Insert(ConnectionEntity connectionEntity)
    {
      return _connectionRepository.Add(connectionEntity);
    }

    public void Update(ConnectionEntity connectionEntity)
    {
      _connectionRepository.Update(connectionEntity);
    }

    #endregion Public Methods
  }
}
