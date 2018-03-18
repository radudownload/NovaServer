using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;
using System.Linq;

namespace NovaServer.Repository
{
  public class ResultStatusRepository : IResultStatusRepository
  {
    #region Attributes

    private readonly IRepository<ResultStatusEntity> _resultStatusRepository;

    #endregion Attributes


    #region Constructor

    public ResultStatusRepository(IRepository<ResultStatusEntity> resultStatusRepository)
    {
      _resultStatusRepository = resultStatusRepository;
    }

    #endregion Constructor


    #region Public Methods

    public List<ResultStatusEntity> GetAll()
    {
      return _resultStatusRepository.GetAll().ToList();
    }

    #endregion Public Methods
  }
}
