using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroORM.Model
{
	/// <summary>
	/// Suppliers table model
	/// </summary>
	[Table("Suppliers")]
	public class Supplier
	{
		/// <summary>
		/// Gets or sets the supplier identifier.
		/// </summary>
		/// <value>
		/// The supplier identifier.
		/// </value>
		[Column("SupplierID")]
		[PrimaryKey]
		[Identity]
		public int SupplierId { get; set; }

		/// <summary>
		/// Gets or sets the name of the company.
		/// </summary>
		/// <value>
		/// The name of the company.
		/// </value>
		[Column]
		[NotNull]
		public string CompanyName { get; set; }

		/// <summary>
		/// Gets or sets the name of the contact.
		/// </summary>
		/// <value>
		/// The name of the contact.
		/// </value>
		[Column]
		public string ContactName { get; set; }

		/// <summary>
		/// Gets or sets the products.
		/// </summary>
		/// <value>
		/// The products.
		/// </value>
		[Association(ThisKey = "SupplierId", OtherKey = "SupplierId", CanBeNull = true)]
		public IEnumerable<Product> Products { get; set; }
	}
}
