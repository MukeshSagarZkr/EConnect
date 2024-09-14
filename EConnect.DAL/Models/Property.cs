using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EConnect.DAL.Models;

[Table("Property")]
public partial class Property
{
	[Key]
	public int PropertyId { get; set; }

	[StringLength(30)]
	[Unicode(false)]
	public string? PropertyShortName { get; set; }

	[StringLength(100)]
	[Unicode(false)]
	public string? PropertyFullName { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public int? CreatedBy { get; set; }

	[Column(TypeName = "datetime")]
	public DateTime? CreatedOn { get; set; }

	public int? ModifiedBy { get; set; }

	[Column(TypeName = "datetime")]
	public DateTime? ModifiedOn { get; set; }

	[StringLength(4)]
	[Unicode(false)]
	public string? IsProcessed { get; set; }

	[InverseProperty("Property")]
	public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

	[InverseProperty("Property")]
	public virtual ICollection<Login> Logins { get; set; } = new List<Login>();
}
