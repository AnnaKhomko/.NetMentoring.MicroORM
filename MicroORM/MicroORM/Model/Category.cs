using LinqToDB.Mapping;
using System.Collections.Generic;

namespace MicroORM.Model
{
	/// <summary>
	/// Categories table model
	/// </summary>
	[Table("Categories")]
	public class Category
	{
		/// <summary>
		/// Gets or sets the category identifier.
		/// </summary>
		/// <value>
		/// The category identifier.
		/// </value>
		[PrimaryKey]
		[Identity]
		[Column("CategoryID")]
		public int CategoryId { get; set; }

		/// <summary>
		/// Gets or sets the name of the category.
		/// </summary>
		/// <value>
		/// The name of the category.
		/// </value>
		[Column]
		public string CategoryName { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>
		/// The description.
		/// </value>
		[Column]
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the picture.
		/// </summary>
		/// <value>
		/// The picture.
		/// </value>
		[Column]
		public byte[] Picture { get; set; }

		/// <summary>
		/// Gets or sets the products.
		/// </summary>
		/// <value>
		/// The products.
		/// </value>
		[Association(ThisKey = "CategoryId", OtherKey = "CategoryId", CanBeNull = true)]
		public IEnumerable<Product> Products { get; set; }
	}
}
