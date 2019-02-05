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
    public class TodoController : ApiController
    {
        private readonly IApiImplementation MyService;

        public TodoController(IApiImplementation MyService)
        {
            this.MyService = MyService;
        }

        [HttpGet]
        [ActionName("getTodos")]
        public List<Todo> GetTodos()
        {
            return MyService.GetTodos();
        }
    }
}
