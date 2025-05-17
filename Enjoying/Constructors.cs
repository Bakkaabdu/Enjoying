/*
 * CONSTRUCTORS & OBJECT INITIALIZATION IN C#
 * ------------------------------------------
 * 
 * 1. Implicit Constructor:
 *    - If no constructor is explicitly defined in a class,
 *      the C# compiler automatically provides a default parameterless constructor.
 *    - Once you define any constructor manually, the implicit one is no longer available.
 *
 * 2. Overloaded Constructor:
 *    - A class can have multiple constructors with different parameter lists (signatures).
 *    - This provides flexibility in object creation.
 *      Example:
 *          public Employee() { ... }
 *          public Employee(string name) { ... }
 *
 * 3. This Keyword:
 *    - Refers to the current instance of the class.
 *    - Used to disambiguate between class members and constructor/method parameters.
 *      Example:
 *          this.name = name; // assigns parameter 'name' to the field 'name'
 *
 * 4. Non-public Constructor:
 *    - A constructor can have any access modifier (private, protected, internal).
 *    - Private constructors are used to restrict instantiation, useful in Singleton or Factory patterns.
 *      Example:
 *          private Logger() { }
 *
 * 5. Object Initializer:
 *    - Allows setting public properties or fields during object instantiation without requiring a constructor.
 *      Example:
 *          var person = new Person { Name = \"John\", Age = 30 };
 *
 * 6. Readonly Field:
 *    - A field declared with the `readonly` modifier can only be assigned in the constructor or at the point of declaration.
 *    - Once set, its value cannot change during the lifetime of the object.
 *      Example:
 *          private readonly string _id;
 *
 * Overall Purpose:
 * These features promote clean, safe, and flexible object creation and initialization strategies in C#.
 */

namespace Enjoying
{
    /// <summary>
    /// Demonstrates various constructor types and object initialization patterns in C#.
    /// </summary>
    public class CustomDate
    {
        // Fields representing the components of a date
        public int Day;
        public int Month;
        public int Year;

        /// <summary>
        /// Parameterized constructor to initialize the date.
        /// </summary>
        /// <param name="day">Day component</param>
        /// <param name="month">Month component</param>
        /// <param name="year">Year component</param>
        public CustomDate(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        /// <summary>
        /// Updates the date fields.
        /// </summary>
        public void UpdateDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        /// <summary>
        /// Returns the formatted date string.
        /// </summary>
        public string GetFormattedDate() => $"Date: {Day:D2}/{Month:D2}/{Year}";
    }

    /// <summary>
    /// Demonstrates how constructors are used to initialize objects.
    /// </summary>
    public class ConstructorDemo
    {
        public void Run()
        {
            var date = new CustomDate(1, 1, 2023);
            Console.WriteLine(date.GetFormattedDate());

            date.UpdateDate(2, 2, 2024);
            Console.WriteLine(date.GetFormattedDate());
        }
    }

    /// <summary>
    /// Demonstrates the use of private fields and constructor encapsulation.
    /// </summary>
    public class Person
    {
        // Readonly fields to ensure immutability post-construction
        private readonly string name;
        private readonly int age;

        /// <summary>
        /// Constructor to initialize Person with name and age.
        /// </summary>
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        /// <summary>
        /// Prints the person's details.
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    public class PersonDemo
    {
        public void Run()
        {
            var person = new Person("John", 30);
            person.PrintInfo();
        }
    }

    /// <summary>
    /// Demonstrates object initialization with restricted construction using a private constructor.
    /// </summary>
    public class Book
    {
        // Auto-properties with public getters and setters
        public string Title { get; set; }
        public string Author { get; set; }

        // Private constructor restricts object instantiation outside the class
        private Book() { }

        /// <summary>
        /// Factory method to instantiate Book using object initializer.
        /// </summary>
        public static Book Create(string title, string author)
        {
            return new Book
            {
                Title = title,
                Author = author
            };
        }
    }

    public class BookDemo
    {
        public void Run()
        {
            var book = Book.Create("Clean Code", "Robert C. Martin");
            Console.WriteLine($"Book: {book.Title} by {book.Author}");
        }
    }

    /// <summary>
    /// Summary:
    /// - If no constructors are explicitly defined, C# automatically provides an implicit parameterless constructor.
    /// - Once a constructor is defined, the implicit one is suppressed.
    /// - Use 'this' keyword to refer to the current object instance.
    /// - Constructors can be overloaded to provide flexibility.
    /// - Object initializers allow for easy property assignment when a parameterless constructor is available.
    /// - Use readonly fields to ensure data consistency post-construction.
    /// </summary>
}
