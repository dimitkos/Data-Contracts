using System;
using System.Collections.Generic;
using API.Implementation;
using API.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPosts()
        {
            MainImplementation service = new MainImplementation();
            List<Post> postlist = service.GetPosts();

            //h lista epistrefei 100 posts
            Xunit.Assert.True(postlist.Count == 100);

        }

        [TestMethod]
        public void GetComments()
        {
            MainImplementation service = new MainImplementation();
            List<Comment> commentlist = service.GetComments();

            //h lista epistrefei 500 comments
            Xunit.Assert.True(commentlist.Count == 500);

        }

        [TestMethod]
        public void GetAlbums()
        {
            MainImplementation service = new MainImplementation();
            List<Album> albumlist = service.GetAlbums();

            //h lista epistrefei 100 albums
            Xunit.Assert.True(albumlist.Count == 100);

        }

        [TestMethod]
        public void GetPhotos()
        {
            MainImplementation service = new MainImplementation();
            List<Photo> photolist = service.GetPhotos();

            //h lista epistrefei 5000 photos
            Xunit.Assert.True(photolist.Count == 5000);

        }

        [TestMethod]
        public void GetTodos()
        {
            MainImplementation service = new MainImplementation();
            List<Todo> todolist = service.GetTodos();

            //h lista epistrefei 200 todos
            Xunit.Assert.True(todolist.Count == 200);

        }

        [TestMethod]
        public void GetUsers()
        {
            MainImplementation service = new MainImplementation();
            List<User> userlist = service.GetUsers();

            //h lista epistrefei 10 users
            Xunit.Assert.True(userlist.Count == 10);

        }
    }
}
