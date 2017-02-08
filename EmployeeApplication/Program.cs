using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {           
            int input, inpuT, sal, bon, index;
            string name, proff, car, inpt;
       
            List<Employee> employees = new List<Employee>();
            List<Boss> bosses = new List<Boss>();
            do
            {
                Console.WriteLine("1. Add new worker:");
                Console.WriteLine("2. Change data:");
                Console.WriteLine("3. Print data:");
                Console.WriteLine("0. To end the application:");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("1. To add new employee:");
                    Console.WriteLine("2. To add new boss:");
                    inpuT = int.Parse(Console.ReadLine());
                    if (inpuT == 1)
                    {
                        Console.WriteLine("Give name");
                        name = Console.ReadLine();
                        Console.WriteLine("Give profession");
                        proff = Console.ReadLine();
                        Console.WriteLine("Give salary");
                        sal = int.Parse(Console.ReadLine());
                        employees.Add(new Employee(name, proff, sal));
                        Console.WriteLine("Added!");
                    }
                    if (inpuT == 2)
                    {
                        Console.WriteLine("Give name");
                        name = Console.ReadLine();
                        Console.WriteLine("Give profession");
                        proff = Console.ReadLine();
                        Console.WriteLine("Give salary");
                        sal = int.Parse(Console.ReadLine());
                        Console.WriteLine("Give Car");
                        car = Console.ReadLine();
                        Console.WriteLine("Give Bonus");
                        bon = int.Parse(Console.ReadLine());
                        bosses.Add(new Boss(name, proff, sal, car, bon));
                        Console.WriteLine("Added!");
                    }
                }
                if (input == 2)
                {
                    Console.WriteLine("1. To change employee data");
                    Console.WriteLine("2. To change boss data");
                    inpuT = int.Parse(Console.ReadLine());
                    if (inpuT == 1)
                    {
                        foreach (Employee employee in employees)
                        {
                            Console.WriteLine("Name: " + employee.name + ", Profession: " + employee.profession + ", Salary: " + employee.salary);
                        }
                        Console.WriteLine("What to change(name, profession, salary)");
                        inpt = Console.ReadLine();
                        if (inpt == "name")
                        {
                            Console.WriteLine("Give index number of employee example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new name");
                            name = Console.ReadLine();
                            employees[index].name = name;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "profession")
                        {
                            Console.WriteLine("Give index number of employee example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new profession");
                            proff = Console.ReadLine();
                            employees[index].profession = proff;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "salary")
                        {
                            Console.WriteLine("Give index number of employee example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new profession");
                            sal = int.Parse(Console.ReadLine());
                            employees[index].salary = sal;
                            Console.WriteLine("Changed!");
                        }
                    }
                    if (inpuT == 2)
                    {
                        foreach (Boss boss in bosses)
                        {
                            Console.WriteLine("Name: " + boss.name + ", Profession: " + boss.profession + ", Salary: " + boss.salary + ", Car: " + boss.car + ", Bonus: " + boss.bonus);                                                       
                        }
                        Console.WriteLine("What to change(name, profession, salary, car, bonus)");
                        inpt = Console.ReadLine();
                        if (inpt == "name")
                        {
                            Console.WriteLine("Give index number of boss. example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new name");
                            name = Console.ReadLine();
                            bosses[index].name = name;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "profession")
                        {
                            Console.WriteLine("Give index number of boss. example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new profession");
                            proff = Console.ReadLine();
                            bosses[index].profession = proff;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "salary")
                        {
                            Console.WriteLine("Give index number of boss. example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new profession");
                            sal = int.Parse(Console.ReadLine());
                            bosses[index].salary = sal;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "car")
                        {
                            Console.WriteLine("Give index number of boss. example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new profession");
                            car = Console.ReadLine();
                            bosses[index].car = car;
                            Console.WriteLine("Changed!");
                        }
                        if (inpt == "bonus")
                        {
                            Console.WriteLine("Give index number of boss. example.. 0,1,2,3...");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Give a new profession");
                            bon = int.Parse(Console.ReadLine());
                            bosses[index].bonus = bon;
                            Console.WriteLine("Changed!");
                        }
                    }
                }
                if (input == 3)
                {
                    Console.WriteLine("Employees: ");
                    foreach (Employee employee in employees)
                    {
                        Console.WriteLine("Name: " + employee.name + ", Profession: " + employee.profession + ", Salary: " + employee.salary);
                    }
                    Console.WriteLine("Bosses: ");
                    foreach (Boss boss in bosses)
                    {
                        Console.WriteLine("Name: " + boss.name + ", Profession: " + boss.profession + ", Salary: " + boss.salary + ", Car: " + boss.car + ", Bonus: " + boss.bonus);
                    }
                }
            }
            while (input != 0);
        }
    }
}
