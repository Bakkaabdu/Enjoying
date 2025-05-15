namespace Enjoying;

public class CastingConversions
{
    public static void DemonstrateCasting()
    {
        /*
         * Concepts Covered:
         * 1. Everything inherits from System.Object
         * 2. Implicit vs Explicit Casting
         * 3. Boxing/Unboxing
         * 4. Convert class vs Parse methods
         * 5. TryParse pattern
         * 6. BitConverter basics
         */
        
        //---------------------------------------------------------------------
        // 1. Implicit and Explicit Casting
        int numberInt = 100;
        
        // Implicit casting (no data loss risk)
        long numberLong = numberInt;
        
        // Explicit casting (potential data loss)
        long bigNumber = 1_000_000_000_000;
        if (bigNumber <= int.MaxValue)
        {
            int safeInt = (int)bigNumber;
        }
        
        // Floating point to integer conversion
        double doubleValue = 1234.567;
        int truncatedInt = (int)doubleValue;  // Results in 1234

        //---------------------------------------------------------------------
        // 2. Boxing and Unboxing
        int valueType = 42;
        
        // Boxing: value type → reference type
        object boxedObject = valueType;  // Implicit conversion
        
        // Unboxing: reference type → value type
        if (boxedObject is int)
        {
            int unboxedValue = (int)boxedObject;  // Explicit conversion
        }

        //---------------------------------------------------------------------
        // 3. Parse vs Convert vs TryParse
        
        // Parse method (throws FormatException/OverflowException)
        string validNumber = "200";
        int parsedNumber = int.Parse(validNumber);
        
        // Convert class (handles null more gracefully)
        int convertedNumber = Convert.ToInt32("123");
        
        // TryParse pattern (safe conversion)
        string riskyInput = "999999999999999999999999999999999999999999";
        if (int.TryParse(riskyInput, out int tryResult))
        {
            Console.WriteLine($"Success: {tryResult}");
        }
        else
        {
            Console.WriteLine("Failed to parse input");
        }

        //---------------------------------------------------------------------
        // 4. BitConverter Example
        byte[] byteArray = BitConverter.GetBytes(123456789);
        Console.WriteLine($"Byte array length: {byteArray.Length}");
        
        int reconstructedInt = BitConverter.ToInt32(byteArray, 0);
        Console.WriteLine($"Reconstructed integer: {reconstructedInt}");
    }
}