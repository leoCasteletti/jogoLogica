using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTLPII_2B_107081
{
    public class Resultado
    {
        public int ID { get; set; }
        public DateTime DataHora { get; set; }
        public string NomeInformado { get; set; }
        public int NumeroGerado { get; set; }
        public int NumeroCorreto { get; set; }
        public string Result
        {
            get
            {
                if (NumeroGerado == NumeroCorreto)
                    return "Correto";

                else return "Errou";
            }

        }
    }
}

