using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.Entities.Concrete.EntityFramework
{
    public class NorhtwindContext : DbContext 
    {

        public DbSet<Product> Products { get; set; }

        public NorhtwindContext()
        {
            Database.SetInitializer<NorhtwindContext>(null);
        }
    }
}
