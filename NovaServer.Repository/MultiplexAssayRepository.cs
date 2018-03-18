using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;

namespace NovaServer.Repository
{
  public class MultiplexAssayRepository : IMultiplexAssayRepository
  {
    #region Attributes

    private readonly IRepository<MultiplexAssayEntity> _multiplexAssayRepository;

    #endregion Attributes


    #region Constructor

    public MultiplexAssayRepository(IRepository<MultiplexAssayEntity> multiplexAssayRepository)
    {
      _multiplexAssayRepository = multiplexAssayRepository;
    }

    #endregion Constructor


    #region Public Methods

    public bool Delete(MultiplexAssayEntity multiplexAssayEntity)
    {
      _multiplexAssayRepository.Delete(multiplexAssayEntity);

      return true;
    }

    public IEnumerable<MultiplexAssayEntity> GetAll()
    {
      return _multiplexAssayRepository.GetAll();
    }

    public MultiplexAssayEntity GetById(int id)
    {
      return _multiplexAssayRepository.Get(id);
    }

    public int Insert(MultiplexAssayEntity multiplexAssayEntity)
    {
      return _multiplexAssayRepository.Add(multiplexAssayEntity);
    }

    public void Update(MultiplexAssayEntity multiplexAssayEntity)
    {
      _multiplexAssayRepository.Update(multiplexAssayEntity);
    }

    #endregion Public Methods
  }
}
