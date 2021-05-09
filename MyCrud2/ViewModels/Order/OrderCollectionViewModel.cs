using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using MyCrud2.OrdersModelCodeFirstDataModel;
using MyCrud2.Common;

namespace MyCrud2.ViewModels {

    /// <summary>
    /// Represents the Order collection view model.
    /// </summary>
    public partial class OrderCollectionViewModel : CollectionViewModel<Order, int, IOrdersModelCodeFirstUnitOfWork> {

        /// <summary>
        /// Creates a new instance of OrderCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static OrderCollectionViewModel Create(IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new OrderCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the OrderCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrderCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected OrderCollectionViewModel(IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Order) {
        }
    }
}