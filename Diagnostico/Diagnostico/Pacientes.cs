using System;
using System.Collections.Generic;
using System.Text;

namespace Diagnostico
{
   public class Pacientes
    {
        public  string nombre { get; set; }
        public List<string> diagnosticos { get; set; } = new List<string>();

        public Pacientes (string nombre, string diagnostico)
        {

            this.nombre = nombre;      
            this.diagnosticos.Add(diagnostico);

        }

    }
}
