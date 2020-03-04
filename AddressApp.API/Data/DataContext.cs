using AddressApp.API.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Address> Addresses { get; set; }
    }
}