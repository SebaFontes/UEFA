﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_UEFA.Interfaces
{
    public interface ICuartoArbitro: IArbitro
    {
        Boolean PosicionCuartoArbitro { get; }
    }
}
