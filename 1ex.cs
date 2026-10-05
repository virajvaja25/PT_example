using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_example
{
    class Product
    {
        // Data Members
        public int ID { get; set; }
        private string name;
        public string Desc { get; set; }
        protected int Price;

        public Product()
        {
        }

        public Product(int id, string name, string desc, int price)
        {
            this.ID = id;
            this.name = name;
            this.Desc = desc;
            this.Price = price;
        }

        public int getPrice()
        {
            return Price;
        }

        public void setPrice(int Price)
        {
            this.Price = Price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Marked virtual so child class can override
        public virtual void Display()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Description: " + Desc);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("====================================");
        }
    }

    class SecondProduct : Product
    {
        private double Basic;
        private double DA;
        private double HRA;
        private double PF;
        private double PT;

        public SecondProduct() : base()
        {
        }

        public SecondProduct(int id, string name, string desc, int price,
                             double basic, double da, double hra, double pf, double pt)
            : base(id, name, desc, price)
        {
            this.Basic = basic;
            this.DA = da;
            this.HRA = hra;
            this.PF = pf;
            this.PT = pt;
        }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Basic: " + Basic);
            Console.WriteLine("DA: " + DA);
            Console.WriteLine("HRA: " + HRA);
            Console.WriteLine("PF: " + PF);
            Console.WriteLine("PT: " + PT);
            Console.WriteLine("====================================");
        }
    }

    internal class Class2
    {
        public static void _1exMain(string[] args)
        {
            Product p1 = new Product(101, "Laptop", "Gaming Laptop", 75000);
            p1.Display();


            SecondProduct p2 = new SecondProduct(102, "Mobile", "Smartphone", 25000,
                                                 15000, 2000, 3000, 1500, 200);
            p2.Display();


            Product p3 = new SecondProduct(103, "Tablet", "Android Tablet", 15000,
                                      8000, 1000, 1500, 800, 100);
            p3.Display();

            Console.Read();
        }
    }
}