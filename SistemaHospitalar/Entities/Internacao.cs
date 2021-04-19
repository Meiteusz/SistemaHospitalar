using System;

namespace SistemaHospitalar.Entities
{
    public class Internacao
    {
        public int Id { get; set; }
        public int PacienteId { get; set; }
        public int DoutorId { get; set; }
        public string Descricao { get; set; }
        public TipoInternacao TipoInternacao { get; set; }
        public int QuartoId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public float Preco { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }

        public Internacao() { }

        public Internacao(int p_Id, string p_descricao, TipoInternacao p_tipoInternacao, int p_quartoId, DateTime p_dataUltimaAtualizacao)
        {
            Id = p_Id;
            Descricao = p_descricao;
            TipoInternacao = p_tipoInternacao;
            QuartoId = p_quartoId;
            DataUltimaAtualizacao = p_dataUltimaAtualizacao;
        }

        public Internacao(int p_Id, DateTime P_dataSaida, float p_preco)
        {
            Id = p_Id;
            DataSaida = P_dataSaida;
            Preco = p_preco;
        }

        public Internacao(int p_pacienteId, int p_doutorId, string p_descricao, TipoInternacao p_tipoInternacao, int p_quartoId, DateTime p_dataEntrada, DateTime p_dataUltimaAtualizacao)
        {
            PacienteId = p_pacienteId;
            DoutorId = p_doutorId;
            Descricao = p_descricao;
            TipoInternacao = p_tipoInternacao;
            QuartoId = p_quartoId;
            DataEntrada = p_dataEntrada;
            DataUltimaAtualizacao = p_dataUltimaAtualizacao;
        }
    }
}
