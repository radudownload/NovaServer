using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;

namespace NovaServer.Repository
{
  public class PasswordRepository : IPasswordRepository
  {
    #region Attributes

    private readonly IRepository<PasswordEntity> _passwordRepository;

    #endregion Attributes


    #region Constructor

    public PasswordRepository(IRepository<PasswordEntity> passwordRepository)
    {
      _passwordRepository = passwordRepository;
    }

    #endregion Constructor


    #region Public Methods

    public bool Delete(PasswordEntity passwordEntity)
    {
      _passwordRepository.Delete(passwordEntity);

      return true;
    }

    public IEnumerable<PasswordEntity> GetAll()
    {
      return _passwordRepository.GetAll();
    }

    public PasswordEntity GetById(int id)
    {
      return _passwordRepository.Get(id);
    }

    public int Insert(PasswordEntity passwordEntity)
    {
      return _passwordRepository.Add(passwordEntity);
    }

    public void Update(PasswordEntity passwordEntity)
    {
      _passwordRepository.Update(passwordEntity);
    }

    #endregion Public Methods
  }
}
