using System;

class Program
{
    static void Main(string[] args)
    {
        // STEP 5: Create the Getters and Setters
        // 2. In your Program.cs file, verify that you can call all of these methods and get the correct values, 
        // using setters to change the values and then getters to retrieve these new values and then display them to the console.
        
        // Fraction fractions = new Fraction();

        // Console.WriteLine(fractions.GetTop());
        // Console.WriteLine(fractions.GetBottom());

        // STEP 6: Create methods to return the representations
        // Verify that you can call each constructor and that you can retrieve and display the different representations 
        // for a few different fractions. For example, you could try: 1, 5, 3/4, 1/3

        Fraction fraction1 = new Fraction();

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

    }
}