namespace SubAandBЕTest;

public class Tests
{
    [TestCase(2,4,6)]
    [TestCase(0,0,-999)]
    [TestCase(-3,2,-1)]
    
    public void CheckToNumbers(int a,int b,int expectedResult)
    {
        var actualResult= SumAB.Program.Sum(a,b);
        Assert.AreEqual(expectedResult,actualResult); 
    }
    
    [Test]
    public void SumAandB_WithTwoNumbers_ShouldSumNembers()
    {
       CheckToNumbers(3,5,8);
    }
}