﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace Task4
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
            if (Name == "" || Name == null) throw new ArgumentException("Name must contain value.", nameof(Name));
            this.Name = Name;
            if (Genre == "" || Genre == null) throw new ArgumentException("Genre must contain value.", nameof(Genre));
            this.Genre = Genre;
            if (Publisher == "" || Publisher == null) throw new ArgumentException("Publisher must contain value.", nameof(Publisher));
            this.Publisher = Publisher;
            if (Plattform == "" || Plattform == null) throw new ArgumentException("Plattform must contain value.", nameof(Plattform));
            this.Plattform = Plattform;
            if (Price < 0) throw new ArgumentException("Price must not be negative.", nameof(Price));
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
            if (Name == "" || Name == null) throw new ArgumentException("Name must contain value.", nameof(Name));
            this.Name = Name;
            if (Genre == "" || Genre == null) throw new ArgumentException("Genre must contain value.", nameof(Genre));
            this.Genre = Genre;
            if (Publisher == "" || Publisher == null) throw new ArgumentException("Publisher must contain value.", nameof(Publisher));
            this.Publisher = Publisher;
            if (Plattform == "" || Plattform == null) throw new ArgumentException("Plattform must contain value.", nameof(Plattform));
            this.Plattform = Plattform;
            if (Price < 0) throw new ArgumentException("Price must not be negative.", nameof(Price));
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

    public class PC : IGames
    {
        //Konstruktor
        public PC(string Name, string Genre, string Publisher, string Plattform, decimal Price)
        {
            if (Name == "" || Name == null) throw new ArgumentException("Name must contain value.", nameof(Name));
            this.Name = Name;
            if (Genre == "" || Genre == null) throw new ArgumentException("Genre must contain value.", nameof(Genre));
            this.Genre = Genre;
            if (Publisher == "" || Publisher == null) throw new ArgumentException("Publisher must contain value.", nameof(Publisher));
            this.Publisher = Publisher;
            if (Plattform == "" || Plattform == null) throw new ArgumentException("Plattform must contain value.", nameof(Plattform));
            this.Plattform = Plattform;
            if (Price < 0) throw new ArgumentException("Price must not be negative.", nameof(Price));
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
            Spiele.Add(new XBox("Rainbow Six: Siege", "First Person Shooter", "Ubisoft", "XBox", 30));
            //aktueller Pfad
            string path = Directory.GetCurrentDirectory();
            string FilePath = path + "\\Spiele.json";
            // serialize JSON to a string and then write string to a file
            // Daten mit Peris ohne Mwst werden in die File geschrieben
            // Sowie keine Ust (ebenfalls 0)
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(Spiele, Formatting.Indented));


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


            // Nun wird die JSON File wieder eingelesen und die Daten in das Plattform abhaengige Objekt geladen
            List<IGames> videogames = new List<IGames>();
            JArray a = JArray.Parse(File.ReadAllText(FilePath));
            for (int i = 0; i < a.Count(); i++)
            {
                JObject o = JObject.Parse(a[i].ToString());
                JsonSerializer ser = new JsonSerializer();
                var val = o.GetValue("Plattform");
                switch (val.ToString())
                {
                    case "PC":
                        videogames.Add((PC)ser.Deserialize(new JTokenReader(o), typeof(PC)));
                        break;
                    case "PS4":
                        videogames.Add((PS4)ser.Deserialize(new JTokenReader(o), typeof(PS4)));
                        break;
                    case "XBox":
                        videogames.Add((XBox)ser.Deserialize(new JTokenReader(o), typeof(XBox)));
                        break;
                    default:
                        break;
                }
            }

            //Beweis die Berechnung der Objekte muss nun denselben Preis haben wie Objekte vom Anfang
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Zur Kontrolle kann die JSON File geoeffnet werden diese enthaelt nur Daten ohne USt");
            Console.WriteLine("nachfolgend werden die neuen Preise wie oben berechnet");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var game in videogames)
            {
                Console.WriteLine("Game from Json: " + game.getName());
                // Preise veraendern
                game.CalculatePrice();
                // Ausgabe nach Preiseveraenderung
                Console.WriteLine("Game from Json nach Berechnung: " + game.getPrice() + "\n\n");
            }
        }

    }
}
