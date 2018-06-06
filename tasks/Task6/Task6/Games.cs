using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;


namespace Task6
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

        

    }
}
