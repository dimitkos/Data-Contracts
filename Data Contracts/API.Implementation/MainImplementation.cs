using API.Interfaces;
using API.Types;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Implementation
{
    public class MainImplementation :IApiImplementation
    {

        public List<Post> GetPosts()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/posts", Method.GET);
            var queryResult = client.Get<List<Post>>(request).Data;
            return queryResult;
        }

        public List<Comment> GetComments()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/comments", Method.GET);
            var queryResult = client.Get<List<Comment>>(request).Data;
            return queryResult;
        }

        public List<Album> GetAlbums()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/albums", Method.GET);
            var queryResult = client.Get<List<Album>>(request).Data;
            return queryResult;
        }

        public List<Photo> GetPhotos()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/photos", Method.GET);
            var queryResult = client.Get<List<Photo>>(request).Data;
            return queryResult;
        }

        public List<Todo> GetTodos()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/todos", Method.GET);
            var queryResult = client.Get<List<Todo>>(request).Data;
            return queryResult;
        }

        public List<User> GetUsers()
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/users", Method.GET);
            var queryResult = client.Get<List<User>>(request).Data;
            return queryResult;
        }
    }
}
