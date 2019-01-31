using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API.Types
{
    [DataContract]
    public class Geo
    {
        [DataMember(Name = "lat")]
        public string lat { get; set; }

        [DataMember(Name = "lng")]
        public string lng { get; set; }
    }
}
