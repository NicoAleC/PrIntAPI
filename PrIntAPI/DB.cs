using PrIntAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI
{
    class DB
    {
        private static DB _instance;

        private DB()
        {
            Initiate();
        }

        public void Initiate()
        {

        }

        public static DB instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DB();
                }
                return _instance;
            }
        }

        public List<Desayuno> DesayunoLista { get; private set; }
        public List<Especial> EspecialLista { get; private set; }
        public List<Estudiante> EstudianteLista { get; private set; }
        public List<Pensiones> PensionesLista { get; private set; }
        public List<Prestamos> PrestamosLista { get; private set; }
        public List<Reservas> ReservasLista { get; private set; }
        public List<Segundo> SegundoLista { get; private set; }
        public List<Sopa> SopaLista { get; private set; }

    }
}
