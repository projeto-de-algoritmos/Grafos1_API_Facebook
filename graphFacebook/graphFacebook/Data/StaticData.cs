using graphFacebook.Entities;

namespace graphFacebook.Data
{
    public class StaticData
    {
        public List<User> UserStaticData { get; set; }
        public StaticData()
        {
            UserStaticData = new List<User>();
            var persona1 = new User("Fulano de tal", "", new List<int> { });
            var persona2 = new User("Fulano de tal", "", new List<int> { persona1.Id });
            var persona3 = new User("Fulano de tal", "", new List<int> { });
            var persona4 = new User("Fulano de tal", "", new List<int> { });
            var persona5 = new User("Fulano de tal", "", new List<int> {persona3.Id, persona1.Id });

            UserStaticData.Add(persona1);
            UserStaticData.Add(persona2);
            UserStaticData.Add(persona3);
            UserStaticData.Add(persona4);
            UserStaticData.Add(persona5);   
        }
    }
}
