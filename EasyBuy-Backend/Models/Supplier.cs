using System.ComponentModel.DataAnnotations;

public class Supplier
{
    [Key]
    [Required]
    [Range(1, 99999999)]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Required]
    [StringLength(10)]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid phone number")]
    public string NumberPhone { get; set; }

    [Required]
    [StringLength(200)]
    public string Address { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(50)]
    public string Email { get; set; }

    [Required]
    public bool Status { get; set; }
}
