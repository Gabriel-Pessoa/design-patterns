using System.Collections.Generic;
using DesignPattern.PrincipUnicaRespons;

namespace DesignPattern.DB
{
    public class DataBase
    {
        private DataBase() { }

        private static DataBase _instancia;

        public static DataBase ObterInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new DataBase();
            }
            return _instancia;
        }

        // Props e Métodos
        private List<Usuario> _Data = new List<Usuario>();

        public void AddUsuario(Usuario usuario)
        {
            _Data.Add(usuario);
        }

        public List<Usuario> ObterUsuarios()
        {
            return _Data;
        }
    }
}