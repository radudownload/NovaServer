using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;

namespace NovaServer.Repository
{
  public class AssayRepository : IAssayRepository
  {
    #region Attributes

    private readonly IRepository<AssayEntity> _assayRepository;

    #endregion Attributes


    #region Constructor

    public AssayRepository(IRepository<AssayEntity> assayRepository)
    {
      _assayRepository = assayRepository;
    }

    #endregion Constructor


    #region Public Methods

    public bool Delete(AssayEntity assayEntity)
    {
      _assayRepository.Delete(assayEntity);

      return true;
    }

    public IEnumerable<AssayEntity> GetAll()
    {
      return _assayRepository.GetAll();
    }

    public AssayEntity GetById(int id)
    {
      return _assayRepository.Get(id);
    }

    public int Insert(AssayEntity assayEntity)
    {
      return _assayRepository.Add(assayEntity);
    }

    public void Update(AssayEntity assayEntity)
    {
      _assayRepository.Update(assayEntity);
    }

    #endregion Public Methods
  }
}
