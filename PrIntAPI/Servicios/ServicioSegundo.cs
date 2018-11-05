using PrIntAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Servicios
{
    class ServicioSegundo
    {
        public DB lista;

        public ServicioSegundo()
        {
            lista = DB.instance;
        }

        public int GetIndex(string nombre)
        {
            return lista.SegundoLista.FindIndex((x => x.nombre == nombre));
        }

        public bool Verificar(Segundo c)
        {
            return lista.SegundoLista.Exists((x => x.nombre == c.nombre));
        }

        public bool Crear(Segundo c)
        {
            bool existe = !Verificar(c);

            if (existe)
            {
                lista.SegundoLista.Add(c);
            }

            return existe;
        }

        public List<Segundo> Leer()
        {
            return lista.SegundoLista;
        }

        public bool Actualizar(string key, Segundo c)
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
                    lista.SegundoLista[index] = c;
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
                lista.SegundoLista.RemoveAt(index);
            }
            else
            {
                eliminado = false;
            }

            return eliminado;
        }
    }
}
