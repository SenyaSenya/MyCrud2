using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using MyCrud2.OrdersModelCodeFirstDataModel;
using MyCrud2.Common;

namespace MyCrud2.ViewModels {

    /// <summary>
    /// Represents the single Customer object view model.
    /// </summary>
    public partial class CustomerViewModel : SingleObjectViewModel<Customer, int, IOrdersModelCodeFirstUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerViewModel Create(IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerViewModel(IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customer, x => x.CompanyName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Order for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrder {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomerViewModel x) => x.LookUpOrder,
                    getRepositoryFunc: x => x.Order);
            }
        }


        /// <summary>
        /// The view model for the CustomerOrder detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, int, IOrdersModelCodeFirstUnitOfWork> CustomerOrderDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomerViewModel x) => x.CustomerOrderDetails,
                    getRepositoryFunc: x => x.Order,
                    foreignKeyExpression: x => x.CustomerId,
                    navigationExpression: x => x.Customer);
            }
        }
    }
}
