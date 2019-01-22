using LinqToDB.Mapping;

namespace MicroORM.Model
{
	/// <summary>
	/// Employees table model
	/// </summary>
	[Table("Employees")]
	public class Employee
	{
		/// <summary>
		/// Gets or sets the employee identifier.
		/// </summary>
		/// <value>
		/// The employee identifier.
		/// </value>
		[Column("EmployeeID")]
		[PrimaryKey]
		[Identity]
		public int EmployeeId { get; set; }

		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>
		/// The last name.
		/// </value>
		[Column]
		public string LastName { get; set; }

		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>
		/// The first name.
		/// </value>
		[Column]
		public string FirstName { get; set; }
	}
}
