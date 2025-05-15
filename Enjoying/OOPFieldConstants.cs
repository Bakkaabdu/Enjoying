namespace Enjoying;

public class OOPFieldConstants
{
    /*
     * Introduction
     * OOP Definition
     * Class vs Object
     * Access Modifiers
     * Field Constant
     */

    /*
     * Company is looking for application to do salary slip calculation for
     * employee based on daily bases following the rule total Earnings is
     * equal to Hours logged times his wage. fixed tax is applied 3% on all
     * user need to enter input and salary will be shown accordingly 
     */

    #region Old school approach

    public void First()
    {
        const double TAX = 0.03;

        Console.WriteLine("First Name : ");
        var fName = Console.ReadLine();

        Console.WriteLine("Last Name : ");
        var lName = Console.ReadLine();

        Console.Write("Wage: ");
        var wage = Convert.ToDouble(Console.ReadLine());

        Console.Write("logged Hours: ");
        var loggedHours = Convert.ToDouble(Console.ReadLine());

        var netSalary = wage * loggedHours - (wage * loggedHours * TAX);

        Console.WriteLine($"First Name: {fName}");
        Console.WriteLine($"Last Name: {lName}");
        Console.WriteLine($"Wage: {wage}");
        Console.WriteLine($"Logged Hours: {loggedHours}");
        Console.WriteLine($"Logged Hours: {netSalary}");

        // so we have a problem in here everytime we want to assign new employee we
        // need to recode all this again with new variables 
    }

    #endregion

}
// chapter 2 of the story : OOP

// <ClassModifier> -> public, internal(default), 
/*
 * <ClassModifier> -> class <ClassName>
  {
        class block
  }
 */
public class Employee
{
    // <AccessModifier> public, private, protected
    // Constant -> <AccessModifier> const <DataType> <ConstantName> = <Value>;
    public const double TAX = 0.03;

    // <AccessModifier> public, private, protected
    // Fields -> <AccessModifier> <DataType> <FieldName> = <InitialValue>;
    public string FName;
    public string LName;
    public double Wage;
    public double LoggedHours;
}
