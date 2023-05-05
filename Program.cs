using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_New_
{
    internal class Program
    {
        readonly String name;    // instance read only variable 
        int salary;   // instance variable 
        readonly int Pid;


        static String companyname;          // static variable 
        readonly static String companypolicy;      // readonly static variable

        const int Cyear = 1977;

        public Program(String n,int s,int id)
        {
            this.name = n;
            this.salary = s;
            this.Pid = id;
        }

        void display()
        {
            Console.WriteLine(name + " "+salary+" "+Pid);
        }


        static void Main(string[] args)
        {

            Program obj = new Program("Saksham" , 20000 , 1);
            obj.display();

        }
    }
}
