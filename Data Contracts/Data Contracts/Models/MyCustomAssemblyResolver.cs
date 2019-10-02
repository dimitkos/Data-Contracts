using API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http.Dispatcher;

namespace Data_Contracts.Models
{
    public class MyCustomAssemblyResolver : DefaultAssembliesResolver
    {
        public override ICollection<Assembly> GetAssemblies()
        {
            ICollection<Assembly> baseAssemblies = base.GetAssemblies();
            List<Assembly> assemblies = new List<Assembly>(baseAssemblies);

            //Type newType = typeof(PostController);
            //Type commentType = typeof(CommentController);
            //Type albumType = typeof(AlbumController);
            
            //var newcontrollersAssembly = Assembly.GetAssembly(newType);
            //var commentcontrollerAssembly = Assembly.GetAssembly(commentType);
            //var albumcontrollerAssembly = Assembly.GetAssembly(albumType);

            //baseAssemblies.Add(newcontrollersAssembly);
            //baseAssemblies.Add(commentcontrollerAssembly);
            //baseAssemblies.Add(albumcontrollerAssembly);

            return assemblies;
        }
    }

}