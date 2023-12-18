using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula01
{
    internal class App
    {
        static void Main(string[] args)
        {

            ServiceAluno service = new ServiceAluno();
            Aluno aluno = new Aluno();

            service.cadastroAluno(aluno);
            service.inserirNotasAluno(aluno);
            service.mediaAluno(aluno);
            

            Console.WriteLine("-----------------Dados do aluno-----------------");
            service.imprimeAluno(aluno);
            service.verificaResultadoAluno(aluno);

        }
    }
}
