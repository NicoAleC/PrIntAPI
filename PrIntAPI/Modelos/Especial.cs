using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Models
{
    class Especial
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Especial()
        {
            this.nombre = "";
            this.descripcion = "";
        }
    }
}
