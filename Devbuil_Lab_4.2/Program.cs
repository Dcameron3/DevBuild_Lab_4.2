using System;

//From the tests included in this lab, I conclude that creating a new object within the same class does exactly that - creates a NEW, independent
// version of that object that the system considers unique, even if it shares the exact same properties as another object of the same class.

namespace Devbuild_Lab_4._2
{

    class MenuItem
    {
        private int ID;
        private string Name;
        private string Description;
        private decimal Price;

        public int GetID()
        {
            return ID;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetDescription()
        {
            return Description;
        }
        public decimal GetPrice()
        {
            return Price;
        }
        public void SetID(int _ID)
        {
            ID = _ID;
        }
        public void SetName(string _Name)
        {
            if (_Name == "")
            {
                _Name = "EMPTY";
            }
            Name = _Name;

        }
        public void SetDescription(string _Description)
        {
            if (_Description == "")
            {
                _Description = "EMPTY";
            }
            Description = _Description;
        }
        public void SetPrice(decimal _Price)
        {
            if (_Price < 0.50m)
            {
                _Price = 0.50m;
            }
            if (_Price > 10.00m)
            {
                _Price = 10.00m;
            }
            Price = _Price;
        }

        public MenuItem(int _ID, string _Name, string _Description, decimal _Price)
        {
            ID = _ID;
            Name = _Name;
            Description = _Description;
            Price = _Price;

        }
        public MenuItem(int _ID, string _Name, decimal _Price)
        {
            ID = _ID;
            Name = _Name;
            Description = "EMPTY";
            Price = _Price;
        }
    }

    class Rectangle
    {
        public int length;
        public int width;
    }


    class Program
    {
        static void Main(string[] args)
        {
            MenuItem Hamburger = new MenuItem(5, "burger", "on a bun", 5.50m);
            Console.WriteLine(Hamburger.GetName());

            Rectangle r1 = new Rectangle();
            r1.length = 7;
            r1.width = 8;
            Rectangle r2 = new Rectangle();
            r2 = r1;


            if (r1 == r2)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("different");
            }
        }
    }
}
