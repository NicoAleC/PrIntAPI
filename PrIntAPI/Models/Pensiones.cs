using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Models
{
    class Pensiones
    {
        public int codigo_est { get; set; }
        public int cantidad { get; set; }

        public Pensiones()
        {
            this.codigo_est = 0;
            this.cantidad = 0;
        }
    }
}
