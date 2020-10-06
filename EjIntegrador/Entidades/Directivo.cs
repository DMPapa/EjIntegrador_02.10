using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjIntegrador.Entidades
{
    class Directivo : Empleado
    {
        public Directivo(string nom, string ap, DateTime nac, DateTime ing, int leg) : base(nom, ap, nac, ing, leg)
        {

        }

        public override string GetNombreCompleto()
        {
            return "Sr. Director " + this._apellido;
        }
    }
}
