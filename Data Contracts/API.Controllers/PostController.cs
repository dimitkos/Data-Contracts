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
    public class PostController : ApiController
    {
        private readonly IApiImplementation MyService;

        public PostController(IApiImplementation MyService)
        {
            this.MyService = MyService;
        }

        [HttpGet]
        [ActionName("getPosts")]
        public List<Post> GetPosts()
        {
            return MyService.GetPosts();
        }
    }
}
