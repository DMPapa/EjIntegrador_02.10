using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjIntegrador.Entidades
{
    class Alumno : Persona
    {
        private int _codigo;

        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public Alumno (string nom, string ap, DateTime nac, int cod) : base (nom, ap, nac)
        {
            this._codigo = cod;

        }

        public override string GetCredencial ()
        {
            return this._codigo + " - " + this._nombre + this.Apellido;
        }
        public override string ToString()
        {
            return GetCredencial();
        }

    }
}
