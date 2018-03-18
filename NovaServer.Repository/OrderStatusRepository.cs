using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;
using System.Linq;

namespace NovaServer.Repository
{
  public class OrderStatusRepository : IOrderStatusRepository
  {
    #region Attributes

    private readonly IRepository<OrderStatusEntity> _orderStatusRepository;

    #endregion Attributes


    #region Constructor

    public OrderStatusRepository(IRepository<OrderStatusEntity> orderStatusRepository)
    {
      _orderStatusRepository = orderStatusRepository;
    }

    #endregion Constructor


    #region Public Methods

    public List<OrderStatusEntity> GetAll()
    {
      return _orderStatusRepository.GetAll().ToList();
    }

    #endregion Public Methods
  }
}
