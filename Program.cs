using System;

namespace PayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeA = "Michael Jackson";
            string employeeB = "Bruno Mars";
            string employeePositionStaff = "Staff";
            string employeePositionHeadStaff = "Head Staff";
            int staffSalary = 16000;
            int headStaffSalary = 22000;

            Console.WriteLine("Welcome to Payroll System");
            Console.WriteLine("Here are the List's of Employees:");
            Console.WriteLine("A: " + employeeA);
            Console.WriteLine("B: " + employeeB);

            Console.Write("If you wish to view the payslip of employee A type a and if employee B type b: ");
            string optionSelected = Console.ReadLine().ToLower();
            if (optionSelected.Equals("a")){
                Console.WriteLine("Name: " + employeeA); 
                Console.WriteLine("Job Position: " + employeePositionStaff);
                Console.WriteLine("Monthly Salary: " + staffSalary);
            }
            else if (optionSelected.Equals("b")){
                Console.WriteLine("Name: " + employeeB);
                Console.WriteLine("Job Position: " + employeePositionHeadStaff);
                Console.WriteLine("Monthly Salary: " + headStaffSalary);
            }
            else
            {
                Console.WriteLine("INVALID OPTION!!!");
            }
        }
    }
}
