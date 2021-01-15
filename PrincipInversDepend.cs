using System;

/* 
    O PID desacopla componentes de alto e baixo nível e, em vez disso, conecta ambos às abstrações.
    Os componentes de alto e baixo nível ainda podem se beneficiar uns dos outros, mas uma mudança em um não deve interromper diretamente o outro.
    A vantagem desta parte do PID é que os programas desacoplados requerem menos trabalho para serem alterados. 
    Redes de dependências em seu programa significam que uma única alteração pode afetar muitas partes separadas.
*/

public interface IAutomovel
{
    void Ignicao();
    void Pare();
}

public class Jeep : IAutomovel
{
    #region Membros IAutomovel
    public void Ignicao()
    {
        Console.WriteLine("Iniciar Jeep");
    }

    public void Pare()
    {
        Console.WriteLine("Parar Jeep");
    }
    #endregion
}

public class SUV : IAutomovel
{
    #region Membros IAutomovel
    public void Ignicao()
    {
        Console.WriteLine("Iniciar SUV");
    }

    public void Pare()
    {
        Console.WriteLine("Parar SUV");
    }
    #endregion
}

public class AutomovelController
{
    IAutomovel _automovel;

    public AutomovelController(IAutomovel automovel)
    {
        _automovel = automovel;
    }

    public void Ignicao()
    {
        _automovel.Ignicao();
    }

     public void Pare()
    {
        _automovel.Pare();
    }
}