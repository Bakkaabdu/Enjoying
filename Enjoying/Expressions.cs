namespace Enjoying;

public class ExpressionExamples
{
    public static void DemonstrateExpressions()
    {
        /*
         * Concepts Covered:
         * 1. Expression Types (Primary/Void)
         * 2. Null Operators (Coalescing, Conditional)
         * 3. Statements vs Blocks
         * 4. Selection Statements (if/switch)
         * 5. Iteration (while/do-while/for/foreach)
         * 6. Jump Statements (break/continue/goto)
         */

        //---------------------------------------------------------------------
        // 1. Expression Types
        // Primary expression (returns value)
        double sineValue = Math.Sin(20.3);
        
        // Void expression (no return value)
        Console.WriteLine("Hello World!");

        //---------------------------------------------------------------------
        // 2. Null Operators
        string s1 = null;
        s1 ??= "Abdulrahman";  // Null coalescing assignment
        s1 ??= "Wisam";        // Won't execute as s1 now has value

        // Null conditional operator
        string s3 = null;
        s3?.ToLower();  // Safe method call

        // Equivalent null check
        var s4 = s3 != null ? s3.ToUpper() : null;

        //---------------------------------------------------------------------
        // 3. Statements and Blocks
        // Single statement
        Console.WriteLine("Single statement");

        // Statement block
        {
            Console.WriteLine("Block statement 1");
            Console.WriteLine("Block statement 2");
        }

        //---------------------------------------------------------------------
        // 4. Selection Statements
        int mark = 90;
        if (mark >= 85)
        {
            Console.WriteLine("Excellent");
        }
        else if (mark >= 60)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }

        // Switch expression (C# 8+)
        int cardNo = 13;
        string cardName = cardNo switch
        {
            1 => "Ace",
            11 => "Jack",
            12 => "Queen",
            13 => "King",
            _ => "Unknown"
        };

        //---------------------------------------------------------------------
        // 5. Iteration Statements
        // While loop (properly braced)
        int counter = 0;
        while (counter < 100)
        {
            Console.WriteLine(counter);
            counter++;
        }

        // For loop with multiple variables (Fibonacci)
        for (int i = 0, prev = 0, current = 1; i < 10; i++)
        {
            Console.WriteLine($"Fibonacci {i}: {prev}");
            int newFib = prev + current;
            prev = current;
            current = newFib;
        }

        // Foreach iteration
        foreach (char c in "developer")
        {
            Console.Write($"{c} ");
        }

        //---------------------------------------------------------------------
        // 6. Jump Statements
        // Break example
        for (int i = 0; ; i++)
        {
            if (i > 5) break;
            Console.WriteLine(i);
        }

        // Continue example
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0) continue;
            Console.WriteLine($"Odd: {i}");
        }

        // Goto example (use sparingly)
        int startValue = 0;
    StartLabel:
        if (startValue++ < 5)
        {
            Console.WriteLine($"Goto: {startValue}");
            goto StartLabel;
        }
    }
}