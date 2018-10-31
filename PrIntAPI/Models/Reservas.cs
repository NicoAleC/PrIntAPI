using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Models
{
    class Reservas
    {
        public int numero_reserva { get; set; }
        public string desayuno { get; set; }
        public bool jugo { get; set; }
        public string sopa { get; set; }
        public string segundo { get; set; }
        public int codigo_est { get; set; }
        public DateTime fecha { get; set; }
        public string especial { get; set; }

        public Reservas()
        {
            this.numero_reserva = 0;
            this.desayuno = "";
            this.jugo = false;
            this.sopa = "";
            this.segundo = "";
            this.codigo_est = 0;
            this.fecha = new DateTime(/*año*/0000, /*mes*/0, /*día*/0, /*hora*/0, /*minuto*/0, /*segundo*/0);
            this.especial = "";
        }
    }
}
