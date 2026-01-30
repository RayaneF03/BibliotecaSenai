namespace BibliotecaSenai.Models
{
    public class Biblioteca
    {
        public int BibliotecaId { get; set; }
        public required string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int Quantidade { get; set; }

    }
}
