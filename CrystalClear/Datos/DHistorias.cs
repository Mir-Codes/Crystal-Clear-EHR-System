using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //para manejar datos de SQL
using System.Data.SqlClient; //para poder enviar comandos de la app a el servidor SQL server

namespace Datos
{
    public class DHistorias:Conexion
    {
        private int _Id;
        private int _Paciente_id;
        private DateTime _Fecha_consulta;
        private string _Razon_consulta;
        private string _Enfermedad_actual;
        private int _Insomnia;
        private int _Estrenimiento;
        private string _Historia_familiar;
        private string _Historia_personal;
        private string _Tratamiento_actual;
        private string _Examen_fisico;
        private string _Laboratorio;
        private string _ECG;
        private string _Rayos_x;
        private string _Ecocardiograma;
        private string _Otras_paraclinicas;
        private string _Diagnosticos;
        private string _Plan_estudio;
        private string _Plan_terapeutico;
        private int _Estado;

        private int _Idbuscar;


        //encapsulacion
        //con metodo setter and getter

        public int Id { get => _Id; set => _Id = value; }
        public int Paciente_id { get => _Paciente_id; set => _Paciente_id = value; }
        public DateTime Fecha_consulta { get => _Fecha_consulta; set => _Fecha_consulta = value; }
        public string Razon_consulta { get => _Razon_consulta; set => _Razon_consulta = value; }
        public string Enfermedad_actual { get => _Enfermedad_actual; set => _Enfermedad_actual = value; }
        public int Insomnia { get => _Insomnia; set => _Insomnia = value; }
        public int Estrenimiento { get => _Estrenimiento; set => _Estrenimiento = value; }
        public string Historia_familiar { get => _Historia_familiar; set => _Historia_familiar = value; }
        public string Historia_personal { get => _Historia_personal; set => _Historia_personal = value; }
        public string Tratamiento_actual { get => _Tratamiento_actual; set => _Tratamiento_actual = value; }
        public string Examen_fisico { get => _Examen_fisico; set => _Examen_fisico = value; }
        public string Laboratorio { get => _Laboratorio; set => _Laboratorio = value; }
        public string ECG { get => _ECG; set => _ECG = value; }
        public string Rayos_x { get => _Rayos_x; set => _Rayos_x = value; }
        public string Ecocardiograma { get => _Ecocardiograma; set => _Ecocardiograma = value; }
        public string Otras_paraclinicas { get => _Otras_paraclinicas; set => _Otras_paraclinicas = value; }
        public string Diagnosticos { get => _Diagnosticos; set => _Diagnosticos = value; }
        public string Plan_estudio { get => _Plan_estudio; set => _Plan_estudio = value; }
        public string Plan_terapeutico { get => _Plan_terapeutico; set => _Plan_terapeutico = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public int Idbuscar { get => _Idbuscar; set => _Idbuscar = value; }
        



        //constructor vacio
        public DHistorias()
        {

        }

        //constructor con parametros
        public DHistorias( int id, int paciente_id, DateTime fecha_consulta, string razon_consulta, 
            string enfermedad_actual, int insomnia, int estrenimiento, string historia_familiar, 
            string historia_personal, string tratamiento_actual, string examen_fisico, string laboratorio, 
            string ECG, string rayos_x, string ecocardiograma, string otras_paraclinicas, string diagnosticos, 
            string plan_estudio, string plan_terapeutico, int estado)
        {
            //this se refiere a esta clase
            //this.Cedula es del metodo getter y setter
            //cedula en cambio, es el parametro que esta recibiendo el metodo

            this.Id = id;
            this.Paciente_id = paciente_id;
            this.Fecha_consulta = fecha_consulta;
            this.Razon_consulta = razon_consulta;
            this.Enfermedad_actual = enfermedad_actual;
            this.Insomnia = insomnia;
            this.Estrenimiento = estrenimiento;
            this.Historia_familiar = historia_familiar;
            this.Historia_personal = historia_personal;
            this.Tratamiento_actual = tratamiento_actual;
            this.Examen_fisico = examen_fisico;
            this.Laboratorio = laboratorio;
            this.ECG = ECG;
            this.Rayos_x = rayos_x;
            this.Ecocardiograma = ecocardiograma;
            this.Otras_paraclinicas = otras_paraclinicas;
            this.Diagnosticos = diagnosticos;
            this.Plan_estudio = plan_estudio;
            this.Plan_terapeutico = plan_terapeutico;
            this.Estado = estado;


        }


        //Metodo Insertar

        public string Insertar(DHistorias historias)
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
                SqlCmd.CommandText = "spinsertar_historias";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPacienteId = new SqlParameter();
                ParPacienteId.ParameterName = "@paciente_id";
                ParPacienteId.SqlDbType = SqlDbType.TinyInt;
                ParPacienteId.Size = 4;
                ParPacienteId.Value = historias.Paciente_id;
                SqlCmd.Parameters.Add(ParPacienteId);

                SqlParameter ParFechaConsulta = new SqlParameter();
                ParFechaConsulta.ParameterName = "@fecha_consulta";
                ParFechaConsulta.SqlDbType = SqlDbType.Date;
                ParFechaConsulta.Value = historias.Fecha_consulta;
                SqlCmd.Parameters.Add(ParFechaConsulta);

                SqlParameter ParRazonConsulta = new SqlParameter();
                ParRazonConsulta.ParameterName = "@razon_consulta";
                ParRazonConsulta.SqlDbType = SqlDbType.NVarChar;
                ParRazonConsulta.Value = historias.Razon_consulta;
                SqlCmd.Parameters.Add(ParRazonConsulta);

                SqlParameter ParEnfermedadActual = new SqlParameter();
                ParEnfermedadActual.ParameterName = "@enfermedad_actual";
                ParEnfermedadActual.SqlDbType = SqlDbType.NVarChar;
                ParEnfermedadActual.Value = historias.Enfermedad_actual;
                SqlCmd.Parameters.Add(ParEnfermedadActual);

                SqlParameter ParInsomnia = new SqlParameter();
                ParInsomnia.ParameterName = "@insomnia";
                ParInsomnia.SqlDbType = SqlDbType.TinyInt;
                ParInsomnia.Size = 1;
                ParInsomnia.Value = historias.Insomnia;
                SqlCmd.Parameters.Add(ParInsomnia);

                SqlParameter ParEstrenimiento = new SqlParameter();
                ParEstrenimiento.ParameterName = "@estrenimiento";
                ParEstrenimiento.SqlDbType = SqlDbType.TinyInt;
                ParEstrenimiento.Size = 1;
                ParEstrenimiento.Value = historias.Estrenimiento;
                SqlCmd.Parameters.Add(ParEstrenimiento);

                SqlParameter ParHistoriaFamiliar = new SqlParameter();
                ParHistoriaFamiliar.ParameterName = "@historia_familiar";
                ParHistoriaFamiliar.SqlDbType = SqlDbType.VarChar;
                ParHistoriaFamiliar.Value = historias.Historia_familiar;
                SqlCmd.Parameters.Add(ParHistoriaFamiliar);

                SqlParameter ParHistoriaPersonal = new SqlParameter();
                ParHistoriaPersonal.ParameterName = "@historia_personal";
                ParHistoriaPersonal.SqlDbType = SqlDbType.VarChar;
                ParHistoriaPersonal.Value = historias.Historia_personal;
                SqlCmd.Parameters.Add(ParHistoriaPersonal);

                SqlParameter ParaTratamientoActual = new SqlParameter();
                ParaTratamientoActual.ParameterName = "@tratamiento_actual";
                ParaTratamientoActual.SqlDbType = SqlDbType.VarChar;
                ParaTratamientoActual.Value = historias.Tratamiento_actual;
                SqlCmd.Parameters.Add(ParaTratamientoActual);

                SqlParameter ParExamenFisico = new SqlParameter();
                ParExamenFisico.ParameterName = "@examen_fisico";
                ParExamenFisico.SqlDbType = SqlDbType.VarChar;
                ParExamenFisico.Value = historias.Examen_fisico;
                SqlCmd.Parameters.Add(ParExamenFisico);

                SqlParameter ParLaboratorio = new SqlParameter();
                ParLaboratorio.ParameterName = "@laboratorio";
                ParLaboratorio.SqlDbType = SqlDbType.VarChar;
                ParLaboratorio.Value = historias.Laboratorio;
                SqlCmd.Parameters.Add(ParLaboratorio);

                SqlParameter ParECG = new SqlParameter();
                ParECG.ParameterName = "@ECG";
                ParECG.SqlDbType = SqlDbType.VarChar;
                ParECG.Value = historias.ECG;
                SqlCmd.Parameters.Add(ParECG);

                SqlParameter ParRayosX = new SqlParameter();
                ParRayosX.ParameterName = "@rayos_x";
                ParRayosX.SqlDbType = SqlDbType.VarChar;
                ParRayosX.Value = historias.Ecocardiograma;
                SqlCmd.Parameters.Add(ParRayosX);

                SqlParameter ParEcocardiograma = new SqlParameter();
                ParEcocardiograma.ParameterName = "@ecocardiograma";
                ParEcocardiograma.SqlDbType = SqlDbType.VarChar;
                ParEcocardiograma.Value = historias.Ecocardiograma;
                SqlCmd.Parameters.Add(ParEcocardiograma);

                SqlParameter ParOtrasParaclinicas = new SqlParameter();
                ParOtrasParaclinicas.ParameterName = "@otras_paraclinicas";
                ParOtrasParaclinicas.SqlDbType = SqlDbType.VarChar;
                ParOtrasParaclinicas.Value = historias.Otras_paraclinicas;
                SqlCmd.Parameters.Add(ParOtrasParaclinicas);

                SqlParameter ParDiagnosticos = new SqlParameter();
                ParDiagnosticos.ParameterName = "@diagnosticos";
                ParDiagnosticos.SqlDbType = SqlDbType.VarChar;
                ParDiagnosticos.Value = historias.Diagnosticos;
                SqlCmd.Parameters.Add(ParDiagnosticos);

                SqlParameter ParPlanEstudio = new SqlParameter();
                ParPlanEstudio.ParameterName = "@plan_estudio";
                ParPlanEstudio.SqlDbType = SqlDbType.VarChar;
                ParPlanEstudio.Value = historias.Plan_estudio;
                SqlCmd.Parameters.Add(ParPlanEstudio);

                SqlParameter ParPlanTerapeutico = new SqlParameter();
                ParPlanTerapeutico.ParameterName = "@plan_terapeutico";
                ParPlanTerapeutico.SqlDbType = SqlDbType.VarChar;
                ParPlanTerapeutico.Value = historias.Plan_terapeutico;
                SqlCmd.Parameters.Add(ParPlanTerapeutico);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.TinyInt;
                ParEstado.Size = 1;
                ParEstado.Value = historias.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se ingreso el registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message + ex.ToString(); //aqui se guarda el posible error que se capture.
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); //si la conexion esta abierta, se debe cerrar
            }
            return rpta; //


        }//fin funcion insertar



        //Metodo Editar

        public string Editar(DHistorias historias)
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
                SqlCmd.CommandText = "speditar_historias";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPacienteId = new SqlParameter();
                ParPacienteId.ParameterName = "@paciente_id";
                ParPacienteId.SqlDbType = SqlDbType.TinyInt;
                ParPacienteId.Size = 4;
                ParPacienteId.Value = historias.Paciente_id;
                SqlCmd.Parameters.Add(ParPacienteId);

                SqlParameter ParFechaConsulta = new SqlParameter();
                ParFechaConsulta.ParameterName = "@fecha_consulta";
                ParFechaConsulta.SqlDbType = SqlDbType.Date;
                ParFechaConsulta.Value = historias.Fecha_consulta;
                SqlCmd.Parameters.Add(ParFechaConsulta);

                SqlParameter ParRazonConsulta = new SqlParameter();
                ParRazonConsulta.ParameterName = "@razon_consulta";
                ParRazonConsulta.SqlDbType = SqlDbType.NVarChar;
                ParRazonConsulta.Value = historias.Razon_consulta;
                SqlCmd.Parameters.Add(ParRazonConsulta);

                SqlParameter ParEnfermedadActual = new SqlParameter();
                ParEnfermedadActual.ParameterName = "@enfermedad_actual";
                ParEnfermedadActual.SqlDbType = SqlDbType.NVarChar;
                ParEnfermedadActual.Value = historias.Enfermedad_actual;
                SqlCmd.Parameters.Add(ParEnfermedadActual);

                SqlParameter ParInsomnia = new SqlParameter();
                ParInsomnia.ParameterName = "@insomnia";
                ParInsomnia.SqlDbType = SqlDbType.TinyInt;
                ParInsomnia.Size = 1;
                ParInsomnia.Value = historias.Insomnia;
                SqlCmd.Parameters.Add(ParInsomnia);

                SqlParameter ParEstrenimiento = new SqlParameter();
                ParEstrenimiento.ParameterName = "@estrenimiento";
                ParEstrenimiento.SqlDbType = SqlDbType.TinyInt;
                ParEstrenimiento.Size = 1;
                ParEstrenimiento.Value = historias.Estrenimiento;
                SqlCmd.Parameters.Add(ParEstrenimiento);

                SqlParameter ParHistoriaFamiliar = new SqlParameter();
                ParHistoriaFamiliar.ParameterName = "@historia_familiar";
                ParHistoriaFamiliar.SqlDbType = SqlDbType.VarChar;
                ParHistoriaFamiliar.Value = historias.Historia_familiar;
                SqlCmd.Parameters.Add(ParHistoriaFamiliar);

                SqlParameter ParHistoriaPersonal = new SqlParameter();
                ParHistoriaPersonal.ParameterName = "@historia_personal";
                ParHistoriaPersonal.SqlDbType = SqlDbType.VarChar;
                ParHistoriaPersonal.Value = historias.Historia_personal;
                SqlCmd.Parameters.Add(ParHistoriaPersonal);

                SqlParameter ParaTratamientoActual = new SqlParameter();
                ParaTratamientoActual.ParameterName = "@tratamiento_actual";
                ParaTratamientoActual.SqlDbType = SqlDbType.VarChar;
                ParaTratamientoActual.Value = historias.Tratamiento_actual;
                SqlCmd.Parameters.Add(ParaTratamientoActual);

                SqlParameter ParExamenFisico = new SqlParameter();
                ParExamenFisico.ParameterName = "@examen_fisico";
                ParExamenFisico.SqlDbType = SqlDbType.VarChar;
                ParExamenFisico.Value = historias.Examen_fisico;
                SqlCmd.Parameters.Add(ParExamenFisico);

                SqlParameter ParLaboratorio = new SqlParameter();
                ParLaboratorio.ParameterName = "@laboratorio";
                ParLaboratorio.SqlDbType = SqlDbType.VarChar;
                ParLaboratorio.Value = historias.Laboratorio;
                SqlCmd.Parameters.Add(ParLaboratorio);

                SqlParameter ParECG = new SqlParameter();
                ParECG.ParameterName = "@ECG";
                ParECG.SqlDbType = SqlDbType.VarChar;
                ParECG.Value = historias.ECG;
                SqlCmd.Parameters.Add(ParECG);

                SqlParameter ParRayosX = new SqlParameter();
                ParRayosX.ParameterName = "@rayos_x";
                ParRayosX.SqlDbType = SqlDbType.VarChar;
                ParRayosX.Value = historias.Ecocardiograma;
                SqlCmd.Parameters.Add(ParRayosX);

                SqlParameter ParEcocardiograma = new SqlParameter();
                ParEcocardiograma.ParameterName = "@ecocardiograma";
                ParEcocardiograma.SqlDbType = SqlDbType.VarChar;
                ParEcocardiograma.Value = historias.Ecocardiograma;
                SqlCmd.Parameters.Add(ParEcocardiograma);

                SqlParameter ParOtrasParaclinicas = new SqlParameter();
                ParOtrasParaclinicas.ParameterName = "@otras_paraclinicas";
                ParOtrasParaclinicas.SqlDbType = SqlDbType.VarChar;
                ParOtrasParaclinicas.Value = historias.Otras_paraclinicas;
                SqlCmd.Parameters.Add(ParOtrasParaclinicas);

                SqlParameter ParDiagnosticos = new SqlParameter();
                ParDiagnosticos.ParameterName = "@diagnosticos";
                ParDiagnosticos.SqlDbType = SqlDbType.VarChar;
                ParDiagnosticos.Value = historias.Diagnosticos;
                SqlCmd.Parameters.Add(ParDiagnosticos);

                SqlParameter ParPlanEstudio = new SqlParameter();
                ParPlanEstudio.ParameterName = "@plan_estudio";
                ParPlanEstudio.SqlDbType = SqlDbType.VarChar;
                ParPlanEstudio.Value = historias.Plan_estudio;
                SqlCmd.Parameters.Add(ParPlanEstudio);

                SqlParameter ParPlanTerapeutico = new SqlParameter();
                ParPlanTerapeutico.ParameterName = "@plan_terapeutico";
                ParPlanTerapeutico.SqlDbType = SqlDbType.VarChar;
                ParPlanTerapeutico.Value = historias.Plan_terapeutico;
                SqlCmd.Parameters.Add(ParPlanTerapeutico);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.TinyInt;
                ParEstado.Size = 1;
                ParEstado.Value = historias.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "No se edito el registro";


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



        //Metodo BuscarIdPaciente
        public DataTable BuscarIdPaciente(DHistorias Historias)
        {

            DataTable DtResultado = new DataTable("Historias");

            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.CadenaConexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_id_paciente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdBuscar = new SqlParameter();
                ParIdBuscar.ParameterName = "@idbuscar";
                ParIdBuscar.SqlDbType = SqlDbType.VarChar;
                ParIdBuscar.Size = 4;
                ParIdBuscar.Value = Historias._Idbuscar;
                SqlCmd.Parameters.Add(ParIdBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                ex.ToString();
            }
            return DtResultado;



        }//fin funcion buscar_id_paciente



    }
}
