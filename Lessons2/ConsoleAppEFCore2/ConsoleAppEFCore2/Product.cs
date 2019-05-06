using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppEFCore2
{
    class Product
    {
        public int ProductID { get; set; }
        
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }

        [Column("UnitPrice", TypeName ="money")]
        public decimal? Cost { get; set; }

        [Column("UnitsInStock")]
        public short? Stock { get; set; }

        public bool Discontinued { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
