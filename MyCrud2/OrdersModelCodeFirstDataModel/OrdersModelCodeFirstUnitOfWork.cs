using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using System;

namespace MyCrud2.OrdersModelCodeFirstDataModel {

    /// <summary>
    /// A OrdersModelCodeFirstUnitOfWork instance that represents the run-time implementation of the IOrdersModelCodeFirstUnitOfWork interface.
    /// </summary>
    public class OrdersModelCodeFirstUnitOfWork : DbUnitOfWork<OrdersModelCodeFirst>, IOrdersModelCodeFirstUnitOfWork {

        public OrdersModelCodeFirstUnitOfWork(Func<OrdersModelCodeFirst> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Customer, int> IOrdersModelCodeFirstUnitOfWork.Customer {
            get { return GetRepository(x => x.Set<Customer>(), (Customer x) => x.Id); }
        }

        IRepository<Order, int> IOrdersModelCodeFirstUnitOfWork.Order {
            get { return GetRepository(x => x.Set<Order>(), (Order x) => x.Id); }
        }

        IRepository<OrderItem, int> IOrdersModelCodeFirstUnitOfWork.OrderItem {
            get { return GetRepository(x => x.Set<OrderItem>(), (OrderItem x) => x.Id); }
        }

        IRepository<Product, int> IOrdersModelCodeFirstUnitOfWork.Product {
            get { return GetRepository(x => x.Set<Product>(), (Product x) => x.Id); }
        }
    }
}
