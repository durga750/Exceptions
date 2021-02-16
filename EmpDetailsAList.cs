using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collections
{
    class Employee
    {
        int id;
        string name;
        int salary;
        public Employee(int id,string name,int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"{id}\t{name}\t{salary}";
        }
    }
    class EmpDetailsAList
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Employee(121, "gfd", 50000));
            al.Add(new Employee(12, "jhgf", 55000));
            al.Add(new Employee(1213456, "mnbvcx", 10000));
            foreach (Employee e in al)
            {
                Console.WriteLine(e);
            }
            

        }
    }
}
