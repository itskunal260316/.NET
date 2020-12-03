using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            Console.WriteLine("Emp No : " + e1.EmpNo+" Emp Name : "+e1.Name);
            Console.WriteLine("O : " + e2.EmpNo + " Emp Name : " + e2.Name);
            Console.WriteLine("O : " + e3.EmpNo + " Emp Name : " + e3.Name);
        }
    }

    public class Employee
    {

        public String Name;
        static int TotEmpNo = 1;
        public int EmpNo;
        public decimal Basic;
        public short DeptNo;

        public Employee()
        {
            this.EmpNo = TotEmpNo++;
            String nameNew = "Employee " + EmpNo;
            this.Name = nameNew;
        }

        public Employee(String name)
        {
            this.EmpNo = TotEmpNo++;
            this.Name = name;
       
        }

        public Employee(String name, int basicSal)
        {
            this.EmpNo = TotEmpNo++;
            this.Name = name;
            this.Basic = basicSal;
        }

        public Employee(String name, int basicSal, short deptNo)
        {
            this.EmpNo = TotEmpNo++;
            this.Name = name;
            this.Basic = basicSal;
            this.DeptNo = deptNo;
        }


        public decimal GetNetSalary()
        {
            return  this.Basic + 120;
        }

    }
}
