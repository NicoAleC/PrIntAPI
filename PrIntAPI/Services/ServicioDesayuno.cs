using PrIntAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Services
{
    class ServicioDesayuno
    {
        public DB lista;

        public ServicioDesayuno()
        {
            lista = DB.instance;
        }

        public int GetIndex(string nombre)
        {
            return lista.DesayunoLista.FindIndex((x => x.nombre == nombre));
        }

        public bool Verificar(Desayuno desayuno)
        {
            return lista.DesayunoLista.Exists((x => x.nombre == desayuno.nombre));
        }

        public bool Crear(Desayuno desayuno)
        {
            bool existe = !Verificar(desayuno);

            if (existe)
            {
                lista.DesayunoLista.Add(desayuno);
            }

            return existe;
        }

        public List<Desayuno> Leer()
        {
            return lista.DesayunoLista;
        }

        public bool Actualizar(string key, Desayuno desayuno)
        {
            int index = GetIndex(key);
            bool existe = true;
            if (!key.Equals(desayuno.nombre))
            {
                if (GetIndex(desayuno.nombre) != -1)
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
                    lista.DesayunoLista[index] = desayuno;
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
            if(index != -1)
            {
                lista.DesayunoLista.RemoveAt(index);
            }
            else
            {
                eliminado = false;
            }

            return eliminado;
        }
    }
}
