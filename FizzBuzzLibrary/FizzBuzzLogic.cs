
namespace FizzBuzzLibrary;

public class FizzBuzzLogic
{
    public string? GetOutput(int? number)
    {
        //throw new NotImplementedException()
        if (number < 0)
        {
            throw new ArgumentException("Number must be greater than 0");
        }
        if (number > 100)
        {
            throw new ArgumentException("Number must be less than 100");
        }

        if (number == 0)
        {
            throw new ArgumentException("Number cannot be 0");
        }

        if (number == null)
        {
            throw new ArgumentException("Number cannot be null");
        }



        string output = string.Empty;
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                output += "FizzBuzz ";
            }
            else if (i % 3 == 0)
            {
                output += "Fizz ";
            }
            else if (i % 5 == 0)
            {
                output += "Buzz ";
            }
            else
            {
                output += i + " ";
            }

        }
        return output.Trim();
    }

    public void GetOutput(string v)
    {
        throw new NotImplementedException();
    }
}
