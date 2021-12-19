using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Services
{
    public static class DefinicaoPrioridade
    {
        public static int ObtemPrioridade(int t1, int t2, int t3) {
            int soma = t1 + t2 + t3;
            if (soma < 4)
            {
                return 1;//Baixa
            }
            else {
                if (Enumerable.Range(4, 6).Contains(soma)){
                    return 2;//Média
                }
                else
                {
                    return 3;//alta
                }
            }
        }
    }
}
