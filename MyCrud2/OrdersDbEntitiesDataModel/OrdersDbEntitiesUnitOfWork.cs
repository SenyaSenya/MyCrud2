using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;

namespace MyCrud2.OrdersDbEntitiesDataModel {

    /// <summary>
    /// A OrdersDbEntitiesUnitOfWork instance that represents the run-time implementation of the IOrdersDbEntitiesUnitOfWork interface.
    /// </summary>
    public class OrdersDbEntitiesUnitOfWork : DbUnitOfWork<OrdersDbEntities>, IOrdersDbEntitiesUnitOfWork {

        public OrdersDbEntitiesUnitOfWork(Func<OrdersDbEntities> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Customer, int> IOrdersDbEntitiesUnitOfWork.Customers {
            get { return GetRepository(x => x.Set<Customer>(), (Customer x) => x.Id); }
        }

        IRepository<OrderItem, int> IOrdersDbEntitiesUnitOfWork.OrderItems {
            get { return GetRepository(x => x.Set<OrderItem>(), (OrderItem x) => x.Id); }
        }

        IRepository<Order, int> IOrdersDbEntitiesUnitOfWork.Orders {
            get { return GetRepository(x => x.Set<Order>(), (Order x) => x.Id); }
        }

        IRepository<Product, int> IOrdersDbEntitiesUnitOfWork.Products {
            get { return GetRepository(x => x.Set<Product>(), (Product x) => x.Id); }
        }
    }
}
