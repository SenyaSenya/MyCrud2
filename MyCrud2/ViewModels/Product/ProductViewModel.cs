using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using MyCrud2.OrdersDbEntitiesDataModel;
using MyCrud2.Common;

namespace MyCrud2.ViewModels {

    /// <summary>
    /// Represents the single Product object view model.
    /// </summary>
    public partial class ProductViewModel : SingleObjectViewModel<Product, int, IOrdersDbEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ProductViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProductViewModel Create(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ProductViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProductViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProductViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProductViewModel(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Products, x => x.ProductName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of OrderItems for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<OrderItem> LookUpOrderItems {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProductViewModel x) => x.LookUpOrderItems,
                    getRepositoryFunc: x => x.OrderItems);
            }
        }


        /// <summary>
        /// The view model for the ProductOrderItems detail collection.
        /// </summary>
        public CollectionViewModelBase<OrderItem, OrderItem, int, IOrdersDbEntitiesUnitOfWork> ProductOrderItemsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ProductViewModel x) => x.ProductOrderItemsDetails,
                    getRepositoryFunc: x => x.OrderItems,
                    foreignKeyExpression: x => x.ProductId,
                    navigationExpression: x => x.Product);
            }
        }
    }
}
