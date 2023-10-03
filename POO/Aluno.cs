using System;
namespace POO
{
	public class Aluno
	{
		public string nome;
		public int idade;
		private double nota1;
		private double nota2;

		public Aluno()
		{
			Popular();
		}


		public void Popular()
		{
			Console.WriteLine("Digite o nome do aluno");
			nome = Console.ReadLine();

			Console.WriteLine("Digite a idade do aluno");
			idade = Convert.ToInt32(Console.ReadLine());

		}

		public void Listar()
		{
			Console.WriteLine($"{nome} tem {idade} anos");
		}
        private double media()
		{
			return (nota1 + nota2) / 2;
		}

        public void passouDeAno()
        {
            Console.WriteLine("Digite a nota 1");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota 2");
            nota2 = Convert.ToDouble(Console.ReadLine());

			if (media() >= 7)
			{
				Console.WriteLine($"{nome} passou de ano com média {media()}");
			} else
			{
                Console.WriteLine($"{nome} não passou de ano com média {media()}");

            }
        }
	}
}

