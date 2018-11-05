using PrIntAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Services
{
    class ServicioEspecial
    {
        public DB lista;

        public ServicioEspecial()
        {
            lista = DB.instance;
        }

        public int GetIndex(string nombre)
        {
            return lista.EspecialLista.FindIndex((x => x.nombre == nombre));
        }

        public bool Verificar(Especial c)
        {
            return lista.EspecialLista.Exists((x => x.nombre == c.nombre));
        }

        public bool Crear(Especial c)
        {
            bool existe = !Verificar(c);

            if (existe)
            {
                lista.EspecialLista.Add(c);
            }

            return existe;
        }

        public List<Especial> Leer()
        {
            return lista.EspecialLista;
        }

        public bool Actualizar(string key, Especial c)
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
                    lista.EspecialLista[index] = c;
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
                lista.EspecialLista.RemoveAt(index);
            }
            else
            {
                eliminado = false;
            }

            return eliminado;
        }
    }
}
