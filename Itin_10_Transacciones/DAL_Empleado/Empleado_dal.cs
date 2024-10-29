using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_Empleado
{
	public class Empleado_dal
	{
		public void RegistrarEmpleado(Empleado_ui empleadoNuevo) 
		{
            try
            {
                using (SqlConnection conexion = new SqlConnection(dbconfigurations.GetDBconnStr()))
                {
                    conexion.Open();
                    string query = "INSERT INTO EMPLEADO (DNI,APELLIDO_NOMBRE,SUELDO_BRUTO) VALUES(@Dni,@ApellidoNombre,@SueldoBruto)";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Dni", empleadoNuevo.DNI);
                        cmd.Parameters.AddWithValue("@ApellidoNombre", empleadoNuevo.APELLIDONOMBRE);
                        cmd.Parameters.AddWithValue("@SueldoBruto", empleadoNuevo.SUELDOBRUTO);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Empleado_ui> GetEmpleados()
        {
            List<Empleado_ui> listEmpleados = new List<Empleado_ui>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(dbconfigurations.GetDBconnStr()))
                {
                    conexion.Open();
                    string queryObtenerEmpleados = "SELECT DNI,APELLIDO_NOMBRE,SUELDO_BRUTO FROM EMPLEADO";
                    using (SqlCommand command = new SqlCommand(queryObtenerEmpleados, conexion))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Empleado_ui empleado = new Empleado_ui();
                                empleado.DNI = Convert.ToInt64(reader["DNI"].ToString());
                                empleado.APELLIDONOMBRE = reader["APELLIDO_NOMBRE"].ToString();
                                empleado.SUELDOBRUTO = Convert.ToDouble(reader["SUELDO_BRUTO"].ToString());
                                listEmpleados.Add(empleado);
                            }
                        }
                    }
                }
                return listEmpleados;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
