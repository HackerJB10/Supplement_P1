namespace Supplements.Tests;

public class UnitTest1
{

    [Fact]
    public void ShouldThisCalculateCorrectlyValuesAreaOfRectangle()
    {
         Assert.True(50.0 == Supplement_P1.AreaOfRectangle(5.0,10.0));
    }

    [Fact]
    public void ShouldThisCalculateCorrectlySameValuesAreaOfRectangles()
    {
        Assert.True(25.0 == Supplement_P1.AreaOfRectangle(5.0,5.0));
    }

    [Fact]
    public void ShouldThisCalculateCorrectlyValuesAreaOfUnitCircle()
    {
        Assert.True(double.Pi == Supplement_P1.AreaOfCircle(1.0));
    }

    [Fact]
    public void ShouldThisCalculateCorrectlyValuesAreaOfTriangle()
    {
        Assert.True(100.0 == Supplement_P1.AreaOfTriangle(50.0,4.0));
    }



}
