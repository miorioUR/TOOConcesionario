using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public class TablaClientes : KeyedCollection<string, ClienteDato>
    {
        protected override string GetKeyForItem(ClienteDato item)
        {
            return item.Dni;
        }
    }
}
