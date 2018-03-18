using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;

namespace NovaServer.Repository
{
  public class LisRepository : ILisRepository
  {
    #region Attributes

    private readonly IRepository<LisEntity> _lisRepository;

    #endregion Attributes


    #region Constructor

    public LisRepository(IRepository<LisEntity> lisRepository)
    {
      _lisRepository = lisRepository;
    }

    #endregion Constructor


    #region Public Methods

    public bool Delete(LisEntity lisEntity)
    {
      _lisRepository.Delete(lisEntity);

      return true;
    }

    public IEnumerable<LisEntity> GetAll()
    {
      return _lisRepository.GetAll();
    }

    public LisEntity GetById(int id)
    {
      return _lisRepository.Get(id);
    }

    public int Insert(LisEntity lisEntity)
    {
      return _lisRepository.Add(lisEntity);
    }

    public void Update(LisEntity lisEntity)
    {
      _lisRepository.Update(lisEntity);
    }

    #endregion Public Methods
  }
}
