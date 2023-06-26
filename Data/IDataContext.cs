using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;

namespace ProductsApi.Data
{
    public interface IDataContext
    {
        DbSet<Product> Products {get;set;}
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}