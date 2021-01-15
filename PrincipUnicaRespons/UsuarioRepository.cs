using DesignPattern.DB;
using DesignPattern.PrincipUnicaRespons.Interfaces;

namespace DesignPattern.PrincipUnicaRespons
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Persistir(Usuario usuario)
        {   
            DataBase dataBase = DataBase.ObterInstancia();       

            dataBase.AddUsuario(usuario);
        }
    }
}