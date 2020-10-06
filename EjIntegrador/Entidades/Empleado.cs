using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EjIntegrador.Entidades
{
        abstract class Empleado : Persona
        {
            protected DateTime _fechaingreso;
            protected int _legajo;
            protected List<Salario> _salarios;

            public DateTime FechaIngreso
            {
                get { return this._fechaingreso; }
                set { this._fechaingreso = value; }
            }

            public int Legajo
            {
                get { return this._legajo; }
                set { this._legajo = value; }
            }
            public DateTime FechaNacimiento
            {
                get { return this._fechaNac; }
            }
            public int Antiguedad
            {
                get { return this._fechaingreso.Year; }
            }
            public Empleado (string nom, string ap, DateTime nac, DateTime ing, int leg) : base (nom, ap, nac)
            {
                this._fechaingreso = ing;
                this._legajo = leg;
                this._salarios = new List<Salario>();
            }

        public override string GetCredencial()
        {
            return "algo";
        }
        public override string GetNombreCompleto()
        {
            return this._nombre + " " + this._apellido;
        }

        public override string ToString()
        {
            return GetCredencial();
        }
    }
}
