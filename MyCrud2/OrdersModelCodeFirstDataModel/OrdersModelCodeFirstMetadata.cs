using DevExpress.Mvvm.DataAnnotations;
using MyCrud2;
using MyCrud2.Localization;

namespace MyCrud2.OrdersModelCodeFirstDataModel {

    public class OrdersModelCodeFirstMetadataProvider {
		        public static void BuildMetadata(MetadataBuilder<Customer> builder) {
			builder.DisplayName(OrdersModelCodeFirstResources.Customer);
						builder.Property(x => x.Id).DisplayName(OrdersModelCodeFirstResources.Customer_Id);
						builder.Property(x => x.CompanyName).DisplayName(OrdersModelCodeFirstResources.Customer_CompanyName);
						builder.Property(x => x.PersonName).DisplayName(OrdersModelCodeFirstResources.Customer_PersonName);
						builder.Property(x => x.CustomerCode).DisplayName(OrdersModelCodeFirstResources.Customer_CustomerCode);
			        }
		        public static void BuildMetadata(MetadataBuilder<Order> builder) {
			builder.DisplayName(OrdersModelCodeFirstResources.Order);
						builder.Property(x => x.Id).DisplayName(OrdersModelCodeFirstResources.Order_Id);
						builder.Property(x => x.OrderSubject).DisplayName(OrdersModelCodeFirstResources.Order_OrderSubject);
						builder.Property(x => x.OrderDate).DisplayName(OrdersModelCodeFirstResources.Order_OrderDate);
						builder.Property(x => x.SumPriceN).DisplayName(OrdersModelCodeFirstResources.Order_SumPriceN);
						builder.Property(x => x.SumPriceB).DisplayName(OrdersModelCodeFirstResources.Order_SumPriceB);
						builder.Property(x => x.Customer).DisplayName(OrdersModelCodeFirstResources.Order_Customer);
			        }
		        public static void BuildMetadata(MetadataBuilder<OrderItem> builder) {
			builder.DisplayName(OrdersModelCodeFirstResources.OrderItem);
						builder.Property(x => x.Id).DisplayName(OrdersModelCodeFirstResources.OrderItem_Id);
						builder.Property(x => x.Quantity).DisplayName(OrdersModelCodeFirstResources.OrderItem_Quantity);
						builder.Property(x => x.CountVAT).DisplayName(OrdersModelCodeFirstResources.OrderItem_CountVAT);
						builder.Property(x => x.UnitPriceB).DisplayName(OrdersModelCodeFirstResources.OrderItem_UnitPriceB);
						builder.Property(x => x.Order).DisplayName(OrdersModelCodeFirstResources.OrderItem_Order);
						builder.Property(x => x.Product).DisplayName(OrdersModelCodeFirstResources.OrderItem_Product);
			        }
		        public static void BuildMetadata(MetadataBuilder<Product> builder) {
			builder.DisplayName(OrdersModelCodeFirstResources.Product);
						builder.Property(x => x.Id).DisplayName(OrdersModelCodeFirstResources.Product_Id);
						builder.Property(x => x.ProductName).DisplayName(OrdersModelCodeFirstResources.Product_ProductName);
						builder.Property(x => x.ProductCode).DisplayName(OrdersModelCodeFirstResources.Product_ProductCode);
						builder.Property(x => x.UnitPriceN).DisplayName(OrdersModelCodeFirstResources.Product_UnitPriceN);
			        }
		    }
}