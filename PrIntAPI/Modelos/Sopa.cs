using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Models
{
    class Sopa
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Sopa()
        {
            this.nombre = "";
            this.descripcion = "";
        }
    }
}
