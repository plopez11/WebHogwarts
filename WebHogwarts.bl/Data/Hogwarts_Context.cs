using Microsoft.EntityFrameworkCore;
using WebHogwarts_bl.Models;
using WebHogwarts_bl.Data;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace WebHogwarts_bl.Data
{
    public class Hogwarts_Context : DbContext
    {
        public Hogwarts_Context(DbContextOptions<Hogwarts_Context> options)
            : base(options)
        {
                
        }
       public DbSet<Solicitud> Solicitud { get; set; }

        //public static Hogwarts_Context Create()
        //{
        //    return new Hogwarts_Context();
        //}

    }
}
