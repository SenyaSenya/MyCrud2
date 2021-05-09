using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using MyCrud2.OrdersModelCodeFirstDataModel;
using MyCrud2.Common;

namespace MyCrud2.ViewModels {

    /// <summary>
    /// Represents the single Order object view model.
    /// </summary>
    public partial class OrderViewModel : SingleObjectViewModel<Order, int, IOrdersModelCodeFirstUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OrderViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OrderViewModel Create(IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OrderViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OrderViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrderViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OrderViewModel(IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Order, x => x.OrderSubject) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Customer for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Customer> LookUpCustomer {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderViewModel x) => x.LookUpCustomer,
                    getRepositoryFunc: x => x.Customer);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of OrderItem for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<OrderItem> LookUpOrderItem {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderViewModel x) => x.LookUpOrderItem,
                    getRepositoryFunc: x => x.OrderItem);
            }
        }


        /// <summary>
        /// The view model for the OrderOrderItem detail collection.
        /// </summary>
        public CollectionViewModelBase<OrderItem, OrderItem, int, IOrdersModelCodeFirstUnitOfWork> OrderOrderItemDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (OrderViewModel x) => x.OrderOrderItemDetails,
                    getRepositoryFunc: x => x.OrderItem,
                    foreignKeyExpression: x => x.OrderId,
                    navigationExpression: x => x.Order);
            }
        }
    }
}
