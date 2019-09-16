using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsmaskinen
{
    class FileLoader
    {
        public List<Bok> Bibliotek;

        public bool ConvertTillgängligt(string status)
        {
            try
            {
                return  bool.Parse(status);

            }
            catch
            {
                return false;

            }

        }

        public Bok getRandomBok()
        {
            Random rand = new Random();

            return Bibliotek[rand.Next(Bibliotek.Count)];
        }

        public FileLoader()
        {
            Bibliotek = new List<Bok>();

            List<string> itemSaver = new List<string>();

            if (File.Exists("texter.txt"))
            {
                StreamReader reader = new StreamReader("texter.txt", Encoding.Default, false);
                string item = "";
                while ((item = reader.ReadLine()) != null)
                {
                    itemSaver.Add(item);
                }

                foreach (string a in itemSaver)
                {
                    string[] vektor = a.Split(new string[] { "###" }, StringSplitOptions.None);
                    switch (vektor[2])
                    {
                        case "Novellsamling":

                            Bibliotek.Add(new Novellsamling(vektor[0], vektor[1],ConvertTillgängligt(vektor[3])));
                            break;
                        case "Roman":
                            Bibliotek.Add(new Roman(vektor[0], vektor[1],ConvertTillgängligt(vektor[3])));
                            break;
                        case "Tidskrift":
                            Bibliotek.Add(new Tidskrift(vektor[0], vektor[1], ConvertTillgängligt(vektor[3])));
                            break;
                        default:
                            break;
                    }
                    
                }
            }
            

        }
      
    }
}
