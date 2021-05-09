using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using MyCrud2.OrdersModelCodeFirstDataModel;
using MyCrud2.Common;

namespace MyCrud2.ViewModels {

    /// <summary>
    /// Represents the single OrderItem object view model.
    /// </summary>
    public partial class OrderItemViewModel : SingleObjectViewModel<OrderItem, int, IOrdersModelCodeFirstUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OrderItemViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OrderItemViewModel Create(IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OrderItemViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OrderItemViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrderItemViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OrderItemViewModel(IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.OrderItem, x => x.Id) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Order for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrder {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderItemViewModel x) => x.LookUpOrder,
                    getRepositoryFunc: x => x.Order);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Product for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Product> LookUpProduct {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (OrderItemViewModel x) => x.LookUpProduct,
                    getRepositoryFunc: x => x.Product);
            }
        }

    }
}
