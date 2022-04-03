using SpaProject.Data;
using SpaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class NullCheckDatabaseTest
    {
        [Fact]
        public void CreateObjectShouldWork()
        {
            //Arrenge
            ContextDb db = new();
            bool istrue = !db.CustomersTrack.Any();
            var ctFactory = new NullCheckDatabase(db);
    
            //Act
            Task<bool> s = ctFactory.CheckIfEmpty();

            //Assert
            Assert.NotEqual(Task.FromResult(istrue), s);
        }
    }
}
