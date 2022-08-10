using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("test/")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Minha Api está rodando!";
    }

    [HttpGet("quadratica/{x}")]
    public string Get(int x, int a, int b, int c)
    {
        int resultado =  a * x * x + b * x + c;
        return resultado.ToString();
    }

    [HttpGet("solucao")]
    public object Get(double a = 1, double b = 0, double c = 0)
    {
        if(a == 0)
        {
            return new{
                status = "fail",
                message = "delta não pode ser negativo"
            };
        }
    }

    {
        double delta =  Math.sqrt(b*b-4*a*c);
        double x1 = (-b + (delta)) / a;   
    }
}