using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog
{
    internal class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NameProduct { get; set; } = null!;
        public string ProduceProduct { get; set; } = null!;

        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string? Image { get; set; }
    }
}
