using System;

namespace Wages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            caller c = new caller();
            c.call();
            Console.ReadLine();
        }
    }
    class caller
    {
        public void call() {
            employee emp = new employee();
            Console.WriteLine("enter the employee num");
            emp.EmpNUm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the employee name");
            emp.Name = Console.ReadLine();
            Console.WriteLine("enter the employee Surname");
            emp.Surname = Console.ReadLine();
            Console.WriteLine("enter the hours worked");
            emp.Hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the rate worked");
            emp.Rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" empId {0}\n Name: {1}\n wage{2}" +
                "",emp.EmpNUm,emp.Name+" "+emp.Surname,emp.Wage());
        }
    }
    class employee
    {
        private int empNUm;
        private string name;
        private string surname;
        private double hours = 1;
        private double rate = 1;        

        public int EmpNUm
        {
            get
            {
                return empNUm;
            }
            set
            {
                if(value>0)
                empNUm = value;
                else
                {
                    Console.WriteLine("PLease enter a value above zero");
                    caller c = new caller();
                    c.call();
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public double Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if(value>0)
                hours = value;
                else
                {
                    Console.WriteLine("PLease enter a value above zero");
                    caller c = new caller();
                    c.call();
                }
            }
        }
        public double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                if (value > 0)
                    rate = value;
                else
                {
                    Console.WriteLine("PLease enter a value above zero");
                    caller c = new caller();
                    c.call();
                }
            }
        }
        public double Wage()
        {
            return rate * hours;
        }
    }
}
