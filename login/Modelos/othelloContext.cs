using Microsoft.EntityFrameworkCore;


namespace login.Modelos
{
    public class othelloContext : DbContext{
        public othelloContext (DbContextOptions <othelloContext> options) : base(options){}
        public DbSet <User> Users {get; set;}
        
    }
}