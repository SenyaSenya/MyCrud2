using DevExpress.Mvvm.DataAnnotations;
using MyCrud2.Localization;

namespace MyCrud2.OrdersDbEntitiesDataModel {

    public class OrdersDbEntitiesMetadataProvider {
		        public static void BuildMetadata(MetadataBuilder<Customer> builder) {
			builder.DisplayName(OrdersDbEntitiesResources.Customer);
						builder.Property(x => x.Id).DisplayName(OrdersDbEntitiesResources.Customer_Id);
						builder.Property(x => x.CompanyName).DisplayName(OrdersDbEntitiesResources.Customer_CompanyName);
						builder.Property(x => x.PersonName).DisplayName(OrdersDbEntitiesResources.Customer_PersonName);
						builder.Property(x => x.CustomerCode).DisplayName(OrdersDbEntitiesResources.Customer_CustomerCode);
			        }
		        public static void BuildMetadata(MetadataBuilder<OrderItem> builder) {
			builder.DisplayName(OrdersDbEntitiesResources.OrderItem);
						builder.Property(x => x.Id).DisplayName(OrdersDbEntitiesResources.OrderItem_Id);
						builder.Property(x => x.Quantity).DisplayName(OrdersDbEntitiesResources.OrderItem_Quantity);
						builder.Property(x => x.CountVAT).DisplayName(OrdersDbEntitiesResources.OrderItem_CountVAT);
						builder.Property(x => x.UnitPriceB).DisplayName(OrdersDbEntitiesResources.OrderItem_UnitPriceB);
						builder.Property(x => x.Order).DisplayName(OrdersDbEntitiesResources.OrderItem_Order);
						builder.Property(x => x.Product).DisplayName(OrdersDbEntitiesResources.OrderItem_Product);
			        }
		        public static void BuildMetadata(MetadataBuilder<Order> builder) {
			builder.DisplayName(OrdersDbEntitiesResources.Order);
						builder.Property(x => x.Id).DisplayName(OrdersDbEntitiesResources.Order_Id);
						builder.Property(x => x.OrderSubject).DisplayName(OrdersDbEntitiesResources.Order_OrderSubject);
						builder.Property(x => x.OrderDate).DisplayName(OrdersDbEntitiesResources.Order_OrderDate);
						builder.Property(x => x.SumPriceN).DisplayName(OrdersDbEntitiesResources.Order_SumPriceN);
						builder.Property(x => x.SumPriceB).DisplayName(OrdersDbEntitiesResources.Order_SumPriceB);
						builder.Property(x => x.Customer).DisplayName(OrdersDbEntitiesResources.Order_Customer);
			        }
		        public static void BuildMetadata(MetadataBuilder<Product> builder) {
			builder.DisplayName(OrdersDbEntitiesResources.Product);
						builder.Property(x => x.Id).DisplayName(OrdersDbEntitiesResources.Product_Id);
						builder.Property(x => x.ProductName).DisplayName(OrdersDbEntitiesResources.Product_ProductName);
						builder.Property(x => x.ProductCode).DisplayName(OrdersDbEntitiesResources.Product_ProductCode);
						builder.Property(x => x.UnitPriceN).DisplayName(OrdersDbEntitiesResources.Product_UnitPriceN);
			        }
		    }
}