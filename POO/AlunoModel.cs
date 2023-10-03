using System;
namespace POO
{
	public class AlunoModel
	{
        private List<Aluno> Alunos = new List<Aluno>();
		
        public void inserirAluno()
        {
            Aluno aluno = new Aluno();
            Alunos.Add(aluno);
        }

        public void alterarAluno()
        {
            listagemAlunos();
            Console.WriteLine("Digite o ID do aluno");
            int id = Convert.ToInt32(Console.ReadLine());
            Alunos[id].Popular();
        }


        public void listagemAlunos()
        {
            for (int id = 0; id < Alunos.Count(); id++)
            {
                Console.Write($"{id} ");
                Alunos[id].Listar();
            }
        }
        public void listarAlunos()
        {
            listagemAlunos();
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }
    }
}

