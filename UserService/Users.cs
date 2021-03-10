using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UserService
{
    [DataContract]
    public class Users
    {
        public Users(int id, string name, bool preferredCustomer, float income)
        {
            Id = id;
            Name = name;
            PreferredCustomer = preferredCustomer;
            this.income = income;
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool PreferredCustomer { get; set; }
        [DataMember]
        public float income { get; set; }
    }
}