namespace Supplements.Tests;

public class UnitTest1
{
    
    [Fact]
    public void ShouldThisCalculateCorrectlyValuesAreaOfRectangle()
    {
         Assert.True(50.0 == Supplement_P1.AreaOfRectangle(5.0,10.0));
    }
}
