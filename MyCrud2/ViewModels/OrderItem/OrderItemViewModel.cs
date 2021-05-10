using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using MyCrud2.OrdersDbEntitiesDataModel;
using MyCrud2.Common;

namespace MyCrud2.ViewModels {

    /// <summary>
    /// Represents the single OrderItem object view model.
    /// </summary>
    public partial class OrderItemViewModel : SingleObjectViewModel<OrderItem, int, IOrdersDbEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OrderItemViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OrderItemViewModel Create(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OrderItemViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OrderItemViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrderItemViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OrderItemViewModel(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.OrderItems, x => x.Id) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrders {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderItemViewModel x) => x.LookUpOrders,
                    getRepositoryFunc: x => x.Orders);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Products for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Product> LookUpProducts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderItemViewModel x) => x.LookUpProducts,
                    getRepositoryFunc: x => x.Products);
            }
        }

    }
}
