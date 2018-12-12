using Xunit;

namespace AlphaSierraPapa.WhiskyEchoBravo.Lib.Test
{
  public class MyClassTest : IClassFixture<MyClass>
  {
    private MyClass _myClass;

    public MyClassTest(MyClass myClass)
    {
      _myClass = myClass;
    }

    [Fact]
    public void TestMyMethod()
    {
      var result = _myClass.MyMethod(1, 2);

      Assert.Equal(3, result);
    }
  }
}
