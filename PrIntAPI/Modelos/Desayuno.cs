using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Models
{
    class Desayuno
    {
        public string nombre { get; set; }
        public string bebida_caliente { get; set; }
        public string jugo { get; set; }
        public string plato { get; set; }

        public Desayuno()
        {
            this.nombre = "";
            this.bebida_caliente = "";
            this.jugo = "";
            this.plato = "";
        }
    }
}
