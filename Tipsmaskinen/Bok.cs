using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipsmaskinen
{
    // Klass Bok har fyra egenskaper
    public class Bok
    {
        public string Titel { get; set; }

        public string Skribent { get; set; }

        public string Typ { get; set; }

        public bool Tillgängligt { get; set; }

        // Klass konstruktör 
        public Bok()
        {

        }

        // Klass konstruktör 
        public Bok(string titel,string skribent,bool tillgängligt)
        {
            this.Titel = titel;
            this.Skribent = skribent;
            this.Typ = "";
            this.Tillgängligt = tillgängligt;
        }

    }

    // ärva klass från Bok 
    class Tidskrift : Bok
    {
        // Klass konstruktör 
        public Tidskrift(string titel, string skribent,bool tillgängligt) : base(titel, skribent, tillgängligt)
        {
            this.Typ = "Tidskrift";
        }

        // använda den här funktionen när vi vill dkriva ut 
        public override string ToString()
        {
            return "\" " + Titel + " \" av " + Skribent + ". ( Tidskrift ) "+Tillgängligt;
        }

    }
    class Roman : Bok
    {
        // Klass konstruktör 
        public Roman(string titel, string skribent,bool tillgängligt) : base(titel, skribent, tillgängligt)
        {
            this.Typ = "Roman"; 
        }

        // använda den här funktionen när vi vill dkriva ut
        public override string ToString()
        {
            return "\" " + Titel + " \" av " + Skribent + ". ( Roman ) "+Tillgängligt;
        }

    }


    class Novellsamling : Bok
    {
        
        public Novellsamling(string titel, string skribent,bool tillgängligt) : base(titel, skribent,tillgängligt)
        {
            this.Typ = "Novellsamling";
        }

        public override string ToString()
        {
            return "\" " + Titel + " \" av " + Skribent + ". ( Novellsamling ) "+Tillgängligt;
        }
    }
}
