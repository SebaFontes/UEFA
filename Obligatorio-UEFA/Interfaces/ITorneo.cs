using Obligatorio_UEFA.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_UEFA.Interfaces
{
    public interface ITorneo
    {
        List<Equipo> Equipos { get; set; }
        List<Estadio> Estadios { get; set; }
        List<IArbitro> Arbitros { get; set; }
    }
}
