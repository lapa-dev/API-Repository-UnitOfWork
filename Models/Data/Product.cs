using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Data
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
