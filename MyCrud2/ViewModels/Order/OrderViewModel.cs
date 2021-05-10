using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using MyCrud2.OrdersDbEntitiesDataModel;
using MyCrud2.Common;

namespace MyCrud2.ViewModels {

    /// <summary>
    /// Represents the single Order object view model.
    /// </summary>
    public partial class OrderViewModel : SingleObjectViewModel<Order, int, IOrdersDbEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OrderViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OrderViewModel Create(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OrderViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OrderViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrderViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OrderViewModel(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Orders, x => x.OrderSubject) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of OrderItems for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<OrderItem> LookUpOrderItems {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderViewModel x) => x.LookUpOrderItems,
                    getRepositoryFunc: x => x.OrderItems);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Customers for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer> LookUpCustomers {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderViewModel x) => x.LookUpCustomers,
                    getRepositoryFunc: x => x.Customers);
            }
        }


        /// <summary>
        /// The view model for the OrderOrderItems detail collection.
        /// </summary>
        public CollectionViewModelBase<OrderItem, OrderItem, int, IOrdersDbEntitiesUnitOfWork> OrderOrderItemsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (OrderViewModel x) => x.OrderOrderItemsDetails,
                    getRepositoryFunc: x => x.OrderItems,
                    foreignKeyExpression: x => x.OrderId,
                    navigationExpression: x => x.Order);
            }
        }
    }
}
