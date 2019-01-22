using LinqToDB.Mapping;

namespace MicroORM.Model
{
	/// <summary>
	/// EmployeeTerritories table model
	/// </summary>
	[Table("EmployeeTerritories")]
	public class EmployeeTerritory
	{
		/// <summary>
		/// Gets or sets the employee identifier.
		/// </summary>
		/// <value>
		/// The employee identifier.
		/// </value>
		[Column("EmployeeID")]
		[NotNull]
		public int EmployeeId { get; set; }

		/// <summary>
		/// Gets or sets the territory identifier.
		/// </summary>
		/// <value>
		/// The territory identifier.
		/// </value>
		[Column("TerritoryID")]
		[NotNull]
		public int TerritoryId { get; set; }

		/// <summary>
		/// Gets or sets the employee.
		/// </summary>
		/// <value>
		/// The employee.
		/// </value>
		[Association(ThisKey = "EmployeeId", OtherKey = "EmployeeId")]
		public Employee Employee { get; set; }

		/// <summary>
		/// Gets or sets the territory.
		/// </summary>
		/// <value>
		/// The territory.
		/// </value>
		[Association(ThisKey = "TerritoryId", OtherKey = "TerritoryId")]
		public Territory Territory { get; set; }
	}
}
