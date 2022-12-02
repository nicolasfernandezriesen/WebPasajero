using WebPasajero.Models;
using Microsoft.EntityFrameworkCore;

namespace WebPasajero.Data
{
    public class WebPasajeroContext : DbContext
    {
        public WebPasajeroContext(DbContextOptions<WebPasajeroContext> options) : base (options){ }

        public DbSet<Pasajero> Pasajeros { get; set;}
    }
}
