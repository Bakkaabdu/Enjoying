namespace Enjoying;

public class Program
{
    static void Main(string[] args)
    {
        #region From OOPFieldConstantsClass
        // Object syntax;
        // Declaration <Type> <ObjectName>;
        // Assignment <ObjectName> = new <Type>();
        // Initialization <Type> <ObjectName> = new <Type>();
        //Employee[] emps = new Employee[2];
        //Employee l1 = new Employee();
        //Console.WriteLine("First employee");
        //Console.WriteLine("==============================");
        //Console.WriteLine("==============================");
        //Console.Write("First Name:");
        //l1.FName = Console.ReadLine();

        //Console.Write("Last Name:");
        //l1.LName = Console.ReadLine();

        //Console.Write("Wage:");
        //l1.Wage = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Hours:");
        //l1.LoggedHours = Convert.ToDouble(Console.ReadLine());
        //emps[0] = l1; 

        //Console.WriteLine("Second employee");
        //Console.WriteLine("==============================");
        //Console.WriteLine("==============================");
        //Employee l2 = new Employee();

        //Console.Write("First Name:");
        //l2.FName = Console.ReadLine();

        //Console.Write("Last Name:");
        //l2.LName = Console.ReadLine();

        //Console.Write("Wage:");
        //l2.Wage = Convert.ToDouble(Console.ReadLine());

        //Console.Write("LoggedHours:");
        //l2.LoggedHours = Convert.ToDouble(Console.ReadLine());

        //emps[1] = l2;

        //foreach (var emp in emps)
        //{
        //    Console.WriteLine("===============================");
        //    var netSalary = emp.Wage * emp.LoggedHours - (emp.Wage * emp.LoggedHours * Employee.TAX);
        //    Console.WriteLine($"First Name: {emp.FName}");
        //    Console.WriteLine($"Last Name: {emp.LName}");
        //    Console.WriteLine($"Wage: {emp.Wage}");
        //    Console.WriteLine($"Logged Hours: {emp.LoggedHours}");
        //    Console.WriteLine($"Net Hours: {netSalary}");
        //    Console.WriteLine("===============================");
        //}

        #endregion

        #region From Methods Class
        // Make object of the class
        Methods M = new Methods();

        // Call the method
        M.DoSomething();

        #endregion
    }
}
