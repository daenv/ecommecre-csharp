using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce_CSharp.Data;

public class Category
{
    [Key] public int Id { get; set; }

    [Required]
    [DisplayName(displayName: "Category Name")]
    public string Name { get; set; }

    [Required]
    [DisplayName(displayName: "Category Description")]
    public string Description { get; set; }
}