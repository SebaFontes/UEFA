using Obligatorio_UEFA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_UEFA.Clases
{
    public class Arbitro: IArbitro, ICentral, ICuartoArbitro, ILinea
    {
        #region Atributos
        private Int32 tolerancia;
        Int32 IArbitro.Tolerancia
        {
            get { return tolerancia; }
        }

        private Int32 motivacion;
        Int32 IArbitro.Motivacion
        {
            get { return motivacion; }
        }

        private Int32 resistenciaFisica;
        Int32 IArbitro.ResistenciaFisica
        {
            get { return resistenciaFisica; }
        }

        private Int32 inteligencia;
        Int32 IArbitro.Inteligencia
        {
            get { return inteligencia; }
        }

        private Boolean posicionCentral;
        Boolean ICentral.PosicionCentral
        {
            get { return posicionCentral; }
        }

        private Boolean posicionCuartoArbitro;
        Boolean ICuartoArbitro.PosicionCuartoArbitro
        {
            get { return posicionCuartoArbitro; }
        }

        private Boolean posicionLinea;
        Boolean ILinea.PosicionLinea
        {
            get { return posicionLinea; }
        }
        #endregion

        #region Constructores
        public Arbitro(Int32 unaTolerancia,Int32 unaMotivacion,Int32 unaResistencia,Int32 unaInteligencia,Boolean posicionCentral)
        {
            tolerancia = unaTolerancia;
            motivacion = unaMotivacion;
            resistenciaFisica = unaResistencia;
            inteligencia = unaInteligencia;
            this.posicionCentral = posicionCentral;
        }

       /*
        public Arbitro(Int32 unaTolerancia, Int32 unaMotivacion, Int32 unaResistencia, Int32 unaInteligencia, Boolean posicionCuartoArbitro)
        {
            tolerancia = unaTolerancia;
            motivacion = unaMotivacion;
            resistenciaFisica = unaResistencia;
            inteligencia = unaInteligencia;
            this.posicionCuartoArbitro = posicionCuartoArbitro;
        }

        public Arbitro(Int32 unaTolerancia, Int32 unaMotivacion, Int32 unaResistencia, Int32 unaInteligencia, Boolean posicionLinea)
        {
            tolerancia = unaTolerancia;
            motivacion = unaMotivacion;
            resistenciaFisica = unaResistencia;
            inteligencia = unaInteligencia;
            this.posicionLinea = posicionLinea;
        }*/
        #endregion
    }
}
