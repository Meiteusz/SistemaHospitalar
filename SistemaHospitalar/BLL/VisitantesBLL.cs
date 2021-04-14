using SistemaHospitalar.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospitalar.BLL
{
    public class VisitantesBLL
    {
        DalVisitantes dalVisitantes = new DalVisitantes();

        public ArrayList MostrarCpfVisitantes()
        {
            return dalVisitantes.GetCpfVisitantes();
        }
    }
}
