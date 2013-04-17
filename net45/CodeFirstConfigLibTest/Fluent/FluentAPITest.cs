using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using CodeFirstConfigLib.Fluent.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeFirstConfigLibTest.Fluent
{
    [TestClass]
    public class FluentAPITest
    {
        [TestMethod]
        public void TestFluentApiConfiguration()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<FluentContext>());

            using (var context = new FluentContext("FluentApi"))
            {
                context.Database.Initialize(true);
                var list = context.Users.ToList();
            }
        }
    }
}
