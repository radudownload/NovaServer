using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;

namespace NovaServer.Repository
{
  public class ResultRepository : IResultRepository
  {
    #region Attributes

    private readonly IRepository<ResultEntity> _resultRepository;

    #endregion Attributes


    #region Constructor

    public ResultRepository(IRepository<ResultEntity> resultRepository)
    {
      _resultRepository = resultRepository;
    }

    #endregion Constructor


    #region Public Methods

    public bool Delete(ResultEntity resultEntity)
    {
      _resultRepository.Delete(resultEntity);

      return true;
    }

    public IEnumerable<ResultEntity> GetAll()
    {
      return _resultRepository.GetAll();
    }

    public ResultEntity GetById(int id)
    {
      return _resultRepository.Get(id);
    }

    public int Insert(ResultEntity resultEntity)
    {
      return _resultRepository.Add(resultEntity);
    }

    public void Update(ResultEntity resultEntity)
    {
      _resultRepository.Update(resultEntity);
    }

    #endregion Public Methods
  }
}
