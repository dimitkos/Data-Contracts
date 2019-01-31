using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace API.Types
{
    [DataContract]
    public class Photo
    {
        [DataMember]
        public int albumId { get; set; }

        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string title { get; set; }

        [DataMember]
        public string url { get; set; }

        [DataMember]
        public string thumbnailUrl { get; set; }
    }
}
