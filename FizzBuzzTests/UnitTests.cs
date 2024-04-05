namespace FizzBuzzTests;
using FizzBuzzLibrary;

public class UnitTests
{
    [Fact]
    public void Given1Output1()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        string? actual = fb.GetOutput(1);
        // string expected = "1";
        string expected = "null";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given3Output12Fizz()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        string? actual = fb.GetOutput(3);
        string expected = "1 2 Fizz";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given5Output12Fizz4Buzz()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        string? actual = fb.GetOutput(5);
        string expected = "1 2 Fizz 4 Buzz";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given5Output1234Fizz4Buzz()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        string? actual = fb.GetOutput(5);
        string expected = "1 2 Fizz 4 Buzz";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given5Output12Fizz4Buzz__()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        string? actual = fb.GetOutput(15);
        string expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz";
        Assert.Equal(expected, actual);
    }


    //Write the test that throws exeception if the input is a negative number
    [Fact]
    public void GivenNegativeOutputException()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        Assert.Throws<ArgumentException>(() => fb.GetOutput(-100));
    }

    //Write the test that the number is greate than 100, throw an exception
    [Fact]
    public void GivenGreaterThan100OutputException()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        Assert.Throws<ArgumentException>(() => fb.GetOutput(101));
    }

    //Write the test that the number is 0, throw an exception
    [Fact]
    public void Given0OutputException()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        Assert.Throws<ArgumentException>(() => fb.GetOutput(0));
    }

    //Write the test that the number is null, throw an exception
    [Fact]
    public void GivenNullOutputException()
    {
        FizzBuzzLogic fb = new FizzBuzzLogic();
        Assert.Throws<ArgumentException>(() => fb.GetOutput((int?)null));
    }
}