using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using System.Threading.Tasks;
using SpaProject.Factories;
using SpaProject.Models;

namespace Tests
{
    public class SaunaTest
    {
        [Fact]
        public void CreateObjectShouldWork()
        {
            //Arrenge
            var saunaFactory = new SaunaFactory();
            int customerNumber = 132;
            Guid guid = Guid.NewGuid();
            TimeSpan allTime = TimeSpan.MaxValue;
            Sauna sauna = new(guid, 123, TimeSpan.MaxValue);

            //Act
            Task<Sauna> s = saunaFactory.CreateObject(customerNumber,allTime);

            //Assert
            Assert.NotEqual(Task.FromResult(sauna), s);
        }
    }
}
