using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifra_de_Cesar
{
    public class Cifra
    {

        public static String abc = "abcdefghijklmnopqrstuvwxyz";
        

        public static String Criptografar(String text, int chave)
        {
            String new_text = "";
            text = text.ToLower();
            foreach (var i in text)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (i.Equals(abc[j]))
                    {
                        if ((j + chave) > abc.Length)
                        {
                            new_text += abc[j - abc.Length + chave];
                        }
                        else
                        {
                            new_text += abc[j + chave];
                            new_text = new_text.ToLower();
                        }
                    }
                }
            }

            return new_text;
        }

        public static String DesCriptografar(String text, int chave)
        {
            String new_text = "";
            text = text.ToLower();
            foreach (var i in text)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (i.Equals(abc[j]))
                    {
                        if ((j - chave) < 0)
                        {
                            new_text += abc[(j + abc.Length) - chave];
                        }
                        else
                        {
                            new_text += abc[j - chave];
                            new_text = new_text.ToLower();
                        }
                    }
                }
            }

            return new_text;
        }

        public static int EncontrarChave(string chave)
        {
            for (int i = 0; i < abc.Length; i++)
            {
                if (abc[i] == chave[0])
                {
                    return i;
                }
            }

            return -1;
        }

    }
}
