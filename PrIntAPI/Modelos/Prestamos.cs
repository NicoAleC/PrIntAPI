using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Models
{
    class Prestamos
    {
        public int codigo_est { get; set; }
        public float deuda { get; set; }

        public Prestamos()
        {
            this.codigo_est = 0;
            this.deuda = 0;
        }
    }
}
