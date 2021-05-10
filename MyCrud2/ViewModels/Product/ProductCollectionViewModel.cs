using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using MyCrud2.OrdersDbEntitiesDataModel;
using MyCrud2.Common;

namespace MyCrud2.ViewModels {

    /// <summary>
    /// Represents the Products collection view model.
    /// </summary>
    public partial class ProductCollectionViewModel : CollectionViewModel<Product, int, IOrdersDbEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ProductCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProductCollectionViewModel Create(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ProductCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProductCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProductCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProductCollectionViewModel(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Products) {
        }
    }
}