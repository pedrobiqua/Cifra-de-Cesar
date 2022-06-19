using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifra_de_Cesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- TDE Matemática discreta -------------");

            Console.WriteLine("Frase a ser Convertida:");
            var texto = Console.ReadLine();
            texto = Cifra.RemoveDiacritics(texto);

            Console.WriteLine("Chave:");
            var chave = Console.ReadLine();

            int novaChave = Cifra.EncontrarChave(chave);

            if (novaChave == -1)
            {
                Console.WriteLine("Não foi possivel usar essa chave");
            }

            Console.WriteLine(Cifra.Cifrar(texto, novaChave));

            Console.WriteLine("Criptografia:");
            var textoDes = Console.ReadLine();

            Console.WriteLine("Chave:");
            var chaveDes = Console.ReadLine();

            int novaChavedes = Cifra.EncontrarChave(chaveDes);

            if (novaChave == -1)
            {
                Console.WriteLine("Não foi possivel usar essa chave");
            }
            Console.WriteLine(Cifra.Decifrar(textoDes, novaChavedes));

            Console.ReadLine();
        }
    }
}
