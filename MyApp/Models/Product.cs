using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Models
{
    public class Product
    {
        internal object id ;

        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public required string ProductName { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
        [Precision(18, 2)] // Use for EF Core 5.0+
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be non-negative.")]
        public int Quantity { get; set; }

        public required string Tags { get; set; } // Tags are comma-separated

        public required string Categories { get; set; }
    }
}
