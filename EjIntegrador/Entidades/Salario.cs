using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjIntegrador.Entidades
{
    class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        public double Bruto
        {
            get { return this._bruto; }
            set { this._bruto = value; }
        }
        public string CodigoTransferencia
        {
            get { return this._codigoTransferencia; }
            set { this._codigoTransferencia = value; }
        }
        public double Descuento
        {
            get { return this._descuentos; }
            set { this._descuentos = value; }
        }
        public DateTime Fecha
        {
            get { return this._fecha; }
            set { this._fecha = value; }
        }

        public Salario (double bru, string codt, DateTime fech)
        {
            this._bruto = bru;
            this._codigoTransferencia = codt;
            this._descuentos = bru * 0.17;
            this._fecha = fech;
        }

        public double GetSalarioNeto()
        {
            return this._bruto - this._descuentos;
        }

    }
}
