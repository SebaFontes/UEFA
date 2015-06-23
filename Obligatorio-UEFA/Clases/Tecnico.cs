using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_UEFA.Clases
{
    public class Tecnico: Jugador
    {
        private Int32 dirigir;
        public Int32 Dirigir
        {
            get { return dirigir; }
            set { dirigir = value; }
        }

        //public Tecnico (String unNombre,Int32 unaEdad,String unaPosicion,Int32 patea,Int32 cabecea,Int32 ataja,Int32 regatea,Int32 dirige)
            //:base(unNombre,unaEdad,unaPosicion,patea,cabecea,ataja,regatea)
        public Tecnico(String unNombre, String unaPosicion, Int32 unaEdad, Int32 patea, Int32 dirige)
            : base(unNombre, unaPosicion, unaEdad, patea)
        {
            dirigir = dirige;
        }
    }
}
