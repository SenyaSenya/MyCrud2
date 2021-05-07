using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using MyCrud2.OrdersModelCodeFirstDataModel;
using MyCrud2.Common;
using MyCrud2;

namespace MyCrud2.ViewModels {

    /// <summary>
    /// Represents the single Product object view model.
    /// </summary>
    public partial class ProductViewModel : SingleObjectViewModel<Product, int, IOrdersModelCodeFirstUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ProductViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProductViewModel Create(IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ProductViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProductViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProductViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProductViewModel(IUnitOfWorkFactory<IOrdersModelCodeFirstUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Product, x => x.ProductName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of OrderItem for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<OrderItem> LookUpOrderItem {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProductViewModel x) => x.LookUpOrderItem,
                    getRepositoryFunc: x => x.OrderItem);
            }
        }


        /// <summary>
        /// The view model for the ProductOrderItem detail collection.
        /// </summary>
        public CollectionViewModelBase<OrderItem, OrderItem, int, IOrdersModelCodeFirstUnitOfWork> ProductOrderItemDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ProductViewModel x) => x.ProductOrderItemDetails,
                    getRepositoryFunc: x => x.OrderItem,
                    foreignKeyExpression: x => x.ProductId,
                    navigationExpression: x => x.Product);
            }
        }
    }
}
