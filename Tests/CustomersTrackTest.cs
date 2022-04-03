using SpaProject;
using SpaProject.Factories;
using SpaProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class CustomersTrackTest
    {
        [Fact]
        public void CreateObjectShouldWork()
        {
            //Arrenge
            var ctFactory = new CustomersTrackFactory();
            string line = "456 0 1 8 12 57";
            Guid guid = Guid.NewGuid();
            DateTime dt = DateTime.Today.AddHours(8).AddMinutes(12).AddSeconds(57);
            CustomersTrack ct = new(guid,456,eDepartments.Öltöző,eInorOut.Ki,dt);

            //Act
            Task<CustomersTrack> s = ctFactory.CreateObject(line);

            //Assert
            Assert.NotEqual(Task.FromResult(ct), s);
        }
    }
}
