using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Minificador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var origem = string.Empty;
            var destino = string.Empty;

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/o="))
                {
                    origem = args[i].Split('=')[1];
                }
                else if (args[i].StartsWith("/d="))
                {
                    destino = args[i].Split('=')[1];

                }

            }

            System.Console.Out.WriteLine("Minimalizando...");

            var dadosOrigem = File.ReadAllText(origem);
            var dadosDestino = dadosOrigem.Replace(Environment.NewLine, "");
            dadosDestino = string.Join(" ", dadosDestino.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));

            File.WriteAllText(destino, dadosDestino);

            System.Console.ReadKey();

        }

    }
}
/*
 Aplicação que diminui o tamanho de recursos como HTML, CSS e
Javascript, com o objetico de facilitar a sua transferencia na web.

Minificador-objetivo: 
Remover espaços consecutivos excedentes; 

*/