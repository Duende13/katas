using NUnit.Framework;

[TestFixture]
public class Tests
{
    [TestFixture]
    public void SampleTests()
    {
        Assert.That(Kata.IsPangram("The quick brown fox jumps over the lazy dog."), Is.EqualTo(true));
        Assert.That(Kata.IsPangram("This is not a pangram."), Is.EqualTo(false));
        
    }
}