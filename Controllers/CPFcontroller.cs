using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("cpf/")]
public class CpfController : ControllerBase
{
    [HttpGet("validate/{cpf}")]
    public object Validate(
        [FromServices]CpfService cpfService,
        string cpf)
    {
        throw new NotImplementedException();
    }

    [HttpGet("generate")]
    public object Generate(
        [FromServices]CpfService cpfService
    )
    {
        throw new NotImplementedException();
    }
}
    /*
    [HttpGet("Generate")]
    public object Generate(
        [FromService] cpfService, cpfService)
    {

        public static GerarCpf()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] = {10,9,8,7,6,5,4,3,2};
            int[] multiplicador2 = new int[10] = {11,10,9,8,7,6,5,4,3,2};

            Random rnd = new Random();
            string semente = rnd.Next(1000000000, 9999999999).ToString();

        }
        throw new NotImplementedException();
    }
    */
