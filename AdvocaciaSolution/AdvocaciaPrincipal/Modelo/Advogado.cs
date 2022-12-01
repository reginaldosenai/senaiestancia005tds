using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocaciaPrincipal.Modelo
{
    public class Advogado
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        private int tamanho;

        public int gettamanho()
        {
            return this.tamanho;
        }
        public void setTamanho(int tamanho)
        {
            this.tamanho = tamanho;
        }

        public bool verificarSeAdovagdoEMaiorIdade()
        {
            if (this.Idade>=18)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }

        public List<Advogado> getAllAdvogados()
        {
            return null;
        }
        public bool eExperiente()
        {
            return false;
        }
      
    }
}
