using API.Implementation;
using API.Interfaces;
using API.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterConsole
{
    class Program
    {


        static void Main(string[] args)
        {
            PrintUserTree();

            Console.ReadKey();
        }

        private static void PrintUserTree()
        {

            MainImplementation service = new MainImplementation();


            List<User> Users = service.GetUsers();

            List<Post> Posts = service.GetPosts();

            List<Comment> Comments = service.GetComments();

            

            foreach (var user in Users)
            {
                Console.WriteLine("The user " + user.id + " posts:");
              
                var postlist = Posts.Where(x => x.userId == user.id).ToList();

                foreach (var item in postlist)
                {
                    Console.WriteLine("The post is: "+item.title);

                    var commentlist = Comments.Where(f => f.postId == item.id).ToList();

                    foreach (var comment in commentlist)
                    {
                        
                        Console.WriteLine("The comment is: "+comment.email);
                    }
                }

                Console.WriteLine("------------------------------------------------------------");


            }

        }
    }
}
