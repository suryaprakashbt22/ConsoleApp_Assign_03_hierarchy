// See https://aka.ms/new-console-template for more information
using ConsoleApp_Assign_03_hierarchy;
Console.WriteLine("---------------Hierarchy of Employee Manager and Marketing Executive---------------");
bool continueLoop = true;
while (continueLoop){
    Console.WriteLine("Enter the Details of the New Employee:\n");
    Console.WriteLine("Enter the NAME:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter the SALARY:");
    double salaryOfEmployee = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Select the Designation: \nPress 1 for MANAGER.\nPress 2 for MARKETING EXECUTIVE\n");
    int designationChoice = Convert.ToInt32(Console.ReadLine());

    if (designationChoice == 1)
    {
        Employee E = new Manager(name, "Manager", salaryOfEmployee);
        E.CalculateSalary();
        E.printDetails();
    }
    else
    {
        Console.WriteLine("Enter the Distance Travelled to receive Extra Allowance\n");
        double kmTravelled = Convert.ToDouble(Console.ReadLine());
        Employee E = new MarketingExecutive(name, "Marketing Executive", salaryOfEmployee, kmTravelled);
        E.CalculateSalary();
        E.printDetails();
    }

    Console.WriteLine("\nPress 0 to EXIT.\nPress 1 to CONTINUE\n");
    string choice = Console.ReadLine();
    if (choice == "0")
        continueLoop = false;
}
