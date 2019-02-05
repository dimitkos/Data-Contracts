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
    public class AlbumController : ApiController
    {
        private readonly IApiImplementation MyService;

        public AlbumController(IApiImplementation MyService)
        {
            this.MyService = MyService;
        }

        [HttpGet]
        [ActionName("getAlbums")]
        public List<Album> GetAlbums()
        {
            return MyService.GetAlbums();
        }
    }
}
