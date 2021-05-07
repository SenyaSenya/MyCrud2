using DevExpress.Mvvm.DataModel;
using MyCrud2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCrud2.OrdersModelCodeFirstDataModel {

    /// <summary>
    /// IOrdersModelCodeFirstUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IOrdersModelCodeFirstUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Customer entities repository.
        /// </summary>
		IRepository<Customer, int> Customer { get; }
        
        /// <summary>
        /// The Order entities repository.
        /// </summary>
		IRepository<Order, int> Order { get; }
        
        /// <summary>
        /// The OrderItem entities repository.
        /// </summary>
		IRepository<OrderItem, int> OrderItem { get; }
        
        /// <summary>
        /// The Product entities repository.
        /// </summary>
		IRepository<Product, int> Product { get; }
    }
}
