using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Dtos
{
    public class CreateProductDto
    {
        public string? Name { get; set; }

        public decimal Price {get; set; }
    }
}