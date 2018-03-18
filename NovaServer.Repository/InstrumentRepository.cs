using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;

namespace NovaServer.Repository
{
  public class InstrumentRepository : IInstrumentRepository
  {
    #region Attributes

    private readonly IRepository<InstrumentEntity> _instrumentRepository;

    #endregion Attributes


    #region Constructor

    public InstrumentRepository(IRepository<InstrumentEntity> instrumentRepository)
    {
      _instrumentRepository = instrumentRepository;
    }

    #endregion Constructor


    #region Public Methods

    public bool Delete(InstrumentEntity instrumentEntity)
    {
      _instrumentRepository.Delete(instrumentEntity);

      return true;
    }

    public IEnumerable<InstrumentEntity> GetAll()
    {
      return _instrumentRepository.GetAll();
    }

    public InstrumentEntity GetById(int id)
    {
      return _instrumentRepository.Get(id);
    }

    public int Insert(InstrumentEntity instrumentEntity)
    {
      return _instrumentRepository.Add(instrumentEntity);
    }

    public void Update(InstrumentEntity instrumentEntity)
    {
      _instrumentRepository.Update(instrumentEntity);
    }

    #endregion Public Methods
  }
}
