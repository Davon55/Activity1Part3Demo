using DocumentFormat.OpenXml.Wordprocessing;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace UserService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        List<Users> userList = new List<Users>();
        public Service1()
        {
            Users users1 = new Users(1, "Donnell", true, 100000);
            Users users2 = new Users(2, "Mike", true, 90000);
            Users users3 = new Users(3, "John", false, 80000);
            Users users4 = new Users(4, "Sam", true, 70000);
            Users users5 = new Users(5, "Don", false, 60000);
            Users users6 = new Users(6, "Bill", true, 50000);
            Users users7 = new Users(7, "Tim", false, 40000);

            userList.Add(users1);
            userList.Add(users2);
            userList.Add(users3);
            userList.Add(users4);
            userList.Add(users5);
            userList.Add(users6);
            userList.Add(users7);


        }

        public DTO GetAllUsers()
        {
            DTO userDTO = new DTO();
            userDTO.errorMessage = "Ok";
            userDTO.errorCode = 0;
            return userDTO;
        }

        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public DTO GetUserById(string id)
        {
            DTO userDTO = new DTO();
            userDTO.errorMessage = "Ok";
            userDTO.errorCode = 0;
            return userDTO;
        }

        public DTO GetUsersByName(string name)
        {
            DTO userDTO = new DTO();
            List<Users> returnThesePeople = userList.Where(x => x.Name.ToLower().Contains(name.ToLower()).ToList()
        }
    }
}
