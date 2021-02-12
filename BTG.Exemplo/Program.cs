using System;
using System.Collections.Generic;
using System.Linq;

namespace BTG.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio da execução");

            var linhaCorte = 4;
            var input = new List<int[]>();

            input.Add(new[] { 1, 2, 2, 1 });
            input.Add(new[] { 3, 1, 2 });
            input.Add(new[] { 1, 3, 2 });
            input.Add(new[] { 2, 4 });
            input.Add(new[] { 3, 1, 2 });
            input.Add(new[] { 1, 3, 1, 1 });

            // Gerador de Vetores aleatorios 
            //for (int i = 0; i < new Random().Next(1, 100); i++)
            //{
            //    var max = new Random(i).Next(1,100);
            //    var itemInterno = new List<int>();
            //    for (int j = 0; j < max; j++)
            //    {
            //        itemInterno.Add(new Random(j + i).Next(1, 100));
            //    }
            //    input.Add(itemInterno.ToArray());
            //}

            var qnt = Algoritimo.Executa(linhaCorte, input);

            var maxItem = input.Select(c => c.Sum()).Max();

            Console.WriteLine("Quantidade de tijolos cortados : {0}", qnt);

            Console.WriteLine("Fim da execução.");
            Console.WriteLine("Precione <Enter> para fechar.");
            Console.ReadLine();
        }

    }
}
