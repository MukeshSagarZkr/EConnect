using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EConnect.DAL.Models;

[PrimaryKey("LoginId", "PropertyId")]
[Table("Login")]
public partial class Login
{
	[Key]
	public int LoginId { get; set; }

	[Key]
	public int PropertyId { get; set; }

	[Column("Login")]
	[StringLength(255)]
	public string? Login1 { get; set; }

	[StringLength(50)]
	public string? Password { get; set; }

	[StringLength(50)]
	public string? LoginType { get; set; }

	[StringLength(100)]
	public string? EmailAddress { get; set; }

	[StringLength(100)]
	[Unicode(false)]
	public string? Company { get; set; }

	[StringLength(50)]
	[Unicode(false)]
	public string? ShortName { get; set; }

	[Column(TypeName = "smalldatetime")]
	public DateTime? ExpiryDate { get; set; }

	public bool? Demo { get; set; }

	[StringLength(500)]
	public string? NewProcess { get; set; }

	public int? CreatedBy { get; set; }

	[Column(TypeName = "datetime")]
	public DateTime? CreatedOn { get; set; }

	public int? UpdatedBy { get; set; }

	[Column(TypeName = "datetime")]
	public DateTime? UpdatedOn { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	[StringLength(4)]
	[Unicode(false)]
	public string? IsProcessed { get; set; }

	[ForeignKey("PropertyId")]
	[InverseProperty("Logins")]
	public virtual Property Property { get; set; } = null!;
}
