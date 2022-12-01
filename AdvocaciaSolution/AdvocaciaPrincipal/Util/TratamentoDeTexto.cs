using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocaciaPrincipal.Util
{
    public class TratamentoDeTexto
    {
        public int qtdDeTexto(string texto)
        {
            int x = texto.Count();
            
            return x;
        }

        public string TextoAlterado(string encontrar, string novo, string texto)
        {
              return texto.Replace(encontrar,novo);
        }
    }
}
