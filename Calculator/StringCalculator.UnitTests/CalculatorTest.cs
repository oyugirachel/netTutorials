using Xunit;
using FluentAssertions;
namespace StringCalculator.UnitTests;

public class CalculatorTest
{
    [Theory]
    [InlineData("",0)]
    [InlineData("1",1)]
    [InlineData("1,2",3)]


    public void Add_AddsUptoTwoNumbers_WhenStringIsValid(string calculation , int expected){
        //Arrange
        var sut = new Calculator();

        //Act
        var result = sut.Add();
        //Assert
        result.Should().Be(expected);


    }



    public void Test1()
    {

    }
}