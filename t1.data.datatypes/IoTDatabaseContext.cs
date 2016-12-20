using System.Data.Entity;

namespace t1.data.datatypes
{
    public class IoTDatabaseContext: DbContext
    {

        public IoTDatabaseContext() : base("name=IoTDatabaseContext")
        {
        }

        public virtual DbSet ErrorAndWarningsEntries { get; set; }
    }
}
