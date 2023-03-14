namespace aula;
class Program
{
    static void Main(string[] args)
    {
        ExercicioAluno.Alunos aluno1 = new ExercicioAluno.Alunos();
        aluno1.nome = "Fulçano da silva rolim";
        aluno1.nota1 = 4.3;
        aluno1.nota2 = 7.8;
        aluno1.mensagem();
    }
}
