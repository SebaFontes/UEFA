using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_UEFA.Interfaces
{
    public interface IArbitro
    {
        Int32 Tolerancia { get; }
        Int32 Motivacion { get; }
        Int32 ResistenciaFisica { get; }
        Int32 Inteligencia { get; }
    }
}
