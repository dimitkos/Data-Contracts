using API.Interfaces;
using API.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace API.Controllers
{
    public class UserController : ApiController
    {
        private readonly IApiImplementation MyService;

        public UserController(IApiImplementation MyService)
        {
            this.MyService = MyService;
        }

        [HttpGet]
        [ActionName("getUsers")]
        public List<User> GetUsers()
        {
            return MyService.GetUsers();
        }
    }
}
