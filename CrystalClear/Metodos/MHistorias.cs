using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using System.Data;

namespace Metodos
{
    public class MHistorias
    {

        //Metodo Insertar que llama al metodo Insertar de la clase DHistorias de la capa Datos

        public static string Insertar(int paciente_id, DateTime fecha_consulta, string razon_consulta,
            string enfermedad_actual, int insomnia, int estrenimiento, string historia_familiar,
            string historia_personal, string tratamiento_actual, string examen_fisico, string laboratorio,
            string ECG, string rayos_x, string ecocardiograma, string otras_paraclinicas, string diagnosticos,
            string plan_estudio, string plan_terapeutico, int estado)
        {
            DHistorias Obj = new DHistorias();
            Obj.Paciente_id = paciente_id;
            Obj.Fecha_consulta = fecha_consulta;
            Obj.Razon_consulta = razon_consulta;
            Obj.Enfermedad_actual = enfermedad_actual;
            Obj.Insomnia = insomnia;
            Obj.Estrenimiento = estrenimiento;
            Obj.Historia_familiar = historia_familiar;
            Obj.Historia_personal = historia_personal;
            Obj.Tratamiento_actual = tratamiento_actual;
            Obj.Examen_fisico = examen_fisico;
            Obj.Laboratorio = laboratorio;
            Obj.ECG = ECG;
            Obj.Rayos_x = rayos_x;
            Obj.Ecocardiograma = ecocardiograma;
            Obj.Otras_paraclinicas = otras_paraclinicas;
            Obj.Diagnosticos = diagnosticos;
            Obj.Plan_estudio = plan_estudio;
            Obj.Plan_terapeutico = plan_terapeutico;
            Obj.Estado = estado;

            return Obj.Insertar(Obj);
        }


        //Metodo Editar que llama al metodo Editar de la clase DHistorias de la capa Datos

        public static string Editar(int paciente_id, DateTime fecha_consulta, string razon_consulta,
            string enfermedad_actual, int insomnia, int estrenimiento, string historia_familiar,
            string historia_personal, string tratamiento_actual, string examen_fisico, string laboratorio,
            string ECG, string rayos_x, string ecocardiograma, string otras_paraclinicas, string diagnosticos,
            string plan_estudio, string plan_terapeutico, int estado)
        {
            DHistorias Obj = new DHistorias();
            Obj.Paciente_id = paciente_id;
            Obj.Fecha_consulta = fecha_consulta;
            Obj.Razon_consulta = razon_consulta;
            Obj.Enfermedad_actual = enfermedad_actual;
            Obj.Insomnia = insomnia;
            Obj.Estrenimiento = estrenimiento;
            Obj.Historia_familiar = historia_familiar;
            Obj.Historia_personal = historia_personal;
            Obj.Tratamiento_actual = tratamiento_actual;
            Obj.Examen_fisico = examen_fisico;
            Obj.Laboratorio = laboratorio;
            Obj.ECG = ECG;
            Obj.Rayos_x = rayos_x;
            Obj.Ecocardiograma = ecocardiograma;
            Obj.Otras_paraclinicas = otras_paraclinicas;
            Obj.Diagnosticos = diagnosticos;
            Obj.Plan_estudio = plan_estudio;
            Obj.Plan_terapeutico = plan_terapeutico;
            Obj.Estado = estado;

            return Obj.Editar(Obj);
        }



        public static DataTable BuscarIdPaciente(int idbuscar)
        {
            DHistorias Obj = new DHistorias();
            Obj.Idbuscar = idbuscar;
            return Obj.BuscarIdPaciente(Obj);
        }



    }

}

