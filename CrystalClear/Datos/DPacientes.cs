using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //para manejar datos de SQL
using System.Data.SqlClient; //para poder enviar comandos de la app a el servidor SQL server

namespace Datos
{

    public class DPacientes:Conexion
    {
        private int _Id;
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
        private int _Estado;

        private string _TextoBuscar;


        //encapsulacion
        //con metodo setter and getter

        public int Id { get => _Id; set => _Id = value; }
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
        public int Estado { get => _Estado; set => _Estado = value; }
        




        //constructor vacio
        public DPacientes()
        {

        }

        //constructor con parametros
        public DPacientes(int id, string cedula, string nombre, DateTime fechanac, string sexo, string estcivil, string lugarnac, string direccion, string ocupacion, string telefono, string estadovivomuerto, string imagepath, string peso, string talla, string textobuscar, int estado )
        {
            //this se refiere a esta clase
            //this.Cedula es del metodo getter y setter
            //cedula en cambio, es el parametro que esta recibiendo el metodo
            this.Id = id;
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
            this.Estado = estado;



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
                ParCedula.Size = 50;
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

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.TinyInt;
                ParEstado.Size = 1;
                ParEstado.Value = pacientes.Estado;
                SqlCmd.Parameters.Add(ParEstado);

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

        ////Metodo Mostrar

        //public List<DPacientes> Mostrar(string TextoBuscar)
        //{
        //    DataTable DtResultado = new DataTable("Pacientes");
        //    SqlConnection SqlConectar = new SqlConnection();
        //    List<DPacientes> ListaGenerica = new List<DPacientes>();

        //    try
        //    {
        //        SqlConectar.ConnectionString = Conexion.CadenaConexion;
        //        SqlDataReader LeerFilas;
        //        SqlCommand SqlComando = new SqlCommand();
        //        SqlComando.Connection = SqlConectar;
        //        SqlComando.CommandText = "spmostrar_pacientes_cedula";
        //        SqlComando.CommandType = CommandType.StoredProcedure;
        //        //esto es cuando tiene alguna condicion
        //        SqlComando.Parameters.AddWithValue("@TextoBuscar", TextoBuscar);

        //        SqlConectar.Open();

        //        LeerFilas = SqlComando.ExecuteReader();

        //        while (LeerFilas.Read())
        //        {
        //            ListaGenerica.Add(new DPacientes
        //            {
        //                Cedula = LeerFilas.GetString(0),
        //                Nombre = LeerFilas.GetString(1),
        //                Fechanac = LeerFilas.GetDateTime(2),
        //                Sexo = LeerFilas.GetString(3),
        //                Estcivil = LeerFilas.GetString(4),
        //                Lugarnac = LeerFilas.GetString(5),
        //                Direccion = LeerFilas.GetString(6),
        //                Ocupacion = LeerFilas.GetString(7),
        //                Telefono = LeerFilas.GetString(8),
        //                Correo = LeerFilas.GetString(9),
        //                Estadovivomuerto = LeerFilas.GetString(10),
        //                Imagepath = LeerFilas.GetString(11),
        //                Peso = LeerFilas.GetString(12),
        //                Talla = LeerFilas.GetString(13),
        //                Estado = LeerFilas.GetInt32(14)
        //            });
        //        }
        //        LeerFilas.Close();
        //        SqlConectar.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        ListaGenerica = null;
                
        //    }

        //    return ListaGenerica;

        //}//fin del metodo mostrar

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


        //Metodo BuscarCedula

        public DataTable BuscarCedula(DPacientes pacientes)
        {

            DataTable DtResultado = new DataTable("Pacientes");

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.CadenaConexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cedula";
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



        }//fin funcion buscarcedula


        ////Buscar
        //public List<DPacientes> Buscar_Cedula(string TextoBuscar)
        //{
        //    DataTable DtResultado = new DataTable("Pacientes");
        //    SqlConnection SqlConectar = new SqlConnection();
        //    List<DPacientes> ListaGenerica = new List<DPacientes>();

        //    try
        //    {
        //        SqlConectar.ConnectionString = Conexion.CadenaConexion;
        //        SqlDataReader LeerFilas;
        //        SqlCommand SqlComando = new SqlCommand();
        //        SqlComando.Connection = SqlConectar;
        //        SqlComando.CommandText = "spbuscar_paciente_cedula";
        //        SqlComando.CommandType = CommandType.StoredProcedure;
        //        //esto es cuando tiene alguna condicion
        //        SqlComando.Parameters.AddWithValue("@textobuscar", TextoBuscar);

        //        SqlConectar.Open();

        //        LeerFilas = SqlComando.ExecuteReader();

        //        while (LeerFilas.Read())
        //        {
        //            ListaGenerica.Add(new DPacientes
        //            {

        //                Cedula = LeerFilas.GetString(1),
        //                Nombre = LeerFilas.GetString(2),
        //                Fechanac = LeerFilas.GetDateTime(3),
        //                Sexo = LeerFilas.GetString(4),
        //                Estcivil = LeerFilas.GetString(5),
        //                Lugarnac = LeerFilas.GetString(6),
        //                Direccion = LeerFilas.GetString(7),
        //                Ocupacion = LeerFilas.GetString(8),
        //                Telefono = LeerFilas.GetString(9),
        //                Correo = LeerFilas.GetString(10),
        //                Estadovivomuerto = LeerFilas.GetString(11),
        //                Imagepath = LeerFilas.GetString(12),
        //                Peso = LeerFilas.GetString(13),
        //                Talla = LeerFilas.GetString(14)


        //            });
        //        }
        //        LeerFilas.Close();
        //        SqlConectar.Close();
        //    }
        //    catch (Exception)
        //    {
        //        ListaGenerica = null;
        //    }

        //    return ListaGenerica;

        //}


        public string Anular(DPacientes Paciente)
        {
            string respuesta = "";
            SqlConnection SqlConectar = new SqlConnection();

            try
            {
                //conexion con la Base de Datos
                SqlConectar.ConnectionString = Conexion.CadenaConexion;
                SqlConectar.Open();

                //comandos
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConectar;
                SqlComando.CommandText = "spanular_pacientes";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //parametros

                //parametro id
                SqlParameter Parametro_Id_Paciente = new SqlParameter();
                Parametro_Id_Paciente.ParameterName = "@cedula";
                Parametro_Id_Paciente.SqlDbType = SqlDbType.VarChar;
                Parametro_Id_Paciente.Value = Paciente.Cedula;
                SqlComando.Parameters.Add(Parametro_Id_Paciente);

                //ejecuta y lo envia en comentario
                respuesta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "No se anulo el Registro del paciente";

            }
            catch (Exception excepcion)
            {
                respuesta = excepcion.Message;
            }

            //se cierra la conexion de la Base de Datos
            finally
            {
                if (SqlConectar.State == ConnectionState.Open)
                {
                    SqlConectar.Close();
                }
            }
            return respuesta;

        }






    }
}
