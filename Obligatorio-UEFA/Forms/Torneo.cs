using Obligatorio_UEFA.Clases;
using Obligatorio_UEFA.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligatorio_UEFA
{
    public partial class Torneo : Form
    {
        private List<Equipo> equipos = new List<Equipo>();
        private String carpeta;

        private ManejadorDeArchivos manejador = new ManejadorDeArchivos();

        public Torneo()
        {
            InitializeComponent();
        }

        private void Torneo_Load(object sender, EventArgs e)
        {

        }

        public void GenerarEquipo()
        {
            //String nombreDirectorioActual;
            String nombreEquipo;
            Estadio estadio = null;
            List<Tecnico> tecnicos = new List<Tecnico>();
            List<Jugador> jugadoresCargados = new List<Jugador>();
            ArrayList listaJugadores;

            //Me fijo si existe el directorio
            if (System.IO.Directory.Exists(carpeta))
            {
                //Array con todos los archivos
                String[] archivos = System.IO.Directory.GetFiles(carpeta);
                foreach (String archivo in archivos)
                {
                    nombreEquipo = System.IO.Path.GetFileNameWithoutExtension(archivo);//Obtengo el nombre sin la extension
                    listaJugadores = manejador.Leer(nombreEquipo);
                    foreach (String jugadores in listaJugadores)
                    {
                        String[] datoJugador = jugadores.Split(',', '\n');
                        Int32 cantidadAtributos = datoJugador.Length;
                        switch (cantidadAtributos)
                        {
                            case 3:
                                estadio = new Estadio(datoJugador[0], Convert.ToInt32(datoJugador[1]), Convert.ToBoolean(datoJugador[2]));
                                break;
                            case 4:
                                Jugador jugador = new Jugador(datoJugador[0], datoJugador[1], Convert.ToInt32(datoJugador[2]), Convert.ToInt32(datoJugador[3]));
                                jugadoresCargados.Add(jugador);
                                break;
                            case 5:
                                Tecnico tecnico = new Tecnico(datoJugador[0], datoJugador[1], Convert.ToInt32(datoJugador[2]), Convert.ToInt32(datoJugador[3]), Convert.ToInt32(datoJugador[4]));
                                tecnicos.Add(tecnico);
                                break;
                        }
                    }
                    Equipo equipo = new Equipo(nombreEquipo,jugadoresCargados,tecnicos,estadio);
                    equipos.Add(equipo);
                }
            }
            
            
            

        }

        private void btnSeleccionCarpeta_Click(object sender, EventArgs e)
        {
            if (seleccionarCarpeta.ShowDialog() == DialogResult.OK)
            {
                carpeta = seleccionarCarpeta.SelectedPath;
            }
        }

        private void btnIniciarTorneo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
