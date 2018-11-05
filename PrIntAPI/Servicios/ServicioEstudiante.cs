using PrIntAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrIntAPI.Servicios
{
    class ServicioEstudiante
    {
        public DB lista;

        public ServicioEstudiante()
        {
            lista = DB.instance;
        }

        public int GetIndex(string codigo_est)
        {
            return lista.EstudianteLista.FindIndex((x => x.codigo_est == int.Parse(codigo_est)));
        }

        public bool Verificar(Estudiante c)
        {
            return lista.EstudianteLista.Exists((x => x.codigo_est == c.codigo_est));
        }

        public bool Crear(Estudiante c)
        {
            bool existe = !Verificar(c);

            if (existe)
            {
                lista.EstudianteLista.Add(c);
            }

            return existe;
        }

        public List<Estudiante> Leer()
        {
            return lista.EstudianteLista;
        }

        public bool Actualizar(string key, Estudiante c)
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
                    lista.EstudianteLista[index] = c;
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
                lista.EstudianteLista.RemoveAt(index);
            }
            else
            {
                eliminado = false;
            }

            return eliminado;
        }
    }
}
