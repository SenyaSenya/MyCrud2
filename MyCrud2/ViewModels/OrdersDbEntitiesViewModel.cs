using System;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using MyCrud2.Localization;
using MyCrud2.OrdersDbEntitiesDataModel;

namespace MyCrud2.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the OrdersDbEntities data model.
    /// </summary>
    public partial class OrdersDbEntitiesViewModel : DocumentsViewModel<OrdersDbEntitiesModuleDescription, IOrdersDbEntitiesUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of OrdersDbEntitiesViewModel as a POCO view model.
        /// </summary>
        public static OrdersDbEntitiesViewModel Create() {
            return ViewModelSource.Create(() => new OrdersDbEntitiesViewModel());
        }

		        static OrdersDbEntitiesViewModel() {
            MetadataLocator.Default = MetadataLocator.Create().AddMetadata<OrdersDbEntitiesMetadataProvider>();
        }
        /// <summary>
        /// Initializes a new instance of the OrdersDbEntitiesViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrdersDbEntitiesViewModel type without the POCO proxy factory.
        /// </summary>
        protected OrdersDbEntitiesViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override OrdersDbEntitiesModuleDescription[] CreateModules() {
			return new OrdersDbEntitiesModuleDescription[] {
                new OrdersDbEntitiesModuleDescription(OrdersDbEntitiesResources.CustomerPlural, "CustomerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customers)),
                new OrdersDbEntitiesModuleDescription(OrdersDbEntitiesResources.OrderItemPlural, "OrderItemCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.OrderItems)),
                new OrdersDbEntitiesModuleDescription(OrdersDbEntitiesResources.OrderPlural, "OrderCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Orders)),
                new OrdersDbEntitiesModuleDescription(OrdersDbEntitiesResources.ProductPlural, "ProductCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Products)),
			};
        }
                		protected override void OnActiveModuleChanged(OrdersDbEntitiesModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class OrdersDbEntitiesModuleDescription : ModuleDescription<OrdersDbEntitiesModuleDescription> {
        public OrdersDbEntitiesModuleDescription(string title, string documentType, string group, Func<OrdersDbEntitiesModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}