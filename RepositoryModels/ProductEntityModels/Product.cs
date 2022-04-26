using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModels.ProductEntityModels
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? ProductName { get; set; }
    }
}
