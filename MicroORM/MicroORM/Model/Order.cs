using LinqToDB.Mapping;
using System;

namespace MicroORM.Model
{
	/// <summary>
	/// Order table model
	/// </summary>
	[Table("Orders")]
	public class Order
	{
		/// <summary>
		/// Gets or sets the order identifier.
		/// </summary>
		/// <value>
		/// The order identifier.
		/// </value>
		[Column("OrderID")]
		[Identity]
		[PrimaryKey]
		public int OrderId { get; set; }

		/// <summary>
		/// Gets or sets the shipper identifier.
		/// </summary>
		/// <value>
		/// The shipper identifier.
		/// </value>
		[Column("ShipVia")]
		public int? ShipperId { get; set; }

		/// <summary>
		/// Gets or sets the shipped date.
		/// </summary>
		/// <value>
		/// The shipped date.
		/// </value>
		[Column]
		public DateTime? ShippedDate { get; set; }

		/// <summary>
		/// Gets or sets the employee identifier.
		/// </summary>
		/// <value>
		/// The employee identifier.
		/// </value>
		[Column("EmployeeID")]
		public int? EmployeeId { get; set; }

		/// <summary>
		/// Gets or sets the employee.
		/// </summary>
		/// <value>
		/// The employee.
		/// </value>
		[Association(ThisKey = "EmployeeId", OtherKey = "EmployeeId", CanBeNull = true)]
		public Employee Employee { get; set; }

		/// <summary>
		/// Gets or sets the shipper.
		/// </summary>
		/// <value>
		/// The shipper.
		/// </value>
		[Association(ThisKey = "ShipperId", OtherKey = "ShipperId", CanBeNull = true)]
		public Shipper Shipper { get; set; }

	}
}
