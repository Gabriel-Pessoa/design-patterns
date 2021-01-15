using System;

// Principio aberto/fechado. Aberto a expansão, fechado a alteração
// Nota-se que se o paralelograma for outro, iremos modificar a classe, quebrando o princípio

/* Errado
class Paralelograma
{
      public int Area(int largura, int comprimento, string tipo)
      {
      if(tipo == "retangulo")
         return largura * comprimento;
      else if(tipo == "quadrado")
         return largura * largura;
      else
         return -1;
   }
}*/

// Certo
// Foi criada uma clase abstrata, onde todos podem herdar.
// Agora, cada subtipo de forma lida com seu próprio cálculo de área por meio de polimorfismo.
// Isso é melhor, porque estruturamos o código para que seja mais fácil de estender e mais difícil de modificar.
public abstract class Forma
{
    public abstract double Area();
}

public class Retangulo : Forma
{
    public double Largura { get; set; }
    public double Altura { get; set; }
    public override double Area()
    {
        return Largura * Altura;
    }
}

public class Circulo : Forma
{
    public double Raio { get; set; }
    public override double Area()
    {
        return Raio * Raio * Math.PI;
    }
}
