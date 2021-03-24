namespace SistemaHospitalar.Entities
{
    class ADM
    {
        public ADM(string p_usuario, string p_senha)
        {
            Usuario = p_usuario;
            Senha = p_senha;
        }

        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
