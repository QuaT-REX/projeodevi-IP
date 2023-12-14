using Microsoft.EntityFrameworkCore;
using SoruCevapPortalı_Model.Models;

namespace SoruCevapPortalı_DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {


        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        public DbSet<Kategori> Kategoriler { get; set; }

    }
}
