namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestFizzBuzzGameZero()
    {
        Assert.Multiple(() =>
        {
            Assert.That(FizzBuzz.GameZero(3), Is.EqualTo("Fizz"));
            Assert.That(FizzBuzz.GameZero(5), Is.EqualTo("Buzz"));
            Assert.That(FizzBuzz.GameZero(15), Is.EqualTo("FizzBuzz"));
            Assert.That(FizzBuzz.GameZero(1), Is.EqualTo("1"));
        });
    }

    [Test]
    public void TestFizzBuzzGameOne()
    {
        Assert.Multiple(() =>
        {
            Assert.That(FizzBuzz.GameOne(3), Is.EqualTo("Fizz"));
            Assert.That(FizzBuzz.GameOne(5), Is.EqualTo("Buzz"));
            Assert.That(FizzBuzz.GameOne(15), Is.EqualTo("FizzBuzz"));
            Assert.That(FizzBuzz.GameOne(1), Is.EqualTo("1"));
        });
    }
}