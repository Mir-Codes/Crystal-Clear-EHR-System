using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DAOCitaMedica : Conexion
    {

        public void Insert(Paciente paciente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.CadenaConexion;
                SqlCon.Open();
                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_pacientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 50;
                ParCedula.Value = paciente.Cedula;
                SqlCmd.Parameters.Add(ParCedula);



                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ingreso el registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message; //aqui se guarda el posible error que se capture.
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); //si la conexion esta abierta, se debe cerrar
            }
            //return rpta; //
        }

        public class Paciente
        {
            public string Cedula { get; set; }
            public string Nombre { get; set; }
            public string Sexo { get; set; }
            public DateTime fechaDeNacimiento { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public string Peso { get; set; }
            public string Estatura { get; set; }
        }

        
    }
}
