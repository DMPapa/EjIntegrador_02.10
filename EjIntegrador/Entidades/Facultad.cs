using EjIntegrador;
using EjVtaRepuestos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjIntegrador.Entidades
{
    class Facultad
    {
        private string _nombre;
        private int _cantSedes;
        private List<Empleado> _empleados;
        private List<Alumno> _alumnos;

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public int CantidadSedes
        {
            get { return this._cantSedes; }
            set { this._cantSedes = value; }
        }
        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }
        public List<Empleado> Empleados
        {
            get { return this._empleados; }
            set { this._empleados = value; }
        }
        public Facultad(string nom, int sedes)
        {
            this._nombre = nom;
            this._cantSedes = sedes;
            this._empleados = new List<Empleado>();
            this._alumnos = new List<Alumno>();

        }

        public void AgregarAlumno(string nom, string ap, DateTime nac, int cod)
        {
            
            this.Alumnos.Add(new Alumno(nom, ap, nac, cod));

        }

        public void AgregarEmpleado(string tipoemp, string nom, string ap, DateTime nac, DateTime ing, int leg, string apo)
        {
            if (tipoemp.ToUpper() == "DOCENTE")
            { this._empleados.Add(new Docente(nom, ap, nac, ing, leg)); }
            else if (tipoemp.ToUpper() == "BEDEL")
            { this._empleados.Add(new Bedel(nom, ap, nac, ing, leg, apo)); }
            else if (tipoemp.ToUpper() == "DIRECTIVO")
            { this._empleados.Add(new Directivo(nom, ap, nac, ing, leg)); }
            else
            { throw new Exception("El tipo de empleado no existe"); }
        }
        public void EliminarAlumno(int cod)
        {
            int alumnosborrados = 0;
            foreach (Alumno al in this.Alumnos)
            {
                if (al.Codigo == cod)
                    _alumnos.Remove(al);
                alumnosborrados += 1;
            }
            if (alumnosborrados == 0)
                throw new Exception("No se ha borrado ningún alumno");
        }
        public void EliminarEmpleado(int leg)
        {
            int empleadosborrados = 0;
            foreach (Empleado emp in this.Empleados)
            {
                if (emp.Legajo == leg)
                {
                    empleadosborrados += 1;
                    _empleados.Remove(emp);
                }
            }
            if (empleadosborrados == 0)
                    throw new Exception("No se ha borrado ningún empleado");
        }
        public void ModificarEmpleado(int leg, string nnom, string nap, DateTime nfecha)
        {
            int empleadosborrados = 0;
            foreach (Empleado emp in this.Empleados)
            {
                if (emp.Legajo == leg)
                    emp.Nombre = nnom;
                emp.Apellido = nap;
                emp.Nacimiento = nfecha;

                empleadosborrados += 1;
            }
            if (empleadosborrados == 0)
                throw new Exception("No se ha modificado ningún empleado");
        }
        public List<Alumno> TraerAlumnos()
        {
           List<Alumno> listadodealumnos = new List<Alumno>();

            foreach (Alumno al in this.Alumnos)
            {
                listadodealumnos.Add(al);
            }
            return listadodealumnos;
        }
        public List<Empleado> TraerEmpleadoPorLegajo(int leg)
        {
            List<Empleado> listadoempleados = new List<Empleado>();
            foreach (Empleado emp in this.Empleados)
            {
                if (emp.Legajo == leg)
                    listadoempleados.Add(emp);
            }
            return listadoempleados;
        }
        public List<Empleado> TraerEmpleado()
        {
            List<Empleado> listadoempleados = new List<Empleado>();
            foreach (Empleado emp in this.Empleados)
            {
                    listadoempleados.Add(emp);
            }
            return listadoempleados;
        }
        public List<Empleado> TraerEmpleadoPorNombre(string nom)
        {
            List<Empleado> listadoempleados = new List<Empleado>();
            foreach (Empleado emp in this.Empleados)
            {
                if (emp.Nombre.ToUpper() == nom.ToUpper())
                    listadoempleados.Add(emp);
            }
            return listadoempleados;
        }
    }
}
