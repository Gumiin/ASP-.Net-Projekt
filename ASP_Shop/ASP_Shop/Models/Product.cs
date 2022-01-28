using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ASP_Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int ProducentID { get; set; }
        [ForeignKey("ProducentID")]
        [ValidateNever]
        public Producent Producent { get; set; }

        public string  Description { get; set; }
        [Required]
        public string ProductCode { get; set; }
        
        [Required]
        [Range(1,10000)]
        public double Price { get; set; }

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

    }
}
