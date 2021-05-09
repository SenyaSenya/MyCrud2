using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;

namespace MyCrud2.OrdersModelCodeFirstDataModel {

    /// <summary>
    /// A OrdersModelCodeFirstDesignTimeUnitOfWork instance that represents the design-time implementation of the IOrdersModelCodeFirstUnitOfWork interface.
    /// </summary>
    public class OrdersModelCodeFirstDesignTimeUnitOfWork : DesignTimeUnitOfWork, IOrdersModelCodeFirstUnitOfWork {

        /// <summary>
        /// Initializes a new instance of the OrdersModelCodeFirstDesignTimeUnitOfWork class.
        /// </summary>
        public OrdersModelCodeFirstDesignTimeUnitOfWork() {
        }

        IRepository<Customer, int> IOrdersModelCodeFirstUnitOfWork.Customer {
            get { return GetRepository((Customer x) => x.Id); }
        }

        IRepository<Order, int> IOrdersModelCodeFirstUnitOfWork.Order {
            get { return GetRepository((Order x) => x.Id); }
        }

        IRepository<OrderItem, int> IOrdersModelCodeFirstUnitOfWork.OrderItem {
            get { return GetRepository((OrderItem x) => x.Id); }
        }

        IRepository<Product, int> IOrdersModelCodeFirstUnitOfWork.Product {
            get { return GetRepository((Product x) => x.Id); }
        }
    }
}
