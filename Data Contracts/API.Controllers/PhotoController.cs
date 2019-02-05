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
    public class PhotoController : ApiController
    {
        private readonly IApiImplementation MyService;

        public PhotoController(IApiImplementation MyService)
        {
            this.MyService = MyService;
        }

        [HttpGet]
        [ActionName("getPhotos")]
        public List<Photo> GetPhotos()
        {
            return MyService.GetPhotos();
        }
    }
}
