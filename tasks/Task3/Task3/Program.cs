using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface IGames
    {
        string getName();
        string getGenre();
        string getPublisher();
        string getPlattform();
        decimal getPrice();
        decimal getUst();
        void CalculatePrice();
    }

    public class PS4 : IGames
    {

        //private Fields
        private string m_Genre;
        private string m_Name;
        private string m_publisher;
        private string m_plattform;
        private decimal m_Price;
        private decimal m_Ust;
        
        //public Properties
        public decimal Price { get => m_Price; set => m_Price = value; }
        public decimal Ust { get => m_Ust; set => m_Ust = value; }
        public string Genre { get => m_Genre; set => m_Genre = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public string Publisher { get => m_publisher; set => m_publisher = value; }
        public string Plattform { get => m_plattform; set => m_plattform = value; }
        
        //Konstruktor
        public PS4(string Name, string Genre, string Publisher, string Plattform, decimal Price)
        {
            this.Name = Name;
            this.Genre = Genre;
            this.Publisher = Publisher;
            this.Plattform = Plattform;
            this.Price = Price;
        }
        //Methoden
        public void CalculatePrice()
        {
            Price = Price + (Ust = Price * (decimal)0.10);
        }

        public string getName() { return this.Name; }
        public string getGenre() { return this.Genre; }
        public string getPublisher() { return this.Publisher; }
        public string getPlattform() { return this.Plattform; }
        public decimal getPrice() { return this.Price; }
        public decimal getUst() { return this.Ust; }
    }

    public class XBox : IGames
    {

        //private Fields
        private string m_Genre;
        private string m_Name;
        private string m_publisher;
        private string m_plattform;
        private decimal m_Price;
        private decimal m_Ust;
        
        //public Properties
        public decimal Price { get => m_Price; set => m_Price = value; }
        public decimal Ust { get => m_Ust; set => m_Ust = value; }
        public string Genre { get => m_Genre; set => m_Genre = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public string Publisher { get => m_publisher; set => m_publisher = value; }
        public string Plattform { get => m_plattform; set => m_plattform = value; }

        //Konstruktor
        public XBox(string Name, string Genre, string Publisher, string Plattform, decimal Price)
        {
            this.Name = Name;
            this.Genre = Genre;
            this.Publisher = Publisher;
            this.Plattform = Plattform;
            this.Price = Price;
        }
        //Methoden
        public void CalculatePrice()
        {
            Price = Price + (Ust = Price * (decimal)0.15);
        }
        public string getName() { return this.Name; }
        public string getGenre() { return this.Genre; }
        public string getPublisher() { return this.Publisher; }
        public string getPlattform() { return this.Plattform; }
        public decimal getPrice() { return this.Price; }
        public decimal getUst() { return this.Ust; }
    }

    public class PC:IGames
    {
        //Konstruktor
        public PC(string Name, string Genre, string Publisher, string Plattform, decimal Price)
        {
            this.Name = Name;
            this.Genre = Genre;
            this.Publisher = Publisher;
            this.Plattform = Plattform;
            this.Price = Price;
        }

        //private Fields
        private string m_Genre;
        private string m_Name;
        private string m_publisher;
        private string m_plattform;
        private decimal m_Price;
        private decimal m_Ust;
        
        //public Properties
        public decimal Price { get => m_Price; set => m_Price = value; }
        public decimal Ust { get => m_Ust; set => m_Ust = value; }
        public string Genre { get => m_Genre; set => m_Genre = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public string Publisher { get => m_publisher; set => m_publisher = value; }
        public string Plattform { get => m_plattform; set => m_plattform = value; }

        //Methoden
        public void CalculatePrice()
        {
            Price = Price + (Ust = Price * (decimal)0.20);
        }
        public string getName() { return this.Name; }
        public string getGenre() { return this.Genre; }
        public string getPublisher() { return this.Publisher; }
        public string getPlattform() { return this.Plattform; }
        public decimal getPrice() { return this.Price; }
        public decimal getUst() { return this.Ust; }

        static void Main(string[] args)
        {
            //Erzeugt eine Liste für Spiele
            List<IGames> Spiele = new List<IGames>();
            //Spiele werden in diese Liste gespeichert
            Spiele.Add(new PC("Age of Empires", "Strategy", "Microsoft Games", "PC", 30));
            Spiele.Add(new PS4("Need for Speed", "Racing", "Electronic Arts", "PS4", 30));
            Spiele.Add(new XBox("Rainbow Six: Siege", "First Person Shooter", "XBox", "Ubisoft", 30));

            //Schleife zur Ausgabe aller zuvor gespeicherten Spiele und veränderung der Preise
            foreach (var spiel in Spiele)
            {
                Console.WriteLine("Plattform: " + spiel.getPlattform());
                Console.WriteLine("Name:" + spiel.getName() + "\t" + "Genre: " + spiel.getGenre() + "\t" + "Publisher: " + spiel.getPublisher() + "\t" + "Preis: " + spiel.getPrice());
                // Ausgabe bevor Preise veraendert wurden
                Console.WriteLine("Preis vor Berchnung: " + spiel.getPrice());
                // Preise veraendern
                spiel.CalculatePrice();
                // Ausgabe nach Preiseveraenderung
                Console.WriteLine("Neuer Preis nach Berechnung: " + spiel.getPrice() + "\n\n");
            }




        }

    }
}
