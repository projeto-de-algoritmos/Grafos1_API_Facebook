using graphFacebook.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace graphFacebook.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController
    {
        private readonly UserService _userService;
        
        public UserController(UserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

    }
}
