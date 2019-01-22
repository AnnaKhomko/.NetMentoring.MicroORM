using LinqToDB;
using LinqToDB.Data;

namespace MicroORM.Model
{
	/// <summary>
	/// Northwind data base description
	/// </summary>
	/// <seealso cref="LinqToDB.Data.DataConnection" />
	public class Northwind : DataConnection
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Northwind"/> class.
		/// </summary>
		public Northwind() : base("Northwind") { }

		/// <summary>
		/// Gets the categories.
		/// </summary>
		/// <value>
		/// The categories.
		/// </value>
		public ITable<Category> Categories { get { return GetTable<Category>(); } }

		/// <summary>
		/// Gets the products.
		/// </summary>
		/// <value>
		/// The products.
		/// </value>
		public ITable<Product> Products { get { return GetTable<Product>(); } }

		/// <summary>
		/// Gets the suppliers.
		/// </summary>
		/// <value>
		/// The suppliers.
		/// </value>
		public ITable<Supplier> Suppliers { get { return GetTable<Supplier>(); } }

		/// <summary>
		/// Gets the orders.
		/// </summary>
		/// <value>
		/// The orders.
		/// </value>
		public ITable<Order> Orders { get { return GetTable<Order>(); } }

		/// <summary>
		/// Gets the order details.
		/// </summary>
		/// <value>
		/// The order details.
		/// </value>
		public ITable<OrderDetail> OrderDetails { get { return GetTable<OrderDetail>(); } }

		/// <summary>
		/// Gets the regions.
		/// </summary>
		/// <value>
		/// The regions.
		/// </value>
		public ITable<Region> Regions { get { return GetTable<Region>(); } }

		/// <summary>
		/// Gets the territories.
		/// </summary>
		/// <value>
		/// The territories.
		/// </value>
		public ITable<Territory> Territories { get { return GetTable<Territory>(); } }

		/// <summary>
		/// Gets the employee territories.
		/// </summary>
		/// <value>
		/// The employee territories.
		/// </value>
		public ITable<EmployeeTerritory> EmployeeTerritories { get { return GetTable<EmployeeTerritory>(); } }

		/// <summary>
		/// Gets the employees.
		/// </summary>
		/// <value>
		/// The employees.
		/// </value>
		public ITable<Employee> Employees { get { return GetTable<Employee>(); } }

		/// <summary>
		/// Gets the shippers.
		/// </summary>
		/// <value>
		/// The shippers.
		/// </value>
		public ITable<Shipper> Shippers { get { return GetTable<Shipper>(); } }

	}
}
