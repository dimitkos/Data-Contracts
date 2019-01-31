using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API.Types
{
    [DataContract]
    public class Comment
    {
        [DataMember(Name = "postId")]
        public int postId { get; set; }

        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "email")]
        public string email { get; set; }

        [DataMember(Name = "email")]
        public string body { get; set; }
    }
}
