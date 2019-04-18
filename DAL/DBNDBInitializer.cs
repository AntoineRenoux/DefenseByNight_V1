using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBNDBInitializer : DropCreateDatabaseIfModelChanges<DBNContext>
    {
        protected override void Seed(DBNContext context)
        {
            base.Seed(context);
        }
    }
}
