using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Services
{
    class ServicioDesayuno
    {
        public DB lista;

        public ServicioDesayuno()
        {
            lista = DB.instance;
        }


    }
}
