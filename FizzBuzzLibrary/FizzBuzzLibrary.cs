using System.Reflection.Metadata.Ecma335;

namespace FizzBuzzLibrary;

public static class FizzBuzz
{
    /// <summary>
    /// FizzBuzz Solution Zero using string and boolean
    /// </summary>
    /// <param name="Number"></param>
    /// <returns></returns>
    public static string GameZero(int Number)
    {
        string output = "";
        bool trigger = false;

        if (Number % 3 == 0)
        {
            output += "Fizz";
            trigger = true;
        }
        if (Number % 5 == 0)
        {
            output += "Buzz";
            trigger = true;
        }
        
        if (!trigger)
        {
            output = Number.ToString();
        }

        return output;
    }

    /// <summary>
    /// Basically the same as GameZero but using a ternary operator
    /// </summary>
    /// <param name="Number"></param>
    /// <returns></returns>
    public static string GameOne(int Number)
    {
        string output = "";

        if (Number % 3 == 0)
        {
            output += "Fizz";
        }
        if (Number % 5 == 0)
        {
            output += "Buzz";
        }

        return output == "" ? Number.ToString() : output;
    }

}
