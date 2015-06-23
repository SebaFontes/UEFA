using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_UEFA.Clases
{
    class ManejadorDeArchivos
    {
        public void Escribir(String nomArchivo, String texto)
        {
            StreamWriter writer = new StreamWriter(nomArchivo, true);
            writer.WriteLine(texto);
            writer.Close();
        }

        public ArrayList Leer(String nomArchivo)
        {
            StreamReader reader = new StreamReader(nomArchivo);
            ArrayList salida = new ArrayList();
            while (reader.Peek() > -1)
            {
                salida.Add(reader.ReadLine());
            }
            reader.Close();
            return salida;
        }
    }
}
