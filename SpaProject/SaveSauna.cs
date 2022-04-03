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
    public class SaveSauna : ISaveSauna
    {
        public async Task SaveItem()
        {
            var container = IocContainer.Configure();
            var scope = container.BeginLifetimeScope();
            var sf = scope.Resolve<ISaunaFactory>();
            var dbf = scope.Resolve<IDbFunc>();
            var slr = scope.Resolve<ISaunaListRepository>();

            var saunaData = await slr.GetVisitedTime();
            foreach (var item in saunaData)
            {
                Sauna s = await sf.CreateObject(item.CustomerNumber, item.AllTime);
                await dbf.AddItem(s);
            }
            await dbf.SaveToDatabase();
        }
    }
}
