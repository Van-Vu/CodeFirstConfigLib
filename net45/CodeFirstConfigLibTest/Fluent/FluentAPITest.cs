using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using CodeFirstConfigLib.Fluent.Infrastructure;
using CodeFirstConfigLib.Migrations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeFirstConfigLibTest.Fluent
{
    [TestClass]
    public class FluentAPITest
    {
        [TestMethod]
        public void TestFluentApiConfiguration()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<FluentContext,Configuration>());

            using (var context = new FluentContext("FluentApi"))
            {
                context.Database.Initialize(true);
                var list = context.Users.ToList();
            }
        }

        [TestMethod]
        public void PowerShellCommand()
        {
            var powerShell = PowerShell.Create();
            var nugetLocation =
                @"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\Extensions\wxjplotj.duv\Modules\NuGet\NuGet.psm1";
            powerShell.AddCommand("Import-Module");
            //powerShell.AddParameter("Name");
            powerShell.AddArgument(nugetLocation);

            var efModuleLocation =
                @"D:\Self-Study\Tech\Github\CodeFirstConfigLib\net45\packages\EntityFramework.5.0.0\tools\EntityFramework.PS3.psm1";
            powerShell.AddCommand("Import-Module");
            //powerShell.AddParameter("Name");
            powerShell.AddArgument(efModuleLocation);


            //powerShell.Invoke();
            //powerShell.AddCommand("Update-Database");
            //powerShell.AddParameter("script");
            powerShell.AddCommand("Get-Process");

           try
           {
               var runspace = RunspaceFactory.CreateRunspace();
               runspace.Open();
               powerShell.Runspace = runspace;
               Collection<PSObject> results = powerShell.Invoke();

               var builder = new StringBuilder();
               foreach (var psObject in results)
               {
                   builder.AppendLine(psObject.ToString() + "\r\n");
               }
               //ResultBox.Text = Server.HtmlEncode(builder.ToString());
           }
           catch (Exception)
           {
               
           }
        }
    }
}
