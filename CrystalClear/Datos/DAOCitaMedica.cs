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

        public void Insert(CitaMedica citaMedica)
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
                ParCedula.Value = citaMedica.Paciente.Cedula;
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

        public class CitaMedica
        {
            public string Id { get; set; }
            public int NumeroDeTurno { get; set; }
            public Paciente Paciente { get; set; }
            public List<TipoDeEstudios> TiposDeEstudios {get;set;}
            public List<MetodoDePago> MetodosDePagos { get; set; }
            public DateTime FechaDeAtencion { get; set; }
            public DateTime HoraDeAtencion { get; set; }
        }

        public class Paciente
        {
            public string Id { get; set; }
            public string Cedula { get; set; }
            public string Nombre { get; set; }
            public string Sexo { get; set; }
            public DateTime FechaDeNacimiento { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public string Peso { get; set; }
            public string Estatura { get; set; }
        }


        public class TipoDeEstudios 
        { 
            public string Id { get; set; }
            public string Nombre { get; set; }
        }

        public class MetodoDePago {

            public string Id { get; set; }
            public string Nombre { get; set; }
            public decimal Monto { get; set; }
        }
        
    }
}
