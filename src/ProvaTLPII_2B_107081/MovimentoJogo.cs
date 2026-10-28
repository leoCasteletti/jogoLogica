using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTLPII_2B_107081
{
    public class MovimentoJogo
    {
        public int CalcularNumeroCorreto(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return 0;
            }
            return nome.Length * nome.Length;
        }

        public bool VerificarAcerto(string nome, int numeroInformado)
        {
            return CalcularNumeroCorreto(nome) == numeroInformado;
        }
    }

}
