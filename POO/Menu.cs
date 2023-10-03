using System;
namespace POO
{
	public class Menu
	{
        static AlunoModel alunoModel = new AlunoModel();


        public static string MenuPrincipal()
		{
			Console.WriteLine("1 - Alunos");
			return Console.ReadLine();
        }

		public static string MenuCrud()
		{
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Editar");
            Console.WriteLine("3 - Visualizar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("0 - Retornar");
            return Console.ReadLine();

        }

    public static void MostrarMenu()
    {
        Console.Clear();
        switch (Menu.MenuPrincipal())
        {
            case "1":
                MostrarMenuAluno();
                break;
           
            default:
                Console.WriteLine("Opçao invalida");
                break;
        }
    }

    

    public static void MostrarMenuAluno(string mensagem = "")
    {

        Console.Clear();
        Console.WriteLine(mensagem);
        switch (Menu.MenuCrud())
        {
            case "1":
                alunoModel.inserirAluno();
                MostrarMenuAluno("Aluno incluido com sucesso!");
                break;
            case "2":
                alunoModel.alterarAluno();
                MostrarMenuAluno("Aluno atualizado com sucesso!");
                break;
            case "3":
                alunoModel.listarAlunos();
                MostrarMenuAluno();
                break;
            case "4":
                break;
            case "0":
                MostrarMenu();
                break;
            default:
                Console.WriteLine("Opçao invalida");
                break;
        }
    }
    }
        
}

