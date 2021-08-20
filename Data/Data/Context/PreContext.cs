using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class PreContext : DbContext
    {
        public DbSet<Presentes> Presentes { get; set; }
        public PreContext() : base(@"Data Source=192.168.0.197;Initial Catalog=LojaDePresentes;Persist Security Info=True;User ID=duplona;Password=1@34")
        {

        }
    }
}
