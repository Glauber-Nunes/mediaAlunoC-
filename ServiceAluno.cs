using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    internal class ServiceAluno
    {

        public void cadastroAluno(Aluno aluno)
        {

            Console.WriteLine("Nome do aluno");
            String nomeAluno = Console.ReadLine();
            Console.WriteLine("Matricula do aluno");
            String matriculaAluno = Console.ReadLine();

            // setando dados do aluno
            aluno.setNome(nomeAluno);
            aluno.setMatricula(matriculaAluno);


        }

        public void inserirNotasAluno(Aluno aluno)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite a nota " + (i + 1) + "° ");
                String notaString = Console.ReadLine();

                double nota = Double.Parse(notaString);

                aluno.inserirNotas(nota); // inserindo dentro da lista
               
            }
        }

        public double mediaAluno(Aluno aluno)
        {
            aluno.setMedia(0);
            double soma = 0;
            double mediaAluno = 0;

            for (int i = 0; i < aluno.getNotas().Capacity; i++)
            {

                 mediaAluno = soma += aluno.getNotas()[i];

            }

            mediaAluno = mediaAluno / 4;

            aluno.setMedia(mediaAluno);

            return mediaAluno;
        }

        public void verificaResultadoAluno(Aluno aluno)
        {
            if (aluno.getMedia() >= 7)
            {
                Console.WriteLine("Aluno Aprovado, Media: " + aluno.getMedia());
            }
            else if(aluno.getMedia() >=6 && aluno.getMedia() <7)
            {
                Console.WriteLine("Aluno Em Recuperação, Media: " + aluno.getMedia());
            }
            else
            {
                Console.WriteLine("Aluno Reprovado, Media: " + aluno.getMedia());
            }
        }

        public void imprimeAluno(Aluno aluno)
        {
            Console.WriteLine("Nome : " + aluno.getNome());
            Console.WriteLine("Matricula : " + aluno.getMatricula());
        }

    }
}
