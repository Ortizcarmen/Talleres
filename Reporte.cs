using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talleres
{
    internal class Reporte
    {
        int DpiEstudiante;
        int CodigoTaller;
        DateTime Fecha;
        public int dpiestudiante { get => DpiEstudiante; set =>DpiEstudiante = value; }
        public int codigotaller { get => CodigoTaller; set => CodigoTaller = value; }
        public DateTime fecha { get => Fecha; set => Fecha = value; }   

    }
}
