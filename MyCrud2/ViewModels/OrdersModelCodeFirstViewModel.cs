using System;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using MyCrud2.Localization;
using MyCrud2.OrdersModelCodeFirstDataModel;

namespace MyCrud2.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the OrdersModelCodeFirst data model.
    /// </summary>
    public partial class OrdersModelCodeFirstViewModel : DocumentsViewModel<OrdersModelCodeFirstModuleDescription, IOrdersModelCodeFirstUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of OrdersModelCodeFirstViewModel as a POCO view model.
        /// </summary>
        public static OrdersModelCodeFirstViewModel Create() {
            return ViewModelSource.Create(() => new OrdersModelCodeFirstViewModel());
        }

		        static OrdersModelCodeFirstViewModel() {
            MetadataLocator.Default = MetadataLocator.Create().AddMetadata<OrdersModelCodeFirstMetadataProvider>();
        }
        /// <summary>
        /// Initializes a new instance of the OrdersModelCodeFirstViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the OrdersModelCodeFirstViewModel type without the POCO proxy factory.
        /// </summary>
        protected OrdersModelCodeFirstViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override OrdersModelCodeFirstModuleDescription[] CreateModules() {
			return new OrdersModelCodeFirstModuleDescription[] {
                new OrdersModelCodeFirstModuleDescription(OrdersModelCodeFirstResources.CustomerPlural, "CustomerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customer)),
                new OrdersModelCodeFirstModuleDescription(OrdersModelCodeFirstResources.OrderPlural, "OrderCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Order)),
                new OrdersModelCodeFirstModuleDescription(OrdersModelCodeFirstResources.OrderItemPlural, "OrderItemCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.OrderItem)),
                new OrdersModelCodeFirstModuleDescription(OrdersModelCodeFirstResources.ProductPlural, "ProductCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Product)),
			};
        }
                		protected override void OnActiveModuleChanged(OrdersModelCodeFirstModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class OrdersModelCodeFirstModuleDescription : ModuleDescription<OrdersModelCodeFirstModuleDescription> {
        public OrdersModelCodeFirstModuleDescription(string title, string documentType, string group, Func<OrdersModelCodeFirstModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}