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
    public object Get(
        double a = 1, double b = 0, double c = 0)
    {
        if(a == 0)
        {
            return new{
                status = "fail",
                message = "'a' não pode ser zero."
            };
        }

        double x1 = (-b + math.sqrt(delta)) / a;
        double x2 = (-b - Math.Sqrt(delta)) / a;

        return new{
            status = "sucesso";
            solucao1 = x1,
            solucao2 = x2
        };

   }

}