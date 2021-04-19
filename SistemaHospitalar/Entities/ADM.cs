namespace SistemaHospitalar.Entities
{
    public class ADM
    {
        public ADM() { }

        public ADM(string p_usuario, string p_senha)
        {
            Usuario = p_usuario;
            Senha = p_senha;
        }

        public ADM(string p_usuario, string p_senha, float p_valorDiarioInternacao)
        {
            Usuario = p_usuario;
            Senha = p_senha;
            ValorDiarioInternacao = p_valorDiarioInternacao;
        }

        public string Usuario { get; set; }
        public string Senha { get; set; }
        public float ValorDiarioInternacao { get; set; }
    }
}
