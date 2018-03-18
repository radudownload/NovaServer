using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface IQualitativeAssayResultRepository
  {
    QualitativeAssayResultEntity GetById(int id);

    IEnumerable<QualitativeAssayResultEntity> GetAll();

    int Insert(QualitativeAssayResultEntity taskEntity);

    void Update(QualitativeAssayResultEntity taskEntity);

    bool Delete(QualitativeAssayResultEntity taskEntity);
  }
}
