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
    }
}
