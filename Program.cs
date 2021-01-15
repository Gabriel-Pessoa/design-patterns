using System;
using DesignPattern.DB;
using DesignPattern.PrincipUnicaRespons;
using DesignPattern.PrincipUnicaRespons.Interfaces;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Princ. Respons. Unica
            
            UsuarioRepository repository = new UsuarioRepository();
            UsuarioServices services = new UsuarioServices(repository);
            services.AdicionarUsuario(new Usuario("Gabriel Pessoa", "gabriel@gmail.com"));
            services.AdicionarUsuario(new Usuario("Ytallo Pessoa", "ytallo@gmail.com"));

            DataBase dataBase = DataBase.ObterInstancia();
            dataBase.ObterUsuarios().ForEach(elem =>
            {
                Console.WriteLine($"Nome = {elem.Nome}, Email: {elem.Email}");
            });


            //Princ. Aberto/Fechado

            Retangulo retangulo = new Retangulo() { Altura = 10, Largura = 5 };
            Circulo circulo = new Circulo() { Raio = 5 };
            Console.WriteLine(retangulo.Area());
            Console.WriteLine(circulo.Area());

           

            //PrincipInversDepend

            IAutomovel automovel = new Jeep();
            // IAutomovel automovel = new SUV();
            AutomovelController automovelController = new AutomovelController(automovel);
            automovel.Ignicao();
            automovel.Pare();
        }
    }
}
