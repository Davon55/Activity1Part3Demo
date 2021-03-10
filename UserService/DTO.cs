using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UserService
{
    [DataContract]
    public class DTO
    {

        [DataMember]
        public int errorCode { get; set; }
        [DataMember]
        public string errorMessage { get; set; }
        [DataMember]
        public List<Users> usersList { get; set; }
    }
}