using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class EmployeeWithGetAndSet
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;

        // Constructors.
        public EmployeeWithGetAndSet() { }
        public EmployeeWithGetAndSet(string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }

        // Methods.
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
        }

        // Accessor ( get method).
        public string GetName()
        {
            return empName;
        }

        // Mutator (set method).
        public void SetName(string name)
        {
            // Do a check on incoming value before making assignment.
            if (name.Length > 15)
                Console.WriteLine("Error! Name must be less than 16 characters!");
            else
                empName = name;
        }
    }

    class Employee
    {
        // Field data.
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;

        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
        }

        // Methods.
        public void GiveBonus(float amount)
        { Pay += amount; }

        public void DisplayStatus()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }

        // Properties!
        public string Name 
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                else
                    empName = value;
            }
        }

        // We could add additional business rules to the sets of these properties;
        // however, there is no need to do so for this example
        public int ID 
        {
            get { return empID; }
            set { empID = value; }
        }

        public float Pay 
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public int Age 
        {
            get { return empAge; }
            set { empAge = value; }
        }

        
    }
}
