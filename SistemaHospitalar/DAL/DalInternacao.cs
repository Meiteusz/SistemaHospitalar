﻿using SistemaHospitalar.Entities;
using System.Data.SqlClient;

namespace SistemaHospitalar.DAL
{
    public class DalInternacao : DalComandos
    {
        public string Insert(Internacao p_internacao)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@PACIENTEID", p_internacao.PacienteId);
            command.Parameters.AddWithValue("@DOUTORID", p_internacao.DoutorId);
            command.Parameters.AddWithValue("@DESCRICAO", p_internacao.Descricao);
            command.Parameters.AddWithValue("@TIPOINTERNACAO", p_internacao.TipoInternacao);
            command.Parameters.AddWithValue("@QUARTOID", p_internacao.QuartoId);
            command.Parameters.AddWithValue("@DATAENTRADA", p_internacao.DataEntrada);
            command.Parameters.AddWithValue("@DATASAIDA", null);
            command.Parameters.AddWithValue("@PRECO", p_internacao.Preco);
            command.Parameters.AddWithValue("@DATAULTIMAATUALIZACAO", p_internacao.DataUltimaAtualizacao);

            command.CommandText = "insert into INTERNACAO values(@PACIENTEID, @DOUTORID, @DESCRICAO, @TIPOINTERNACAO, @QUARTOID, @DATAENTRADA, @DATASAIDA, @PRECO, @DATAULTIMAATUALIZACAO)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return "Paciente foi internado com sucesso";
            }
            catch (SqlException ex)
            {
                return MostrarTipoErro(ex);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        
    }
}
