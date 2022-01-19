using System;

namespace Indexer
{
    class Program
    {
        static void DictionaryStart()
        {
            var dictionary = new Dictionary()
            {
                DictionaryArray = new string[30, 2]
              {
                    {"act", "hereket" },
                    {"activity", "fealiyyet" },
                    {"back", "geri" },
                    {"begin", "baslamaq" },
                    {"can", "bacarmaq" },
                    {"children", "usaqlar" },
                    {"describe", "tesvir etmek" },
                    {"different", "muxtelif" },
                    {"easy", "asan" },
                    {"equal", "beraber" },
                    {"finish", "bitirmek" },
                    {"forget", "inanmaq" },
                    {"grade", "derece" },
                    {"garden", "bag" },
                    {"happy", "xosbext" },
                    {"help", "komek etmek" },
                    {"interesting", "maraqli" },
                    {"increase", "artirmaq" },
                    {"know", "bilmek" },
                    {"keep", "saxlamaq" },
                    {"learn", "oyrenmek" },
                    {"listen", "qulaq asmaq" },
                    {"meet", "gorusmek" },
                    {"motion", "hereket" },
                    {"new", "yeni" },
                    {"need", "ehtiyac" },
                    {"offer", "teklif etmek" },
                    {"order", "sifaris etmek" },
                    {"page", "sehife" },
                    {"power", "guc" }
              }
            };

            string word;

            Console.WriteLine("[1] English - Azerbaijan\n[2] Azerbaijan - English");
            string n = Console.ReadLine();
            if (n == "1")
            {
                Console.WriteLine("Enter word: ");
                word = Console.ReadLine();
                for (int i = 0; i < dictionary.DictionaryArray.Length; i++)
                {
                    if (dictionary[i, 0] == word)
                        Console.WriteLine(dictionary[i, 1]);
                }
            }
            else if (n == "2")
            {
                Console.WriteLine("Enter word: ");
                word = Console.ReadLine();
                for (int i = 0; i < dictionary.DictionaryArray.Length; i++)
                {
                    if (dictionary[i, 1] == word)
                        Console.WriteLine(dictionary[i, 0]);
                }
            }
        }

        static void CityStart()
        {
            var baku = new Baku(2.15);
            var istanbul = new Istanbul(15.7);
            var moscow = new Moscow(12.7);

            if(baku > istanbul && baku > moscow)
                Console.WriteLine("The population of Baku is the greatest among other cities");
            else if (istanbul > baku && istanbul > moscow)
                Console.WriteLine("The population of Istanbul is the greatest among other cities");
            else if (moscow > baku && moscow > istanbul)
                Console.WriteLine("The population of Moscow is the greatest among other cities");
        }
        static void Main(string[] args)
        {

            //DictionaryStart();

            CityStart();
        }
    }
}
