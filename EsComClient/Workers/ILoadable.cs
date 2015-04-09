using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsComClient.Workers
{
    public interface ILoadable
    {
        public object Load();
    }
}
