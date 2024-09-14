using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EConnect.DAL.Models;

[PrimaryKey("PropertyId", "ContactId")]
[Table("Contact")]
[Index("PropertyId", "ContactId", Name = "IX_Contact", IsUnique = true)]
public partial class Contact
{
    [Key]
    public int ContactId { get; set; }

    [Key]
    public int PropertyId { get; set; }

    [StringLength(100)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    public string? LastName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? PropertyName { get; set; }

    [StringLength(200)]
    public string? Address1 { get; set; }

    [StringLength(255)]
    public string? Address2 { get; set; }

    [StringLength(60)]
    public string? City { get; set; }

    [StringLength(60)]
    public string? State { get; set; }

    [StringLength(30)]
    public string? Zip { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Country { get; set; }

    [StringLength(50)]
    public string? Phone1 { get; set; }

    [StringLength(50)]
    public string? Phone2 { get; set; }

    [StringLength(30)]
    public string? Fax { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    public byte? ContactPref { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? ReferSource { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReferSourceOthers { get; set; }

    [Column("ProductVersionID")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ProductVersionId { get; set; }

    [Column(TypeName = "text")]
    public string? Comments { get; set; }

    public bool? MailingList { get; set; }

    public bool? ContactType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SupportPlan { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SupportExpDt { get; set; }

    [Column("EWRExpDt")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EwrexpDt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ProductName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ProductDesc { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UnlockCode { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ReasonType { get; set; }

    [Unicode(false)]
    public string? ReasonDesc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CallBackDate { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? CallBackTime { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? WebSite { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PropertyType { get; set; }

    [Column(TypeName = "numeric(18, 0)")]
    public decimal? NoRooms { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PurchaseDt { get; set; }

    [Column(TypeName = "text")]
    public string? Testimonial { get; set; }

    public bool? DisplayTestimonial { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Objections { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Province { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Role1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Role2 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateRequested { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? Cellphone { get; set; }

    public byte? TypeofLead { get; set; }

    [Column(TypeName = "text")]
    public string? BudgetNotes { get; set; }

    [Column(TypeName = "text")]
    public string? EventNotes { get; set; }

    [Column(TypeName = "text")]
    public string? Customerneeds { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ContractDt { get; set; }

    [Column("POSId")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Posid { get; set; }

    public DateOnly? LeadConversionDate { get; set; }

    public int GuestId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ProductVersion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? MonthlyPrice { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? YearlyPrice { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Discount { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Tax { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? AdditionalPurchase { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SetupTotal { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? RecurringTotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BillingContacts { get; set; }

    [StringLength(100)]
    public string? Email2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SalesId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DemoDt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FreetrialDt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ValidationStatus { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ValidatedUser { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string CountryCode { get; set; } = null!;

    public int? DonationId { get; set; }

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

    [ForeignKey("PropertyId")]
    [InverseProperty("Contacts")]
    public virtual Property Property { get; set; } = null!;
}
