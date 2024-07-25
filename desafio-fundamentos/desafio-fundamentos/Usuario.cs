namespace desafio_fundamentos;

public class Usuario
{
    public string nome { get; set; }
    public string sobrenome { get; set; }

    public void bemVindo()
    {

        Console.WriteLine("Digite seu primeiro nome:");
        nome = loopingUsuario("Digite seu primeiro nome válido");
        Console.WriteLine("Digite seu sobrenome:");
        sobrenome = loopingUsuario("Digite seu sobrenome válido");
        Console.WriteLine($"Olá, {nome} {sobrenome}! Seja muito bem vindo!");
    }

    private string loopingUsuario(string msgDadoInvalido)
    {
        bool msgExibida = false;
        do
        {
            string dadoDoUsuario = Console.ReadLine().Trim();
            if (dadoDoUsuario != "")
            {
                msgExibida = true;
                return dadoDoUsuario;
            }
            else Console.WriteLine(msgDadoInvalido);
        } while (!msgExibida);

        return null;
    }
}
