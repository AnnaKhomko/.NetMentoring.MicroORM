using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroORM.Model
{
	/// <summary>
	/// Shippers table model
	/// </summary>
	[Table("Shippers")]
	public class Shipper
	{
		/// <summary>
		/// Gets or sets the shipper identifier.
		/// </summary>
		/// <value>
		/// The shipper identifier.
		/// </value>
		[Column("ShipperID")]
		[Identity]
		[PrimaryKey]
		public int ShipperId { get; set; }

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
		/// Gets or sets the phone.
		/// </summary>
		/// <value>
		/// The phone.
		/// </value>
		[Column]
		public string Phone { get; set; }
	}
}
