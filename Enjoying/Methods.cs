namespace Enjoying
{
    public class Methods
    {
        /*
         * Topics Covered:
         * - Instance vs Static Members
         * - Method Signatures
         * - Expression-bodied Methods
         * - Method Overloading
         * - Passing Parameters by Value vs Reference
         * - Local Methods
         */

        /*
         * General Method Syntax:
         * 
         * <AccessModifier> <ReturnType>/void <MethodName>(<ParameterList>)
         * {
         *     // series of statements
         * }
         */

        // Example 1: Basic method
        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
            // To call this method, go to the Program class and use: new Methods().DoSomething();
        }

        // Example 2: Passing parameter by value (default behavior)
        public void Age(int age)
        {
            var totalAge = age + 10;

            /*
             * Even if we modify `age` here, the original variable in the calling method will not be affected.
             * Why?
             * Because `age` is passed by value, so this method works on a copy of the original variable.
             */
        }

        // Example 3: Passing parameter by reference using `ref`
        public void Age(ref int age)
        {
            age += 10;

            /*
             * Now the original `age` variable in the calling method is modified.
             * To call this method: Age(ref age);
             */
        }

        // Example 4: Using `out` keyword
        public void Age(out int age)
        {
            age = 30;

            /*
             * The `out` keyword also passes the variable by reference.
             * However, the variable must be assigned a value within the method.
             * Use case: when you want the method to initialize or output a value.
             * To call this method: Age(out age);
             */
        }

        // --------------------------------------------
        // Method Signatures:
        // A method signature is determined by:
        // Method name + Parameter types + Parameter order (Return type is NOT part of the signature)
        // --------------------------------------------

        public void DoSomething(int a, string b)
        {
            Console.WriteLine("Doing something with int and string");
        }

        public void DoSomething(string b, int a)
        {
            Console.WriteLine("Doing something with string and int");
        }

        public int DoSomething(int a, string b, int c)
        {
            Console.WriteLine("Doing something and returning an int");
            return a + c; // example logic
        }

        public void Do()
        {
            Console.WriteLine("Doing something (basic method)");
        }

        // --------------------------------------------
        // Method Overloading (Polymorphism)
        // Same method name with different signatures (parameter types/order/count)
        // --------------------------------------------

        public void Promote(double amount)
        {
            Console.WriteLine($"You've got a promotion of ${amount}");
        }

        public void Promote(double amount, string trip)
        {
            Console.WriteLine($"You've got a promotion of ${amount} and a trip to {trip}");
        }

        public void Promote(double amount, string trip, string hotel)
        {
            Console.WriteLine($"You've got a promotion of ${amount}, a trip to {trip}, and a stay at {hotel}");
        }

        // --------------------------------------------
        // Expression-bodied Method
        // Used when method has only one expression to return
        // --------------------------------------------

        public int Add(int a, int b) => a + b;

        // --------------------------------------------
        // Local Method
        // A method defined within another method
        // Used when helper logic is only needed within the outer method
        // --------------------------------------------

        public void ShowLocalMethodExample()
        {
            Console.WriteLine("Inside the main method");

            // Local method defined inside this method
            void Greet()
            {
                Console.WriteLine("Hello from local method!");
            }

        }
    }
}
