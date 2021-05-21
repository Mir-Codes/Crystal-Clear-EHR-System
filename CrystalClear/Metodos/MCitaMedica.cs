using System;
using System.Collections.Generic;
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

        public void Insert(DAOCitaMedica.CitaMedica citaMedica) {

            daoCitaMedica.Insert(citaMedica);
        }


        
    }
}
