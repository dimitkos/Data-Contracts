using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;



namespace API.Types
{
    [DataContract]
    public class Post
    {
        [DataMember(Name = "userId")]
        public int userId { get; set; }

        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "title")]
        public string title { get; set; }

        [DataMember(Name = "body")]
        public string body { get; set; }

        public List<Comment> Comments { get; set; }

    }
}
