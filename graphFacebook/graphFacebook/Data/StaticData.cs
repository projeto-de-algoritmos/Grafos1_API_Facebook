using graphFacebook.Entities;
//essa parte aqui por enquanto será ignorada apesar de certa 
namespace graphFacebook.Data
{
    public class StaticData
    {
        public List<User> UserStaticData { get; set; }

        User persona1 = new User("", "", new List<int> { });
        User persona2 = new User("", "", new List<int> { });
        User persona3 = new User("", "", new List<int> { });
        User persona4 = new User("", "", new List<int> { });
        User persona5 = new User("", "", new List<int> { });

        public StaticData()
        {

            persona1.Nome = "teste";
            persona1.Idade = "teste";
            persona1.Conexoes = new List<int> { persona2.Id, persona3.Id, persona4.Id };

            persona2.Nome = "teste";
            persona2.Idade = "teste";
            persona2.Conexoes = new List<int> { persona1.Id, persona3.Id };

            persona3.Nome = "teste";
            persona3.Idade = "teste";
            persona3.Conexoes = new List<int> { persona1.Id, persona2.Id, persona5.Id };

            persona4.Nome = "teste";
            persona4.Idade = "teste";
            persona4.Conexoes = new List<int> { persona1.Id, persona5.Id };

            persona5.Nome = "teste";
            persona5.Idade = "teste";
            persona5.Conexoes = new List<int> { persona4.Id, persona3.Id };



            UserStaticData = new List<User>();
           
            UserStaticData.Add(persona1);
            UserStaticData.Add(persona2);
            UserStaticData.Add(persona3);
            UserStaticData.Add(persona4);
            UserStaticData.Add(persona5);   
        }
    }
}
