using NovaServer.Repository.Entity;
using System.Collections.Generic;

namespace NovaServer.Repository.Ports
{
  public interface IOrderRepository
  {
    OrderEntity GetById(int id);

    IEnumerable<OrderEntity> GetAll();

    int Insert(OrderEntity taskEntity);

    void Update(OrderEntity taskEntity);

    bool Delete(OrderEntity taskEntity);
  }
}
