using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Games
    {
        //Konstruktor
        public Games(string Name, string Genre, string Publisher, double Price)
        {
            this.Name = Name;
            this.Genre = Genre;
            this.Publisher = Publisher;
            this.Price = Price;
            this.PriceWithUst = 0.0;
            this.Ust = 0.0;
        }
        //public Properties
        public string Genre;
        public string Name;
        public string Publisher;

        //private Field
        private double m_Price;
        private double m_Ust;
        private double m_PriceWithUst;

        public double Price { get => m_Price; set => m_Price = value; }
        public double Ust { get => m_Ust; set => m_Ust = value; }
        public double PriceWithUst { get => m_PriceWithUst; set => m_PriceWithUst = value; }

        //Methoden
        public void calculatePrice()
        {
            PriceWithUst = Price + (Ust = Price * 0.20);
        }

        static void Main(string[] args)
        {
            //Erzeugt eine Liste für Spiele
            List<Games> Spiele = new List<Games>();
            //Spiele werden in diese Liste gespeichert
            Spiele.Add(new Games("Age of Empires", "Strategy", "Microsoft Games", 23.10));
            Spiele.Add(new Games("Need for Speed", "Racing", "Electronic Arts", 10.00));
            Spiele.Add(new Games("Rainbow Six: Siege", "First Person Shooter", "Ubisoft", 30.20));

            //Schleife zur Ausgabe aller zuvor gespeicherten Spiele und veränderung der Preise
            foreach (var spiel in Spiele)
            {
                Console.WriteLine("Name:" + spiel.Name + "\t" + "Genre: " + spiel.Genre + "\t" + "Publisher: " + spiel.Publisher + "\t" + "Preis: " + spiel.Price);
                // Ausgabe bevor Preise veraendert wurden
                Console.WriteLine("Preis vor Berchnung: " + spiel.PriceWithUst + " davon 20% Ust: " + spiel.Ust);
                // Preise veraendern
                spiel.calculatePrice();
                // Ausgabe nach Preiseveraenderung
                Console.WriteLine("Neuer Preis nach Berechnung: " + spiel.PriceWithUst + " davon 20% Ust: " + spiel.Ust);
            }




        }

    }
}
