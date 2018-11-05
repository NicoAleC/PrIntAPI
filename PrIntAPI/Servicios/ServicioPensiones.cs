using PrIntAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Servicios
{
    class ServicioPensiones
    {
        public DB lista;

        public ServicioPensiones()
        {
            lista = DB.instance;
        }

        public int GetIndex(string codigo_est)
        {
            return lista.PensionesLista.FindIndex((x => x.codigo_est == int.Parse(codigo_est)));
        }

        public bool Verificar(Pensiones c)
        {
            return lista.PensionesLista.Exists((x => x.codigo_est == c.codigo_est));
        }

        public bool Crear(Pensiones c)
        {
            bool existe = !Verificar(c);

            if (existe)
            {
                lista.PensionesLista.Add(c);
            }

            return existe;
        }

        public List<Pensiones> Leer()
        {
            return lista.PensionesLista;
        }

        public bool Actualizar(string key, Pensiones c)
        {
            int index = GetIndex(key);
            bool existe = true;
            if (!key.Equals(c.codigo_est))
            {
                if (GetIndex(c.codigo_est + "") != -1)
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
                    lista.PensionesLista[index] = c;
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
                lista.PensionesLista.RemoveAt(index);
            }
            else
            {
                eliminado = false;
            }

            return eliminado;
        }
    }
}
