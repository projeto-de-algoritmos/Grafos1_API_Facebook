using graphFacebook.Data;

namespace graphFacebook.Service
{
    public class UserService
    {
        private readonly StaticData _data;
        
        public UserService(StaticData data)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
        }

        //classe service onde será implementado todos os codigos utilizando os DataStructures e o Searching, pastas onde contem os algorimos de grafos.
        //sem que precise de uma biblioteca. 
        
    }
}
