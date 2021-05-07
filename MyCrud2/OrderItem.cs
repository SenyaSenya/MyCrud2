namespace MyCrud2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderItem")]
    public partial class OrderItem
    {
        public int Id { get; set; }

        public int? Quantity { get; set; }

        public int? CountVAT { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPriceB { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
