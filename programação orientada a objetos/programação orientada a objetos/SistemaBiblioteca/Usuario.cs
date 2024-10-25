namespace SistemaBiblioteca
{
    public class Usuario : Entidade
    {
        public string Nome { get; set; } = "Novo Usuário";
        public string Telefone { get; set; } = "";
        public string Endereco { get; set; } = "";
        public string Email { get; set; } = "";
        public bool Banido { get; set; } = false;
    }
}