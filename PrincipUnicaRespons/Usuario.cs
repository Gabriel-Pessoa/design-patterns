namespace DesignPattern.PrincipUnicaRespons
{
    // Principio da Responsabilidade Única de Classe

    //Errado
    /*
    public class Usuario
    {
        public string Nome { get; private set; }
        public string Email { get; set; }

        public Usuario(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        // Classe usuário não precisa saber como persistir no db
        // Sql deve ser encapsulado, a classe não deve saber como 
        public void PersistirUsuario()
        {
            //SqlConnection conexao = new SqlConnection("string de conexao");
            //SqlCommand cmd = new SqlCommand();
            // cmd.CommandText...
            // ...
            // ..
            //conexao.Close();
        }
        */

    // Certo: Respeitando o princípio de responsabilidade única das classes
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Usuario(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
    }

}