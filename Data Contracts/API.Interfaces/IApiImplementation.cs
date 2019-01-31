using API.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IApiImplementation 
    {
        List<Post> GetPosts();

        List<Comment> GetComments();

        List<Album> GetAlbums();

        List<Photo> GetPhotos();

        List<Todo> GetTodos();

        List<User> GetUsers();

    }
}
