using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theshoeshop.userservice.domain.Entites;

namespace theshoeshop.userservice.dataaccess.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options): base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
