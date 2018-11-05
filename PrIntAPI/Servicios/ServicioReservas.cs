using PrIntAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Servicios
{
    class ServicioReservas
    {
        public DB lista;

        public ServicioReservas()
        {
            lista = DB.instance;
        }

        public int GetIndex(string numero_reserva)
        {
            return lista.ReservasLista.FindIndex((x => x.numero_reserva == int.Parse(numero_reserva)));
        }

        public bool Verificar(Reservas c)
        {
            return lista.ReservasLista.Exists((x => x.numero_reserva == c.numero_reserva));
        }

        public bool Crear(Reservas c)
        {
            bool existe = !Verificar(c);

            if (existe)
            {
                lista.ReservasLista.Add(c);
            }

            return existe;
        }

        public List<Reservas> Leer()
        {
            return lista.ReservasLista;
        }

        public bool Actualizar(string key, Reservas c)
        {
            int index = GetIndex(key);
            bool existe = true;
            if (!key.Equals(c.codigo_est))
            {
                if (GetIndex(c.numero_reserva + "") != -1)
                {
                    existe = true;
                }
                else
                {
                    existe = true;
                }
            }
            if (existe)
            {
                if (index != -1)
                {
                    lista.ReservasLista[index] = c;
                }
                else
                {
                    existe = false;
                }
            }
            return existe;
        }

        public bool Eliminar(string key)
        {
            bool eliminado = true;
            int index = GetIndex(key);
            if (index != -1)
            {
                lista.ReservasLista.RemoveAt(index);
            }
            else
            {
                eliminado = false;
            }

            return eliminado;
        }
    }
}
