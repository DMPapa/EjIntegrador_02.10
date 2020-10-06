using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjIntegrador.Entidades
{
    class Bedel : Empleado
    {
        private string _apodo;

        public string Apodo
        {
            get { return this._apodo; }
            set { this._apodo = value; }
        }
        public Bedel(string nom, string ap, DateTime nac, DateTime ing, int leg, string apo) : base(nom, ap, nac, ing, leg)
        {
            this._apodo = apo;
        }

        public override string GetNombreCompleto()
        {
            return "Bedel " + this.Apodo;
        }
    }
}
