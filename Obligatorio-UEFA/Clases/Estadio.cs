using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_UEFA.Clases
{
    public class Estadio
    {
        #region Atributos
        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Int32 capacidad;
        public Int32 Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        private Boolean techado;
        public Boolean Techado
        {
            get { return techado; }
            set { techado = value; }
        }
        #endregion

        public Estadio (String unNombre,Int32 unaCapacidad,Boolean esTechado)
        {
            nombre = unNombre;
            capacidad = unaCapacidad;
            techado = esTechado;
        }
    }
}
