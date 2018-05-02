using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopOnline.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : AudiTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        [Required]
        public string CategoryName { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(250)]
        [Required]
        public string Alias { get; set; }

        public string Description { get; set; }
        public int ParentID { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}