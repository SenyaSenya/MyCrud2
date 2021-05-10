using DevExpress.Mvvm.DataModel;

namespace MyCrud2.OrdersDbEntitiesDataModel {

    /// <summary>
    /// IOrdersDbEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IOrdersDbEntitiesUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Customer entities repository.
        /// </summary>
		IRepository<Customer, int> Customers { get; }
        
        /// <summary>
        /// The OrderItem entities repository.
        /// </summary>
		IRepository<OrderItem, int> OrderItems { get; }
        
        /// <summary>
        /// The Order entities repository.
        /// </summary>
		IRepository<Order, int> Orders { get; }
        
        /// <summary>
        /// The Product entities repository.
        /// </summary>
		IRepository<Product, int> Products { get; }
    }
}
