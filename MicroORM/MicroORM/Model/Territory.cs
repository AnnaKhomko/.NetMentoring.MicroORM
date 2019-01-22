using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroORM.Model
{
	/// <summary>
	/// Territories table model
	/// </summary>
	[Table("Territories")]
	public class Territory
	{
		/// <summary>
		/// Gets or sets the territory identifier.
		/// </summary>
		/// <value>
		/// The territory identifier.
		/// </value>
		[Column("TerritoryID")]
		[PrimaryKey]
		[Identity]
		public int TerritoryId { get; set; }

		/// <summary>
		/// Gets or sets the territory description.
		/// </summary>
		/// <value>
		/// The territory description.
		/// </value>
		[Column]
		[NotNull]
		public string TerritoryDescription { get; set; }

		/// <summary>
		/// Gets or sets the region identifier.
		/// </summary>
		/// <value>
		/// The region identifier.
		/// </value>
		[Column("RegionID")]
		[NotNull]
		public int RegionId { get; set; }

		/// <summary>
		/// Gets or sets the region.
		/// </summary>
		/// <value>
		/// The region.
		/// </value>
		[Association(ThisKey = "RegionId", OtherKey = "RegionId")]
		public Region Region { get; set; }
	}
}
