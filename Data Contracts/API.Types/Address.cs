using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API.Types
{
    [DataContract]
    public class Address
    {
        [DataMember(Name = "street")]
        public string street { get; set; }

        [DataMember(Name = "suite")]
        public string suite { get; set; }

        [DataMember(Name = "city")]
        public string city { get; set; }

        [DataMember(Name = "zipcode")]
        public string code { get; set; }
    }
}
