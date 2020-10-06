using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjIntegrador.Entidades
{
    public class ErrorIngreso : Exception
    {
        public ErrorIngreso(string message) : base ("Ingreso erróneo")
        { 
        }
    }
    

}
