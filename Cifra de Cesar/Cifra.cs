using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Cifra_de_Cesar
{
    public class Cifra
    {
        private static String abc = "abcdefghijklmnopqrstuvwxyz";
        private static String ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static String Cifrar(String text, int c)
        {
            try
            {
                String new_text = "";
                bool flag = true;
                for (int i = 0; i < text.Length; i++)
                {
                    flag = true;
                    if (text[i] == text.ToLower()[i])
                    {
                        for (int j = 0; j < abc.Length; j++)
                        {
                            if (text[i].Equals(abc[j]))
                            {
                                flag = false;
                                if (j + c >= abc.Length)
                                {
                                    new_text = new_text + abc[j - abc.Length + c];
                                }
                                else
                                {
                                    new_text = new_text + abc[j + c];
                                }
                            }
                        }
                        if (flag)
                        {
                            new_text = new_text + text[i];
                        }
                    }
                    else
                    {
                        for (int j = 0; j < ABC.Length; j++)
                        {
                            if (text[i].Equals(ABC[j]))
                            {
                                flag = false;
                                if (j + c >= ABC.Length)
                                {
                                    new_text = new_text + ABC[j - ABC.Length + c];
                                }
                                else
                                {
                                    new_text = new_text + ABC[j + c];
                                }
                            }
                        }
                    }
                }
                return new_text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }

        public static String Decifrar(String text, int c)
        {
            try
            {
                String new_text = "";
                bool flag = true;
                for (int i = 0; i < text.Length; i++)
                {
                    flag = true;
                    if (text[i] == text.ToLower()[i])
                    {
                        for (int j = 0; j < abc.Length; j++)
                        {
                            if (text[i].Equals(abc[j]))
                            {
                                flag = false;
                                if (j - c < 0)
                                {
                                    new_text = new_text + abc[j + abc.Length - c];
                                }
                                else
                                {
                                    new_text = new_text + abc[j - c];
                                }
                            }
                        }
                        if (flag)
                        {
                            new_text = new_text + text[i];
                        }
                    }
                    else
                    {
                        for (int j = 0; j < ABC.Length; j++)
                        {
                            if (text[i].Equals(ABC[j]))
                            {
                                flag = false;
                                if (j - c < 0)
                                {
                                    new_text = new_text + ABC[j + ABC.Length - c];
                                }
                                else
                                {
                                    new_text = new_text + ABC[j - c];
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(new_text);
                return new_text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }

        public static int EncontrarChave(string chave)
        {
            chave = chave.ToLower();
            if (chave != string.Empty)
            {
                for (int i = 0; i < abc.Length; i++)
                {
                    if (chave[0] == abc[i])
                    {
                        return i;
                    }
                }
            }
            return -1;

        }
        public static string RemoveDiacritics(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > 255)
                    sb.Append(text[i]);
                else
                    sb.Append(s_Diacritics[text[i]]);
            }

            return sb.ToString();
        }

        private static readonly char[] s_Diacritics = GetDiacritics();
        private static char[] GetDiacritics()
        {
            char[] accents = new char[256];

            for (int i = 0; i < 256; i++)
                accents[i] = (char)i;

            accents[(byte)'á'] = accents[(byte)'à'] = accents[(byte)'ã'] = accents[(byte)'â'] = accents[(byte)'ä'] = 'a';
            accents[(byte)'Á'] = accents[(byte)'À'] = accents[(byte)'Ã'] = accents[(byte)'Â'] = accents[(byte)'Ä'] = 'A';

            accents[(byte)'é'] = accents[(byte)'è'] = accents[(byte)'ê'] = accents[(byte)'ë'] = 'e';
            accents[(byte)'É'] = accents[(byte)'È'] = accents[(byte)'Ê'] = accents[(byte)'Ë'] = 'E';

            accents[(byte)'í'] = accents[(byte)'ì'] = accents[(byte)'î'] = accents[(byte)'ï'] = 'i';
            accents[(byte)'Í'] = accents[(byte)'Ì'] = accents[(byte)'Î'] = accents[(byte)'Ï'] = 'I';

            accents[(byte)'ó'] = accents[(byte)'ò'] = accents[(byte)'ô'] = accents[(byte)'õ'] = accents[(byte)'ö'] = 'o';
            accents[(byte)'Ó'] = accents[(byte)'Ò'] = accents[(byte)'Ô'] = accents[(byte)'Õ'] = accents[(byte)'Ö'] = 'O';

            accents[(byte)'ú'] = accents[(byte)'ù'] = accents[(byte)'û'] = accents[(byte)'ü'] = 'u';
            accents[(byte)'Ú'] = accents[(byte)'Ù'] = accents[(byte)'Û'] = accents[(byte)'Ü'] = 'U';

            accents[(byte)'ç'] = 'c';
            accents[(byte)'Ç'] = 'C';

            accents[(byte)'ñ'] = 'n';
            accents[(byte)'Ñ'] = 'N';

            accents[(byte)'ÿ'] = accents[(byte)'ý'] = 'y';
            accents[(byte)'Ý'] = 'Y';

            return accents;
        }

    }
}
