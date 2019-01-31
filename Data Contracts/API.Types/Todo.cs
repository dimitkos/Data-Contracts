using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API.Types
{
    [DataContract]
    public class Todo
    {
        [DataMember(Name = "userId")]
        public int userId { get; set; }

        [DataMember(Name = "id")]
        public int id { get; set; }

        [DataMember(Name = "title")]
        public string title { get; set; }

        [DataMember(Name = "completed")]
        public bool completed { get; set; }
    }
}

