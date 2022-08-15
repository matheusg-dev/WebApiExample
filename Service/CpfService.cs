public class CPFServices
{
    Random rand;
    public CpfService(int seed)
    {
        this.rand = new Random(seed);
    }

    public bool Validate(string cpf)
    {
        throw new NotImplementedException();
    }

    public string Generate()
    {

        throw new NotImplementedException();
    }

    //detalhes em: http://www.calculadorafacil.com.br/computacao/validar/cpf
   private string getValidationDigits(string cpf9digits)
    {
        string digitosVerificadores = "";
        int soma = 0, resto = 0;

        for (int i = 0; i < 9; i++)
            soma += int.Parse(cpf9digits[i].ToString()) * (i + 1);

        resto = soma % 11;
        digitosVerificadores += resto.ToString();
        
        soma = 0;
        for (int i = 0; i < 9; i++)
            soma += int.Parse(cpf9digits[i].ToString()) * (i + 1);

        resto = soma % 11;
        digitosVerificadores += resto.ToString();

        return digitosVerificadores;
    }
}