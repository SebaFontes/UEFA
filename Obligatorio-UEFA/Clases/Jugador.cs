using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_UEFA.Clases
{
    public class Jugador
    {
        #region Atributos
        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Int32 edad;
        public Int32 Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        private String posicion;
        public String Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        private Int32 patear;
        public Int32 Patear
        {
            get { return patear; }
            set { patear = value; }
        }

        private Int32 cabecear;
        public Int32 Cabecear
        {
            get { return cabecear; }
            set { cabecear = value; }
        }

        private Int32 atajar;
        public Int32 Atajar
        {
            get { return atajar; }
            set { atajar = value; }
        }

        private Int32 regatear;
        public Int32 Regatear
        {
            get { return regatear; }
            set { regatear = value; }
        }

        private Int32 goles;
        public Int32 Goles
        {
            get { return goles; }
            set { goles = value; }
        }

        private Int32 tarjetasAmarillas;
        public Int32 TarjetasAmarillas
        {
            get { return tarjetasAmarillas; }
            set { tarjetasAmarillas = value; }
        }

        private Int32 tarjetasRojas;
        public Int32 TarjetasRojas
        {
            get { return tarjetasRojas; }
            set { tarjetasRojas = value; }
        }
        #endregion

        //public Jugador(String unNombre, String unaPosicion, Int32 unaEdad, Int32 patea, Int32 cabecea, Int32 ataja, Int32 regatea)
        public Jugador(String unNombre, String unaPosicion, Int32 unaEdad, Int32 patea)
        {
            nombre = unNombre;
            posicion = unaPosicion;
            edad = unaEdad;
            patear = patea;
            /*cabecear = cabecea;
            atajar = ataja;
            regatear = regatea;*/
        }
    }
}
