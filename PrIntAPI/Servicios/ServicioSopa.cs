using PrIntAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Servicios
{
    class ServicioSopa
    {
        public DB lista;

        public ServicioSopa()
        {
            lista = DB.instance;
        }

        public int GetIndex(string nombre)
        {
            return lista.SopaLista.FindIndex((x => x.nombre == nombre));
        }

        public bool Verificar(Sopa c)
        {
            return lista.SopaLista.Exists((x => x.nombre == c.nombre));
        }

        public bool Crear(Sopa c)
        {
            bool existe = !Verificar(c);

            if (existe)
            {
                lista.SopaLista.Add(c);
            }

            return existe;
        }

        public List<Sopa> Leer()
        {
            return lista.SopaLista;
        }

        public bool Actualizar(string key, Sopa c)
        {
            int index = GetIndex(key);
            bool existe = true;
            if (!key.Equals(c.nombre))
            {
                if (GetIndex(c.nombre) != -1)
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
                    lista.SopaLista[index] = c;
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
                lista.SopaLista.RemoveAt(index);
            }
            else
            {
                eliminado = false;
            }

            return eliminado;
        }
    }
}
