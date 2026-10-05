using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_example
{
    class Emp
    {
        //Data Member
        public String Name { get; set; }
        private int age;
        public String Dept { get; set; }
        private double Salary;

        //    same as bottom property but this is method and we have to call this method to get and set the value of salary.

        public double getSalary()
        {
            return Salary;
        }
        public void setSalary(double Salary)
        {
            this.Salary = Salary;
        }

        //property -looks a variable but works like methode

        public int Age
        {
            //only get -read only Properttiy and only set Write only Propertiy
            get
            {
                return age;
            }
            set
            {
                if (value >= 18)
                    age = value;
                else
                    age = 0;

            }
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("Department: " + Dept);
            Console.WriteLine("Saralay: " + Salary);
        }
    }
    internal class D
    {

        class RegularEmployee : Emp
        {
            private double Basic;
            private double HRA;
            private double DA;
            private double PF;
            private double PT;

        }
        public static void _DMain(string[] args)
        {
            Emp e1 = new Emp();
            e1.Name = "Khush";
            e1.Age = 20;
            e1.Dept = "CE";
            e1.setSalary(100000);
            e1.Display();

            Emp e2 = new Emp();

            e2.Name = "Viraj";
            e2.Age = 20;
            e2.Dept = "It";
            e2.Display();

            Console.Read();

            Emp e4 = new Emp();// parent class object
            e4.Display();

            RegularEmployee e5 = new RegularEmployee();// child class object
            e5.Display();

            Emp e6 = new RegularEmployee();// parent class reference variable can refer to child class object
            e6.Display();


        }
    }
}




class Product
{
    //data Member
    public int ID { get; set; }
    private string name;

    public string Desc { get; set; }
    protected int Price;


    public Product()
    {

    }


    public Product(int id, String name, String desc, int price)
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
        //only get -read only Properttiy and only set Write only Propertiy
        get
        {
            return name;
        }
        set
        {
            name = value;

        }
    }

    public void display()
    {
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Description: " + Desc);
        Console.WriteLine("Price: " + Price);

        Console.WriteLine("====================================");
    }

}


internal class Demo
{
    public static void _DemoMain(string[] args)
    {
        Product p = new Product();
        p.Name = "Piyush";
        p.ID = 1;
        p.Desc = "Laptop";
        p.setPrice(50000);
        p.display();

        Product p1 = new Product();
        p1.Name = "Priyank";
        p1.ID = 2;
        p1.Desc = "Desktop";
        p1.setPrice(100000);
        p1.display();

    }
}