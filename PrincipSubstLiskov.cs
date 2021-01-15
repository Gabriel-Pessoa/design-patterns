/* O princípio diz que qualquer classe deve ser diretamente substituível por qualquer uma de suas subclasses sem erros.
   Cada subclasse deve manter todo o comportamento da classe base junto com quaisquer novos comportamentos exclusivos da subclasse.
   A vantagem do PSL é que ele acelera o desenvolvimento de novas subclasses, pois todas as subclasses do mesmo tipo compartilham um uso consistente.
   Você pode confiar que todas as subclasses recém-criadas funcionarão com o código existente. Se você decidir que precisa de uma nova subclasse, 
   poderá criá-la sem refazer o código existente.
   A maioria das implementações de LSP envolve polimorfismo para criar um comportamento específico de classe para as mesmas chamadas.
*/

public abstract class Fruta
{
    public abstract string ObterCor();
}
public class Maca : Fruta
{
    public override string ObterCor()
    {
        return "Vermelho";
    }
}
public class Laranja : Fruta
{
    public override string ObterCor()
    {
        return "Laranja";
    }
}