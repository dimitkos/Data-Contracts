using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API.Types
{
    [DataContract]
    public class User
    {
        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "username")]
        public string username { get; set; }

        [DataMember(Name = "email")]
        public string email { get; set; }

        [DataMember(Name = "address")]
        public Address address { get; set; }

        [DataMember(Name = "phone")]
        public string phone { get; set; }

        [DataMember(Name = "website")]
        public string website { get; set; }

        [DataMember(Name = "company")]
        public Company company { get; set; }

        [DataMember(Name = "posts")]
        public List<Post> Posts;
    }
}
