using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("CPF/")]
public class CPFController : ControllerBase
{
    [HttpGet("validate/{cpf}")]
    public object Validate
    ([FromService] cpfService, cpfService,
    string cpf)
    {
        throw new NotImplementedException();
    }

    [HttpGet("Generate")]
    public object Generate(
        [FromService] cpfService, cpfService)
    {

        throw new NotImplementedException();
    }
}