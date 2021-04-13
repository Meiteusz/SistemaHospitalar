using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using System;
using System.Data;

namespace SistemaHospitalar.BLL
{
    class ConsultaBLL
    {
        DalConsultas dalConsultas = new DalConsultas();

        public bool isDataValida(Consulta consulta)
        {
            return dalConsultas.isDataConsultaValido(consulta.DataConsulta, consulta.Paciente, consulta.Doutor);
        }
        public string AgendarConsulta(Consulta consulta)
        {
            return dalConsultas.Insert(consulta);
        }

        public string DeletarConsulta(int IdConsulta)
        {
            return dalConsultas.Delete(IdConsulta);
        }


        public string ReagendarConsulta(DateTime dataConsulta, int IdConsulta)
        {
            return dalConsultas.UpdateDataConsulta(dataConsulta, IdConsulta);
        }



        public void CalcularValorFinalConsulta()
        {

        }

        public void CalcularValorDesconto()
        {

        }

        public DataTable AgendaDoutor(int IdDoutor)
        {
            return dalConsultas.GetConsultasDoDoutor(IdDoutor);
        }
    }
}
