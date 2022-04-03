using Autofac;
using SpaProject.Data;
using SpaProject.Factories;
using SpaProject.Models;
using SpaProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject
{
    public class ReadFromFile : IRead
    {
        public async Task<string> ReadAndSave()
        {
            var container = IocContainer.Configure();
            var scope = container.BeginLifetimeScope();
            var ctf = scope.Resolve<ICustomersTrackFactory>();
            var dbf = scope.Resolve<IDbFunc>();
            var rtr = scope.Resolve<IReadTxtRepository>();

            var lines = await rtr.Read();
            foreach (var item in lines)
            {
                CustomersTrack ct = await ctf.CreateObject(item);
                await dbf.AddItem(ct);
            }
            await dbf.SaveToDatabase();
            return "Txt beolvasva és mentve az adatbázisba!";
        }
    }
    public class ReadNoAgain : IRead
    {
        public Task<string> ReadAndSave()
        {
            return Task.FromResult("A txt adatai már az adatbázisban vannak, a feladatok pontossága érdekében NEM menti bele újra!");
        }
    }
}
