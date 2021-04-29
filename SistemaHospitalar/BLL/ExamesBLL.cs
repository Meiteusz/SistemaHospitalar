using SistemaHospitalar.DAL;
using SistemaHospitalar.Entities;
using SistemaHospitalar.Models;
using SistemaHospitalar.Utilities;
using System;
using System.Data;

namespace SistemaHospitalar.BLL
{
    class ExamesBLL : Validator
    {
        public float ValorExame { get; private set; }
        public float ValorDesconto { get; private set; }
        public float ValorFinalExame { get; private set; }
        DalExames dalExames = new DalExames();
        DalConsultas dalConsultas = new DalConsultas();

        public bool isDataExameValido(Exame exame)
        {
            if (ValidarDataConsultaExame(exame.DataExame) && dalConsultas.isDataConsultaValido(exame.DataExame,
                FuncionarioLogado.ConsultaTemp.Paciente, FuncionarioLogado.ConsultaTemp.Doutor) && dalExames.isDataExameValido(exame.DataExame, 
                FuncionarioLogado.ConsultaTemp.Paciente, FuncionarioLogado.ConsultaTemp.Doutor) && exame.DataExame > FuncionarioLogado.ConsultaTemp.DataConsulta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string AgendarExame(Exame exame)
        {
            return dalExames.InsertExame(exame);
        }

        public string ReagendarExame(DateTime dataExame, int IdExame)
        {
            return dalExames.UpdateDataExame(dataExame, IdExame);
        }

        public void SetValoresExame(float p_ValorExame, float p_ValorDescontoConvenio)
        {
            ValorExame = p_ValorExame;
            ValorDesconto = p_ValorExame * p_ValorDescontoConvenio;
            ValorFinalExame = p_ValorExame - ValorDesconto;
        }

        public string CadastrarDiagnosticoExame(Diagnostico diagnostico)
        {
            return dalExames.InsertDiagnostico(diagnostico);
        }

        public string DeletarDiagnostico(int IdDiagnostico)
        {
            return dalExames.DeleteDiagnostico(IdDiagnostico);
        }

        public bool isDiagnosticoExistente(int IdExame)
        {
            return dalExames.isDiagnosticoExistente(IdExame);
        }

        public DataTable PesquisarExamesByData(string DataExame)
        {
            return dalExames.PesquisarExamesByData(DataExame);
        }

        public DataTable MostrarExames()
        {
            return dalExames.MostrarExames();
        }

        public DataTable MostrarExamesHoje()
        {
            return dalExames.MostrarExamesHoje();
        }

        public DataTable MostrarExamesDoutor(int IdDoutor)
        {
            return dalExames.TodosExamesDoDoutor(IdDoutor);
        }

        public DataTable MostrarExamesHojeDoutor(int IdDoutor)
        {
            return dalExames.TodosExamesDoDoutorHoje(IdDoutor);
        }

        public DataTable PesquisarExamesByNomePaciente(string NomePaciente)
        {
            return dalExames.PesquisarExamesByNomePaciente(NomePaciente);
        }

        public DataTable PesquisarExamesDoutorByNomePaciente(int IdDoutor, string NomePaciente)
        {
            return dalExames.PesquisarExamesDoutorByNomePaciente(IdDoutor, NomePaciente);
        }

        public DataTable MostrarDiagnosticosExame(int IdExame)
        {
            return dalExames.DiagnosticosExame(IdExame);
        }
    }
}
