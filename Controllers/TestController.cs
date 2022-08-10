using Microsoft.AspNetCore.Mvc;

[ApiController]
[route("test/")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Minha Api está rodando!";
    }
}