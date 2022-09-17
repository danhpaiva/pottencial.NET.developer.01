using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        for (int i = 0; i < qt; i++)
        {
            int[] v = new int[2];
            v[0] = int.Parse(Console.ReadLine());
            v[1] = int.Parse(Console.ReadLine());
            string a = v[0].ToString();
            string b = v[1].ToString();
            int tamanhoStringA = a.Length;
            int tamanhoStringB = b.Length;

            if (tamanhoStringB > tamanhoStringA)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");
        }
    }
}