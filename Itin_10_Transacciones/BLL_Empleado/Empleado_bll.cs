using DAL_Empleado;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL_Empleado
{
    public class Empleado_bll
    {
        Empleado_dal empleado_Dal = new Empleado_dal();
        public void RegistrarEmpleado(Empleado_ui empleadoNuevo)
        {
            using (var trx = new TransactionScope())
            {
                try
                {

                    if (empleadoNuevo.DNI.ToString().Length != 11) throw new Exception("El DNI debe contener 11 dígitos");
                    if (empleadoNuevo.APELLIDONOMBRE.ToString().Length <= 5) throw new Exception("El Apellido y Nombre debe tener al menos 5 caracteres");
                    if (empleadoNuevo.SUELDOBRUTO <= 100000) throw new Exception("El sueldo bruto debe ser mayor a salario minimo vital y movil de $100000");
                    empleado_Dal.RegistrarEmpleado(empleadoNuevo);
                    trx.Complete();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public void RegistrarListaEmpleados(List<Empleado_ui> listEmpleados)
        {
            using (var trx = new TransactionScope())
            {
                try
                {
                    foreach (Empleado_ui e in listEmpleados)
                    {
                        RegistrarEmpleado(e);
                    }
                    trx.Complete();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public List<Empleado_ui> MostrarLista()
        {
            try
            {
                return empleado_Dal.GetEmpleados();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
