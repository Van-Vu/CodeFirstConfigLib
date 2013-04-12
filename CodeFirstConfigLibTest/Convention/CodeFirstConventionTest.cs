using System.Data.Entity;
using System.Linq;
using CodeFirstConfigLib.Convention.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeFirstConfigLibTest.Convention
{
    [TestClass]
    public class CodeFirstConventionTest
    {
        [TestMethod]
        public void CreateDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ConventionContext>());
            using (var context = new ConventionContext("Convention"))
            {
                var val = context.Users.ToList();
            }
        }
    }
}
