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
    public class CommentController : ApiController
    {
        private readonly IApiImplementation MyService;

        public CommentController(IApiImplementation MyService)
        {
            this.MyService = MyService;
        }

        [HttpGet]
        [ActionName("getComments")]
        public List<Comment> GetComments()
        {
            return MyService.GetComments();
        }
    }
}
