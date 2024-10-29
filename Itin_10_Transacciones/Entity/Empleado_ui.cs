using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado_ui
    {
        long Dni;
        string ApellidoNombre;
        double SueldoBruto;
        
        public long DNI { get => Dni; set => Dni = value; }
        public string APELLIDONOMBRE { get => ApellidoNombre; set => ApellidoNombre = value; }
        public double SUELDOBRUTO { get => SueldoBruto; set => SueldoBruto = value; }

        public double CalcularSueldoNeto() { return SueldoBruto*.83; }
    }
}
