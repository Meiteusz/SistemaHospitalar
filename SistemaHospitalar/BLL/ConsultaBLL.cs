using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using System;
using System.Data;

namespace SistemaHospitalar.BLL
{
    class ConsultaBLL : Validator
    {
        public float ValorConsulta { get; private set; }
        public float ValorDesconto { get; private set; }
        public float ValorFinalConsulta { get; private set; }
        DalConsultas dalConsultas = new DalConsultas();
        DalExames dalExames = new DalExames();

        public bool isDataValida(Consulta consulta)
        {
            if (ValidarDataConsultaExame(consulta.DataConsulta) && dalConsultas.isDataConsultaValido(consulta.DataConsulta, consulta.Paciente, consulta.Doutor) &&
                dalExames.isDataExameValido(consulta.DataConsulta, consulta.Paciente, consulta.Doutor))
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public void SetValoresConsulta(float p_ValorConsulta, float p_ValorDescontoConvenio)
        {
            ValorConsulta = p_ValorConsulta;
            ValorDesconto = p_ValorConsulta * p_ValorDescontoConvenio;
            ValorFinalConsulta = p_ValorConsulta - ValorDesconto;
        }

        public DataTable AgendaDoutor(int IdDoutor)
        {
            return dalConsultas.GetConsultasDoDoutor(IdDoutor);
        }

        public DataTable ConsultasHoje()
        {
            return dalConsultas.MostrarConsultasHoje();
        }

        public DataTable ConsultasGeral()
        {
            return dalConsultas.MostrarConsultas();
        }

        public DataTable ConsultasDoutor(int IdDoutor)
        {
            return dalConsultas.MostrarConsultasParaDoutor(IdDoutor);
        }
    }
}
