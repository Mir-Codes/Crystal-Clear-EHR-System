using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;

namespace Metodos
{
    public class MCitaMedica
    {
        private DAOCitaMedica daoCitaMedica;

        public MCitaMedica()
        {
            daoCitaMedica = new DAOCitaMedica();
        }

        public void Insert(DAOCitaMedica.CitaMedica citaMedica)
        {
            DataTable pacientesExistentes = MPacientes.BuscarCedula(citaMedica.Paciente.Cedula);
            if (pacientesExistentes.Rows.Count != 0)
            {
                citaMedica.Paciente.Id = pacientesExistentes.Rows[0]["id"].ToString();
            }

            daoCitaMedica.Insert(citaMedica);
        }


        
    }
}
