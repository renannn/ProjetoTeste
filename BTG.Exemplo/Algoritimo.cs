using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BTG.Exemplo
{
    public static class Algoritimo
    {
        public static int Executa(int LinhaCorte, List<int[]> Entrada)
        {
            int qnt = 0;

            foreach (var item in Entrada)
            {
                var somaLinha = 0;

                foreach (var itemArray in item)
                {
                    if (somaLinha < LinhaCorte && (somaLinha + itemArray) > LinhaCorte)
                    {
                        qnt++;
                    }
                    somaLinha += itemArray;
                }
            }

            return qnt;
        }
    }
}
