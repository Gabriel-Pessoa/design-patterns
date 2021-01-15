/* 
   Segregar as interface significa: menos código em cada classe que ela implementa. Menos código significa menos bugs.
   Dividimos as interfaces em ITrabalhadorBase, e duas interfaces filho ISalarioTempoIntegral e ISalarioTrabalhadorContratado.
   As classes finais agora contêm apenas métodos e propriedades que promovem seu objetivo e, portanto, alcançam o princípio PIS.
*/
public interface ITrabalhadorBase
{
    string ID { get; set; }
    string Nome { get; set; }
    string Email { get; set; }
}

public interface ISalarioTempoIntegral : ITrabalhadorBase
{
    float SalarioMensal { get; set; }
    float OutrosBeneficios { get; set; }
    float CalcularSalarioLiquido();
}

public interface ISalarioTrabalhadorContratado : ITrabalhadorBase
{
    float TaxaHoraria { get; set; }
    float HorasNoMes { get; set; }
    float CalcularSalarioTrabalho();
}

public class EmpregadoTempoIntegralFixo : ISalarioTempoIntegral
{
    public string ID { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public float SalarioMensal { get; set; }
    public float OutrosBeneficios { get; set; }
    public float CalcularSalarioLiquido() => SalarioMensal + OutrosBeneficios;
}

public class EmpregadoContratoFixo : ISalarioTrabalhadorContratado
{
    public string ID { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public float TaxaHoraria { get; set; }
    public float HorasNoMes { get; set; }
    public float CalcularSalarioTrabalho() => TaxaHoraria * HorasNoMes;
}