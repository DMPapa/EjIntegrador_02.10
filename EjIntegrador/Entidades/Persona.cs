using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjIntegrador.Entidades
{
    abstract class Persona
    {
        protected string _apellido;
        protected DateTime _fechaNac;
        protected string _nombre;
  
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public DateTime Nacimiento
        {
            get { return this._fechaNac; }
            set { this._fechaNac = value; }
        }

        public Persona (string nom, string ap, DateTime nac)
        {
            this._nombre = nom;
            this._apellido = ap;
            this._fechaNac = nac;
        }

        public int Edad
        {
            get { return Convert.ToInt32((DateTime.Now - this._fechaNac).TotalDays /365); }
        }

        public virtual string GetCredencial ()
        {
            return this._nombre + this._apellido + "- Edad: " + this.Edad;
        }
        public virtual string GetNombreCompleto ()
        {
            return (this.Nombre + " " + this._apellido);
        }

        public override string ToString()
        {
            return GetCredencial();
        }
    }
}
