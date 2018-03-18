using NovaServer.Repository.Entity;
using NovaServer.Repository.Ports;
using NovaServer.Repository.Repo;
using System.Collections.Generic;

namespace NovaServer.Repository
{
  public class OrderRepository : IOrderRepository
  {
    #region Attributes

    private readonly IRepository<OrderEntity> _orderRepository;

    #endregion Attributes


    #region Constructor

    public OrderRepository(IRepository<OrderEntity> orderRepository)
    {
      _orderRepository = orderRepository;
    }

    #endregion Constructor


    #region Public Methods

    public bool Delete(OrderEntity orderEntity)
    {
      _orderRepository.Delete(orderEntity);

      return true;
    }

    public IEnumerable<OrderEntity> GetAll()
    {
      return _orderRepository.GetAll();
    }

    public OrderEntity GetById(int id)
    {
      return _orderRepository.Get(id);
    }

    public int Insert(OrderEntity orderEntity)
    {
      return _orderRepository.Add(orderEntity);
    }

    public void Update(OrderEntity orderEntity)
    {
      _orderRepository.Update(orderEntity);
    }

    #endregion Public Methods
  }
}
