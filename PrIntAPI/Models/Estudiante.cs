using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Models
{
    class Estudiante
    {
        public int codigo_est { get; set; }
        public string nombre { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string password { get; set; }
        public bool pensionado { get; set; }
        public string carrera { get; set; }
        public string ciudad_origen { get; set; }

        public Estudiante()
        {
            this.codigo_est = 0;
            this.nombre = "";
            this.ap_paterno = "";
            this.ap_materno = "";
            this.password = "";
            this.pensionado = false;
            this.carrera = "";
            this.ciudad_origen = "";
        }
    }
}
