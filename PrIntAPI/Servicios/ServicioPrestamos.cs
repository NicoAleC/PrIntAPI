using PrIntAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Servicios
{
    class ServicioPrestamos
    {
        public DB lista;

        public ServicioPrestamos()
        {
            lista = DB.instance;
        }

        public int GetIndex(string codigo_est)
        {
            return lista.PrestamosLista.FindIndex((x => x.codigo_est == int.Parse(codigo_est)));
        }

        public bool Verificar(Prestamos c)
        {
            return lista.PrestamosLista.Exists((x => x.codigo_est == c.codigo_est));
        }

        public bool Crear(Prestamos c)
        {
            bool existe = !Verificar(c);

            if (existe)
            {
                lista.PrestamosLista.Add(c);
            }

            return existe;
        }

        public List<Prestamos> Leer()
        {
            return lista.PrestamosLista;
        }

        public bool Actualizar(string key, Prestamos c)
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
                    lista.PrestamosLista[index] = c;
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
                lista.PrestamosLista.RemoveAt(index);
            }
            else
            {
                eliminado = false;
            }

            return eliminado;
        }
    }
}
