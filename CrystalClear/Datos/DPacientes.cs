using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    using System.Data; //para manejar datos de SQL
    using System.Data.SqlClient; //para poder enviar comandos de la app a el servidor SQL server
    class DPacientes
    {
        private string _Cedula;
        private string _Nombre;
        private DateTime _Fechanac;
        private string _Sexo;
        private string _Estcivil;
        private string _Lugarnac;
        private string _Direccion;
        private string _Ocupacion;
        private string _Telefono;
        private string _Correo;
        private string _Estadovivomuerto;
        private string _Imagepath;
        private string _Peso;
        private string _Talla;

        private string _TextoBuscar;


        //encapsulacion
        //con metodo setter and getter

        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public DateTime Fechanac { get => _Fechanac; set => _Fechanac = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public string Estcivil { get => _Estcivil; set => _Estcivil = value; }
        public string Lugarnac { get => _Lugarnac; set => _Lugarnac = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Ocupacion { get => _Ocupacion; set => _Ocupacion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Estadovivomuerto { get => _Estadovivomuerto; set => _Estadovivomuerto = value; }
        public string Imagepath { get => _Imagepath; set => _Imagepath = value; }
        public string Peso { get => _Peso; set => _Peso = value; }
        public string Talla { get => _Talla; set => _Talla = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }
  



        //constructor vacio
        public DPacientes()
        {

        }

        //constructor con parametros
        public DPacientes(string cedula, string nombre, DateTime fechanac, string sexo, string estcivil, string lugarnac, string direccion, string ocupacion, string telefono, string estadovivomuerto, string imagepath, string peso, string talla, string textobuscar )
        {
            //this se refiere a esta clase
            //this.Cedula es del metodo getter y setter
            //cedula en cambio, es el parametro que esta recibiendo el metodo
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Fechanac = fechanac;
            this.Sexo = sexo;
            this.Estcivil = estcivil;
            this.Lugarnac = lugarnac;
            this.Direccion = direccion;
            this.Ocupacion = ocupacion;
            this.Telefono = telefono;
            this.Estadovivomuerto = estadovivomuerto;
            this.Imagepath = imagepath;
            this.Peso = peso;
            this.Talla = talla;
            this.TextoBuscar = textobuscar;


        }


        //Metodo Insertar

        public string Insertar(DPacientes pacientes)
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
                ParCedula.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCedula);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = pacientes.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParFechaNac = new SqlParameter();
                ParFechaNac.ParameterName = "@fechanac";
                ParFechaNac.SqlDbType = SqlDbType.Date;
                ParFechaNac.Value = pacientes.Fechanac;
                SqlCmd.Parameters.Add(ParFechaNac);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 2;
                ParSexo.Value = pacientes.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEstCivil = new SqlParameter();
                ParEstCivil.ParameterName = "@estcivil";
                ParEstCivil.SqlDbType = SqlDbType.VarChar;
                ParEstCivil.Size = 50;
                ParEstCivil.Value = pacientes.Estcivil;
                SqlCmd.Parameters.Add(ParEstCivil);

                SqlParameter ParLugarNac = new SqlParameter();
                ParLugarNac.ParameterName = "@lugnac";
                ParLugarNac.SqlDbType = SqlDbType.VarChar;
                ParLugarNac.Size = 50;
                ParLugarNac.Value = pacientes.Lugarnac;
                SqlCmd.Parameters.Add(ParLugarNac);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = pacientes.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParOcupacion = new SqlParameter();
                ParOcupacion.ParameterName = "@ocupacion";
                ParOcupacion.SqlDbType = SqlDbType.VarChar;
                ParOcupacion.Size = 10;
                ParOcupacion.Value = pacientes.Ocupacion;
                SqlCmd.Parameters.Add(ParOcupacion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = pacientes.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = pacientes.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParEstadoVivoMuerto = new SqlParameter();
                ParEstadoVivoMuerto.ParameterName = "@estadovm";
                ParEstadoVivoMuerto.SqlDbType = SqlDbType.VarChar;
                ParEstadoVivoMuerto.Size = 50;
                ParEstadoVivoMuerto.Value = pacientes.Estadovivomuerto;
                SqlCmd.Parameters.Add(ParEstadoVivoMuerto);

                SqlParameter ParImgPath = new SqlParameter();
                ParImgPath.ParameterName = "@imgpath";
                ParImgPath.SqlDbType = SqlDbType.VarChar;
                ParImgPath.Value = pacientes.Imagepath;
                SqlCmd.Parameters.Add(ParImgPath);

                SqlParameter ParPeso = new SqlParameter();
                ParPeso.ParameterName = "@peso";
                ParPeso.SqlDbType = SqlDbType.VarChar;
                ParPeso.Size = 5;
                ParPeso.Value = pacientes.Peso;
                SqlCmd.Parameters.Add(ParPeso);

                SqlParameter ParTalla = new SqlParameter();
                ParTalla.ParameterName = "@talla";
                ParTalla.SqlDbType = SqlDbType.VarChar;
                ParTalla.Size = 5;
                ParTalla.Value = pacientes.Talla;
                SqlCmd.Parameters.Add(ParTalla);

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
            return rpta; //


        }//fin funcion insertar


        //Metodo Editar

        public string Editar(DPacientes pacientes)
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
                SqlCmd.CommandText = "speditar_pacientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Value = pacientes.Cedula;
                SqlCmd.Parameters.Add(ParCedula);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = pacientes.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParFechaNac = new SqlParameter();
                ParFechaNac.ParameterName = "@fechanac";
                ParFechaNac.SqlDbType = SqlDbType.Date;
                ParFechaNac.Value = pacientes.Fechanac;
                SqlCmd.Parameters.Add(ParFechaNac);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 2;
                ParSexo.Value = pacientes.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEstCivil = new SqlParameter();
                ParEstCivil.ParameterName = "@estcivil";
                ParEstCivil.SqlDbType = SqlDbType.VarChar;
                ParEstCivil.Size = 50;
                ParEstCivil.Value = pacientes.Estcivil;
                SqlCmd.Parameters.Add(ParEstCivil);

                SqlParameter ParLugarNac = new SqlParameter();
                ParLugarNac.ParameterName = "@lugnac";
                ParLugarNac.SqlDbType = SqlDbType.VarChar;
                ParLugarNac.Size = 50;
                ParLugarNac.Value = pacientes.Lugarnac;
                SqlCmd.Parameters.Add(ParLugarNac);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 50;
                ParDireccion.Value = pacientes.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParOcupacion = new SqlParameter();
                ParOcupacion.ParameterName = "@ocupacion";
                ParOcupacion.SqlDbType = SqlDbType.VarChar;
                ParOcupacion.Size = 10;
                ParOcupacion.Value = pacientes.Ocupacion;
                SqlCmd.Parameters.Add(ParOcupacion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = pacientes.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = pacientes.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParEstadoVivoMuerto = new SqlParameter();
                ParEstadoVivoMuerto.ParameterName = "@estadovm";
                ParEstadoVivoMuerto.SqlDbType = SqlDbType.VarChar;
                ParEstadoVivoMuerto.Size = 50;
                ParEstadoVivoMuerto.Value = pacientes.Estadovivomuerto;
                SqlCmd.Parameters.Add(ParEstadoVivoMuerto);

                SqlParameter ParImgPath = new SqlParameter();
                ParImgPath.ParameterName = "@imgpath";
                ParImgPath.SqlDbType = SqlDbType.VarChar;
                ParImgPath.Value = pacientes.Imagepath;
                SqlCmd.Parameters.Add(ParImgPath);

                SqlParameter ParPeso = new SqlParameter();
                ParPeso.ParameterName = "@peso";
                ParPeso.SqlDbType = SqlDbType.VarChar;
                ParPeso.Size = 5;
                ParPeso.Value = pacientes.Peso;
                SqlCmd.Parameters.Add(ParPeso);

                SqlParameter ParTalla = new SqlParameter();
                ParTalla.ParameterName = "@talla";
                ParTalla.SqlDbType = SqlDbType.VarChar;
                ParTalla.Size = 5;
                ParTalla.Value = pacientes.Talla;
                SqlCmd.Parameters.Add(ParTalla);

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
            return rpta; //



        }//fin funcion editar

        //Metodo Eliminar

        public string Eliminar(DPacientes pacientes)
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
                SqlCmd.CommandText = "speliminar_pacientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCedula = new SqlParameter();
                ParCedula.ParameterName = "@cedula";
                ParCedula.SqlDbType = SqlDbType.VarChar;
                ParCedula.Value = pacientes.Cedula;
                SqlCmd.Parameters.Add(ParCedula);


                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se elimino el registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message; //aqui se guarda el posible error que se capture.
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); //si la conexion esta abierta, se debe cerrar
            }
            return rpta; //



        }//fin funcion eliminar

        //Metodo Mostrar

        public DataTable Mostrar(DPacientes pacientes) //aqui se mostraran todos los registros Pacientes en una tabla
        {
            DataTable DtResultado = new DataTable("Pacientes");

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.CadenaConexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_pacientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch(Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }//fin de la funcion mostrar
         
        //Metodo BuscarNombre

        public DataTable BuscarNombre (DPacientes pacientes)
        {

            DataTable DtResultado = new DataTable("Pacientes");

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.CadenaConexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = pacientes.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }//fin funcion buscarnombre




    }
}
