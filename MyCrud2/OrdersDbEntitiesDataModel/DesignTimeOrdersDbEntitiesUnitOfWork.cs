using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;

namespace MyCrud2.OrdersDbEntitiesDataModel {

    /// <summary>
    /// A OrdersDbEntitiesDesignTimeUnitOfWork instance that represents the design-time implementation of the IOrdersDbEntitiesUnitOfWork interface.
    /// </summary>
    public class OrdersDbEntitiesDesignTimeUnitOfWork : DesignTimeUnitOfWork, IOrdersDbEntitiesUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the OrdersDbEntitiesDesignTimeUnitOfWork class.
        /// </summary>
        public OrdersDbEntitiesDesignTimeUnitOfWork() {
        }

        IRepository<Customer, int> IOrdersDbEntitiesUnitOfWork.Customers {
            get { return GetRepository((Customer x) => x.Id); }
        }

        IRepository<OrderItem, int> IOrdersDbEntitiesUnitOfWork.OrderItems {
            get { return GetRepository((OrderItem x) => x.Id); }
        }

        IRepository<Order, int> IOrdersDbEntitiesUnitOfWork.Orders {
            get { return GetRepository((Order x) => x.Id); }
        }

        IRepository<Product, int> IOrdersDbEntitiesUnitOfWork.Products {
            get { return GetRepository((Product x) => x.Id); }
        }
    }
}
