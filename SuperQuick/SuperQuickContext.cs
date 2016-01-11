using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;

namespace SuperQuick
{
    public class SuperQuickContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public SuperQuickContext(): this(new SqlConnection(ConfigurationManager.ConnectionStrings["SuperQuickDbConnection"].ToString()), true) { }

        private SuperQuickContext(DbConnection dbConnection, bool contextOwnsConnection)
            : base(dbConnection, contextOwnsConnection)
        {
        }

    }
}
