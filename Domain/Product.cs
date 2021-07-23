using Common.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
