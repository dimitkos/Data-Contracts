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
        public string Street { get; set; }

        [DataMember(Name = "suite")]
        public string Suite { get; set; }

        [DataMember(Name = "city")]
        public string athina { get; set; }

        [DataMember(Name = "zipcode")]
        public string ze { get; set; }

        [DataMember(Name = "geo")]
        public Geo geo { get; set; }
    }
}
