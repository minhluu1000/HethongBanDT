

using Microsoft.EntityFrameworkCore;

namespace HethongBanDT.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }



    }
}
