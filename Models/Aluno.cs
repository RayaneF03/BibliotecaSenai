namespace BibliotecaSenai.Models
{
    public class Alunos
    {
        public int AlunosId { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Email { get; set; }
        public int LivrosEmprestados { get; set; }

        // Uma regra de negócio simples: verificar se o aluno pode retirar mais livros
        public bool PodePegarEmprestimo()
        {
            return LivrosEmprestados < 3; // Exemplo: limite de 3 livros
        }
    }
}