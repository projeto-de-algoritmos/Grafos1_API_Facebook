namespace graphFacebook.Entities
{
    // classe responsavel por iniciar a camada de dados da aplicação 
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public List<int> Conexoes { get; set; } //Um tipo especifico do c#  != de um vetor ele consegue guardar objetos e tem uma gama de funções que permitem o manejo de maneira mais simploria

        private static int _id = 1;
        public User(string nome, string idade, List<int> conexoes)
        {
            // construtor padrão que faz o alto incremento do ID uma má pratica que foi feita não foi deixar o set private já que a propria classe já o implementa 
            this.Id = User._id++;
            this.Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.Idade = idade ?? throw new ArgumentNullException(nameof(idade));
            this.Conexoes = conexoes ?? throw new ArgumentNullException(nameof(conexoes));
        }
    }
}
