using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Gz.Db;

namespace Gz.Db
{
    public class GzContext : DbContext
    {
        public GzContext() : base("name=gzConn")
        {
            //是否启用延迟加载 Lazy Loading
            this.Configuration.LazyLoadingEnabled = true;
        }

        public GzContext(string name) : base(name)
        {
            //是否启用延迟加载 Lazy Loading
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<TUser> TUsers { get; set; }

        public DbSet<TRole> TRoles { get; set; }
    }
}
