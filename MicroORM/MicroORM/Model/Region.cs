using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroORM.Model
{
	/// <summary>
	/// Region table model
	/// </summary>
	[Table("Region")]
	public class Region
	{
		/// <summary>
		/// Gets or sets the region identifier.
		/// </summary>
		/// <value>
		/// The region identifier.
		/// </value>
		[Column("RegionID")]
		[Identity]
		[PrimaryKey]
		public int RegionId { get; set; }

		/// <summary>
		/// Gets or sets the region description.
		/// </summary>
		/// <value>
		/// The region description.
		/// </value>
		[Column]
		[NotNull]
		public string RegionDescription { get; set; }
	}
}
