namespace graphFacebook.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public List<int> Conexoes { get; set; }

        private static int _id = 1;
        public User(string nome, string idade, List<int> conexoes)
        {
            this.Id = User._id++;
            this.Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.Idade = idade ?? throw new ArgumentNullException(nameof(idade));
            this.Conexoes = conexoes ?? throw new ArgumentNullException(nameof(conexoes));
        }
    }
}
