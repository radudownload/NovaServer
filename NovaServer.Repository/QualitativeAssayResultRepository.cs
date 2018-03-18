using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;

namespace NovaServer.Repository
{
  public class QualitativeAssayResultRepository : IQualitativeAssayResultRepository
  {
    #region Attributes

    private readonly IRepository<QualitativeAssayResultEntity> _qualitativeAssayResultRepository;

    #endregion Attributes


    #region Constructor

    public QualitativeAssayResultRepository(IRepository<QualitativeAssayResultEntity> qualitativeAssayResultRepository)
    {
      _qualitativeAssayResultRepository = qualitativeAssayResultRepository;
    }

    #endregion Constructor


    #region Public Methods
    //    QualitativeAssayResult
    //    qualitativeAssayResult

    public bool Delete(QualitativeAssayResultEntity qualitativeAssayResultEntity)
    {
      _qualitativeAssayResultRepository.Delete(qualitativeAssayResultEntity);

      return true;
    }

    public IEnumerable<QualitativeAssayResultEntity> GetAll()
    {
      return _qualitativeAssayResultRepository.GetAll();
    }

    public QualitativeAssayResultEntity GetById(int id)
    {
      return _qualitativeAssayResultRepository.Get(id);
    }

    public int Insert(QualitativeAssayResultEntity qualitativeAssayResultEntity)
    {
      return _qualitativeAssayResultRepository.Add(qualitativeAssayResultEntity);
    }

    public void Update(QualitativeAssayResultEntity qualitativeAssayResultEntity)
    {
      _qualitativeAssayResultRepository.Update(qualitativeAssayResultEntity);
    }

    #endregion Public Methods
  }
}
