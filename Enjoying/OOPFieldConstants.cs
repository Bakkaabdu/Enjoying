namespace Enjoying
{
    public class OOPFieldConstants
    {
        /*
         * Topics Covered:
         * - Introduction to OOP
         * - OOP Definition
         * - Class vs Object
         * - Access Modifiers
         * - Field & Constant Declaration
         */

        /*
         * Problem Statement:
         * A company needs a salary slip calculator.
         * The salary is calculated daily as:
         *      Net Salary = Logged Hours * Wage - 3% Tax
         * 
         * Users input employee info and the application calculates the salary.
         */

        #region Old School Approach (Procedural Style)

        public void First()
        {
            const double TAX = 0.03;

            Console.Write("First Name: ");
            var fName = Console.ReadLine();

            Console.Write("Last Name: ");
            var lName = Console.ReadLine();

            Console.Write("Wage: ");
            var wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Logged Hours: ");
            var loggedHours = Convert.ToDouble(Console.ReadLine());

            // Net salary calculation
            var gross = wage * loggedHours;
            var taxAmount = gross * TAX;
            var netSalary = gross - taxAmount;

            Console.WriteLine($"\n--- Salary Slip ---");
            Console.WriteLine($"First Name   : {fName}");
            Console.WriteLine($"Last Name    : {lName}");
            Console.WriteLine($"Wage         : {wage}");
            Console.WriteLine($"Logged Hours : {loggedHours}");
            Console.WriteLine($"Net Salary   : {netSalary}");

            /*
             * Problem with this approach:
             * Every time we want to calculate salary for a new employee,
             * we must duplicate the entire block of logic.
             * This violates the DRY principle (Don't Repeat Yourself).
             */
        }

        #endregion
    }

    // Chapter 2: Object-Oriented Programming (OOP) Approach

    /*
     * Class Syntax:
     * <AccessModifier> class <ClassName>
     * {
     *     // fields, properties, methods, etc.
     * }
     */

    public class Employee
    {
        // Constant Declaration
        // A fixed value that cannot be changed during program execution.
        public const double TAX = 0.03;

        // Fields: used to store data about the employee (state)
        public string FName;        // First name of the employee
        public string LName;        // Last name of the employee
        public double Wage;         // Hourly wage
        public double LoggedHours;  // Hours worked

        // Later you can add a method to calculate salary in this class for OOP encapsulation.
    }
}
