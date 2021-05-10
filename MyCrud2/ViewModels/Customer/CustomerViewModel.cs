using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using MyCrud2.OrdersDbEntitiesDataModel;
using MyCrud2.Common;

namespace MyCrud2.ViewModels {

    /// <summary>
    /// Represents the single Customer object view model.
    /// </summary>
    public partial class CustomerViewModel : SingleObjectViewModel<Customer, int, IOrdersDbEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerViewModel Create(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerViewModel(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customers, x => x.CompanyName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Orders for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Order> LookUpOrders {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomerViewModel x) => x.LookUpOrders,
                    getRepositoryFunc: x => x.Orders);
            }
        }


        /// <summary>
        /// The view model for the CustomerOrders detail collection.
        /// </summary>
        public CollectionViewModelBase<Order, Order, int, IOrdersDbEntitiesUnitOfWork> CustomerOrdersDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomerViewModel x) => x.CustomerOrdersDetails,
                    getRepositoryFunc: x => x.Orders,
                    foreignKeyExpression: x => x.CustomerId,
                    navigationExpression: x => x.Customer);
            }
        }
    }
}
