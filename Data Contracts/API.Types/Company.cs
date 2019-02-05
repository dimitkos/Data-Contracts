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
        public string Name { get; set; }

        [DataMember(Name = "catchPhrase")]
        public string catchPh { get; set; }

        [DataMember(Name = "bs")]
        public string Bs { get; set; }
    }
}
