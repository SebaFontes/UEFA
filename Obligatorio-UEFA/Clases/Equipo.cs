using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_UEFA.Clases
{
    public class Equipo
    {
        #region Atributos
        private String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private List<Jugador> jugadores;
        public List<Jugador> Jugadores
        {
            get { return jugadores; }
            set { jugadores = value; }
        }

        private List<Tecnico> tecnicos;
        public List<Tecnico> Tecnicos
        {
            get { return tecnicos; }
            set { tecnicos = value; }
        }

        private Estadio estadio;
        public Estadio Estadio
        {
            get { return estadio; }
            set { estadio = value; }
        }
        #endregion

        public Equipo (String unNombre,List<Jugador> listaJugadores,List<Tecnico> listaTecnicos,Estadio unEstadio)
        {
            nombre = unNombre;
            jugadores = listaJugadores;
            tecnicos = listaTecnicos;
            estadio = unEstadio;
        }
    }
}
