using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjIntegrador.Entidades
{
    class Docente : Empleado
    {
        public Docente (string nom, string ap, DateTime nac, DateTime ing, int leg) : base (nom, ap, nac, ing, leg)
        {

        }

        public new string GetNombreCompleto()
        {
            return "Docente " + this._nombre;
        }
    }
}
