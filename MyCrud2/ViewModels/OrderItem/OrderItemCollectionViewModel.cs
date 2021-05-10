using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using MyCrud2.OrdersDbEntitiesDataModel;
using MyCrud2.Common;

namespace MyCrud2.ViewModels {

    /// <summary>
    /// Represents the OrderItems collection view model.
    /// </summary>
    public partial class OrderItemCollectionViewModel : CollectionViewModel<OrderItem, int, IOrdersDbEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OrderItemCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OrderItemCollectionViewModel Create(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OrderItemCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OrderItemCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrderItemCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OrderItemCollectionViewModel(IUnitOfWorkFactory<IOrdersDbEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.OrderItems) {
        }
    }
}