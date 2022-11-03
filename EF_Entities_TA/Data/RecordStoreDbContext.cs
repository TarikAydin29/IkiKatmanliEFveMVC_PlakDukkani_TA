using EF_Entities_TA.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF_Entities_TA.Data
{
    public class RecordStoreDbContext : DbContext
    {
        public RecordStoreDbContext(DbContextOptions<RecordStoreDbContext> options) : base(options)
        {

        }



        public DbSet<User> Users { get; set; }

    }
}
