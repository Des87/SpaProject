using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaProject.Repositories
{
    public class ReadTxtRepository : IReadTxtRepository
    {
        public async Task<string[]> Read()
        {
            string[] lines = File.ReadAllLines("furdoadat.txt", Encoding.UTF8);
            return await Task.FromResult(lines);
        }
    }
}
