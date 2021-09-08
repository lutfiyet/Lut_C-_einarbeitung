using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lut0709
{
    
    class Program
    {
        static void Main(string[] args)
        {
            LutPerson person = new LutPerson("lut", "tpc", 36);
            person.SageEtwas("Lass Uns zu hause!");
            Auto auto = new Auto();
            Porsche porsche = new Porsche();
            Console.WriteLine(porsche.printMe());
            auto.Anzahltüren = -2;
            auto.Hersteller = "Supercars";
            Console.WriteLine(auto.Hersteller);
            Console.WriteLine(auto.Anzahltüren);

        }
    }


    class LutPerson
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }

        public LutPerson(string vorname, string nachname, int alter)
        {
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
        }
        public void SageEtwas(string satz)
        {
            Console.WriteLine(Vorname + " " + Nachname + " " + satz);
        }
    }
    class Auto
    {
        public string farbe;
        public string Hersteller { get; set; }
        private int anzahlTüren;
        public int Anzahltüren
        {
            get
            {
                Console.WriteLine("Der Getter wurde aufgerufen");
                return anzahlTüren;
            }
            set
            {
                Console.WriteLine("Der Setter wurde aufgerufen");
                if (value < 1)
                {
                    anzahlTüren = 1;
                }
                else
                {
                    anzahlTüren = value;
                }

            }
        }
    }


    class Porsche : Auto
    {
        public String printMe()
        {
            String ret = "";
            ret += "mein Farbe ist " + farbe;
            return ret;

        }

    }
}
