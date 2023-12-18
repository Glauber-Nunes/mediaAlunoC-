using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
     class Aluno
    {


        private String nome;
        private String matricula;
        private double media;

        //lista para inserir as 4 notas
        private List<double> notas = new List<double>();
        
        public String getNome() {
         return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;   
        }

        public List<double> getNotas()
        {
            return notas;
        }

        public String getMatricula()
        {
            return matricula;   
        }

        public void setMatricula(String matricula)
        {
            this.matricula = matricula;
        }

        public double getMedia()
        {
            return media;
        }

        public void setMedia(double media)
        {
            this.media = media;
        }

        public void inserirNotas(double nota)
        {
            notas.Add(nota);
        }

       
    }
}
