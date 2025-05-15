namespace Enjoying;

public class ArrayExamples
{
    public static void DemonstrateArrays()
    {
        /*
         * Array Concepts Covered:
         * 1. Storage and Memory Allocation
         * 2. Declaration & Initialization
         * 3. Multi-Dimensional Arrays
         * 4. Jagged Arrays
         * 5. Indices and Ranges
         * 6. Bounds Checking
         */

        //---------------------------------------------------------------------
        // 1. Storage and Memory Allocation
        // Arrays are reference types stored contiguously in heap memory
        // The array variable (reference) is stored in the stack

        //---------------------------------------------------------------------
        // 2. Single-Dimensional Arrays
        
        // Declaration
        string[] devs = new string[6]; // Fixed size to accommodate all elements
        
        // Element Assignment
        devs[0] = "Abdulrahman Abdullah";
        devs[1] = "Faisal Alshreef";
        devs[2] = "Radwan Algusbi";
        devs[3] = "Omar Hakosh";
        devs[4] = "Wisam Alkhatib";
        devs[5] = "Roaa Awarek";

        // Initialization with values
        string[] devsPositions = new string[6] 
        {
            "Abdulrahman Abdullah: Backend Dev",
            "Faisal Alshreef: Backend Dev",
            "Radwan Algusbi: Backend Dev",
            "Omar Hakosh: Backend Dev",
            "Wisam Alkhatib: Backend Dev",
            "Roaa Awarek: Backend Dev"
        };

        //---------------------------------------------------------------------
        // 3. Multi-Dimensional Arrays (Rectangular Arrays)
        int[,] matrix = 
        {
            {1, 2, 34, 4, 5, 5, 3, 2},
            {1, 2, 34, 4, 5, 5, 3, 2},
            {1, 2, 34, 4, 5, 5, 3, 2},
            {1, 2, 34, 4, 5, 5, 3, 2},
            {1, 2, 34, 4, 5, 5, 3, 2}
        };

        //---------------------------------------------------------------------
        // 4. Jagged Arrays (Array-of-Arrays)
        int[][] jaggedArray = 
        {
            new int[] {1, 2},
            new int[] {2, 3, 3},
            new int[] {7}
        };

        //---------------------------------------------------------------------
        // 5. Indices and Ranges (C# 8.0+)
        string[] names = { "Ahmed", "Muhammed", "Ali", "Bakka", "John" };
        
        // Individual element access
        var firstElement = names[0];       // "Ahmed"
        
        // Range examples
        var firstTwo = names[..2];        // ["Ahmed", "Muhammed"]
        var fromThird = names[2..];       // ["Ali", "Bakka", "John"]
        var singleElement = names[2..3];  // ["Ali"]
        var middleSection = names[2..^2]; // ["Ali"] (excludes last two elements)
        
        // Storing range definition
        Range customRange = 2..^2;
        var rangeResult = names[customRange];

        //---------------------------------------------------------------------
        // 6. Bounds Checking
        // Uncommenting this will throw IndexOutOfRangeException
        // var invalidAccess = names[5];
        
        // Proper bounds checking example:
        int indexToAccess = 5;
        if (indexToAccess >= 0 && indexToAccess < names.Length)
        {
            var validItem = names[indexToAccess];
        }
    }
}