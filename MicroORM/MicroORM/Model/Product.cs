using LinqToDB.Mapping;

namespace MicroORM.Model
{
	/// <summary>
	/// Products table model
	/// </summary>
	[Table("Products")]
	public class Product
	{
		/// <summary>
		/// Gets or sets the product identifier.
		/// </summary>
		/// <value>
		/// The product identifier.
		/// </value>
		[Column("ProductID")]
		[Identity]
		[PrimaryKey]
		public int ProductId { get; set; }

		/// <summary>
		/// Gets or sets the name of the product.
		/// </summary>
		/// <value>
		/// The name of the product.
		/// </value>
		[Column]
		public string ProductName { get; set; }

		/// <summary>
		/// Gets or sets the category.
		/// </summary>
		/// <value>
		/// The category.
		/// </value>
		[Association(ThisKey = "CategoryId", OtherKey = "CategoryId")]
		public Category Category { get; set; }

		/// <summary>
		/// Gets or sets the category identifier.
		/// </summary>
		/// <value>
		/// The category identifier.
		/// </value>
		[Column("CategoryID")]
		public int CategoryId { get; set; }

		/// <summary>
		/// Gets or sets the supplier.
		/// </summary>
		/// <value>
		/// The supplier.
		/// </value>
		[Association(ThisKey = "SupplierId", OtherKey = "SupplierId", CanBeNull = true)]
		public Supplier Supplier { get; set; }

		/// <summary>
		/// Gets or sets the supplier identifier.
		/// </summary>
		/// <value>
		/// The supplier identifier.
		/// </value>
		[Column("SupplierID")]
		public int SupplierId { get; set; }

		/// <summary>
		/// Gets or sets the quantity per unit.
		/// </summary>
		/// <value>
		/// The quantity per unit.
		/// </value>
		[Column]
		public string QuantityPerUnit { get; set; }

		/// <summary>
		/// Gets or sets the unit price.
		/// </summary>
		/// <value>
		/// The unit price.
		/// </value>
		[Column]
		public decimal? UnitPrice { get; set; }

		/// <summary>
		/// Gets or sets the units in stock.
		/// </summary>
		/// <value>
		/// The units in stock.
		/// </value>
		[Column]
		public int? UnitsInStock { get; set; }

		/// <summary>
		/// Gets or sets the units on order.
		/// </summary>
		/// <value>
		/// The units on order.
		/// </value>
		[Column]
		public int? UnitsOnOrder { get; set; }

		/// <summary>
		/// Gets or sets the reorder level.
		/// </summary>
		/// <value>
		/// The reorder level.
		/// </value>
		[Column]
		public int? ReorderLevel { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Product"/> is discontinued.
		/// </summary>
		/// <value>
		///   <c>true</c> if discontinued; otherwise, <c>false</c>.
		/// </value>
		[Column]
		public bool Discontinued { get; set; }
	}
}
