// STEP 3: Create the Fraction class
using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // STEP 4: Create the Constructors
    // - Constructor that has no parameters that initializes the number to 1/1.
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        
    }

    // Constructor that has one parameter for the top and that initializes the denominator to 1. 
    // So that if you pass in the number 5, the fraction would be initialized to 5/1.
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;

    }

    // Constructor that has two parameters, one for the top and one for the bottom.
    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    // STEP 5: Create the Getters and Setters
    // 1. Create getters and setters for both the top and the bottom values.
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // STEP 6: Create methods to return the representations
    // 1. Create a method called GetFractionString that returns the fraction in the form 3/4.
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // 2. Create a method called GetDecimalValue that returns a double that is 
    // the result of dividing the top number by the bottom number, such as 0.75.
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
    

    
}