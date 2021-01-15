using DesignPattern.PrincipUnicaRespons.Interfaces;

namespace DesignPattern.PrincipUnicaRespons
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioServices(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            _usuarioRepository.Persistir(usuario);
        }
    }
}