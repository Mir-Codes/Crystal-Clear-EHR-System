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

            if (string.IsNullOrEmpty(citaMedica.Paciente.Id))
            {
                InsertPacientFirst(citaMedica);
            }
            else
            {
                InsertWhenPacientExist(citaMedica);
            }
            
        }

        private void InsertPacientFirst(CitaMedica citaMedica) 
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
                SqlCmd.CommandText = "insert_new_appointment_with_pacient";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@paciente_cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Size = 50;
                ParCedula.Value = citaMedica.Paciente.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@paciente_nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = citaMedica.Paciente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParFechaNac = new SqlParameter();
                ParFechaNac.ParameterName = "@paciente_fecha_nacimiento";
                ParFechaNac.SqlDbType = SqlDbType.Date;
                ParFechaNac.Value = citaMedica.Paciente.FechaDeNacimiento;
                SqlCmd.Parameters.Add(ParFechaNac);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@paciente_sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 2;
                ParSexo.Value = citaMedica.Paciente.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@paciente_telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = citaMedica.Paciente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@paciente_correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = citaMedica.Paciente.Email;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParPeso = new SqlParameter();
                ParPeso.ParameterName = "@paciente_peso";
                ParPeso.SqlDbType = SqlDbType.VarChar;
                ParPeso.Size = 5;
                ParPeso.Value = citaMedica.Paciente.Peso;
                SqlCmd.Parameters.Add(ParPeso);

                SqlParameter ParTalla = new SqlParameter();
                ParTalla.ParameterName = "@paciente_talla";
                ParTalla.SqlDbType = SqlDbType.VarChar;
                ParTalla.Size = 5;
                ParTalla.Value = citaMedica.Paciente.Estatura;
                SqlCmd.Parameters.Add(ParTalla);


                SqlParameter ParFechaCita = new SqlParameter();
                ParFechaCita.ParameterName = "@cita_fecha";
                ParFechaCita.SqlDbType = SqlDbType.Date;
                ParFechaCita.Value = citaMedica.FechaDeAtencion;
                SqlCmd.Parameters.Add(ParFechaCita);

                //Ejecutamos nuestro comando
                int rowsAffected = SqlCmd.ExecuteNonQuery();
                rpta = rowsAffected == 1 ? "Ok" : "No se ingreso el registro";

                int a = 0;
                a++;
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

        private void InsertWhenPacientExist(CitaMedica citaMedica) 
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
