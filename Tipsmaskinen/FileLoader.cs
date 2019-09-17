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

        // konvertera sträng till boolean
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
        // en slumpmässig bok
        public Bok getRandomBok(string str)
        {
            Random rand = new Random();
            // få en slumpmässig bok baserad om bäcker räknas
            Bok bok = Bibliotek[rand.Next(Bibliotek.Count)];
            //kontrollera om nästa är samma som föregående
            if (str.Equals(bok.ToString()))
                return getRandomBok(bok.ToString());
            else
                return bok;

        }
        // Klass konstruktör  
        public FileLoader()
        {
            Bibliotek = new List<Bok>();

        }
        //läs från filen 
        public void LäsFrånFilen()
        {
            //Skapa lista där böcker ska sparas tillfälligt
            List<string> itemSaver = new List<string>();
            // kontrollera om filen finns
            if (File.Exists("texter.txt"))
            {
                // läs alla rader i filen och lägg den i listan
                StreamReader reader = new StreamReader("texter.txt", Encoding.Default, true);
                string item = "";
                while ((item = reader.ReadLine()) != null)
                {
                    itemSaver.Add(item);
                }
                //konvertera varje rad till bokklass
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
                //stäng filen
                reader.Close();
            }
            

        }

        //skriv till filen
        public void SkrivTillFilen(string text)
        {
            //skapa stream writer för att kunna skriva till filen
            StreamWriter writer =new StreamWriter("texter.txt",true);
            // lägg texten till filen
            writer.WriteLine(text);
            //stäng filen
            writer.Close();
        }
      
    }
}
