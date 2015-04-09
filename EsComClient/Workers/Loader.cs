using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsComClient.Workers
{
    public class Loader<T> where T : ILoadable
    {
        public async Task<T> Load()
        {
            Task<T> t1 = Task.Run<T>(() => {
                return null;
            });

            await t1;
            return t1.Result;
        }
    }
}
