using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API.Types
{
    [DataContract]
    public class Company
    {
        [DataMember(Name = "name")]
        public string name { get; set; }

        [DataMember(Name = "catchPhrase")]
        public string phrase { get; set; }

        [DataMember(Name = "bs")]
        public string bs { get; set; }
    }
}
