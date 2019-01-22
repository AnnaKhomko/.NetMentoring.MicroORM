using LinqToDB.Mapping;

namespace MicroORM.Model
{
	/// <summary>
	/// Order Datails table model
	/// </summary>
	[Table("Order Details")]
	public class OrderDetail
	{
		/// <summary>
		/// Gets or sets the order identifier.
		/// </summary>
		/// <value>
		/// The order identifier.
		/// </value>
		[Column("OrderID")]
		[PrimaryKey]
		public int OrderId { get; set; }

		/// <summary>
		/// Gets or sets the product identifier.
		/// </summary>
		/// <value>
		/// The product identifier.
		/// </value>
		[Column("ProductID")]
		[PrimaryKey]
		public int ProductId { get; set; }

		/// <summary>
		/// Gets or sets the product.
		/// </summary>
		/// <value>
		/// The product.
		/// </value>
		[Association(ThisKey = "ProductId", OtherKey = "ProductId")]
		public Product Product { get; set; }

		/// <summary>
		/// Gets or sets the order.
		/// </summary>
		/// <value>
		/// The order.
		/// </value>
		[Association(ThisKey = "OrderId", OtherKey = "OrderId")]
		public Order Order { get; set; }
	}
}
