public class CPFServices
{
    public CpfService(int seed)
    {
        this.rand = new Random(seed);
    }
    Random rand;

    public bool validate(string cpf)
    {
        throw new NotImplementedException();
    }
    public string Generate()
    {
        throw new NotImplementedException();
    }

    //detalhes em: http://www.calculadorafacil.com.br/computacao/validar/cpf
    private string getvalidationDigits(string cpf)
    {
        throw newImplementedException();
    }
}