using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConfigLib.Fluent.Infrastructure
{
    public class DbContextFactory: IDbContextFactory<FluentContext>
    {
        public FluentContext Create()
        {
            return new FluentContext("FluentApi");
        }
    }
}
