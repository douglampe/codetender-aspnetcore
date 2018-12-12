using AlphaSierraPapa.WhiskyEchoBravo.Lib;
using Microsoft.AspNetCore.Mvc;

namespace AlphaSierraPapa.WhiskyEchoBravo.Web
{
  [Route("api/myroute")]
  [ApiController]
  public class MyController : ControllerBase
  {
    private MyClass _myClass;

    public MyController(MyClass myClass)
    {
      _myClass = myClass;
    }

    [HttpGet("{a}/{b}")]
    public int MyMethod(int a, int b)
    {
      return _myClass.MyMethod(a, b);
    }
  }
}