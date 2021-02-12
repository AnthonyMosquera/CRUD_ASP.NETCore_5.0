using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ASP.NETCore_5._0_CodeFirst.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "Description")]
        [Required]
        public string Description { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        [Display(Name = "Price")]
        public Decimal Price { get; set; }
        [Column(TypeName = "date")]
        [Display(Name = "CreationDate")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }
        public Product()
        {

        }
    }
}
