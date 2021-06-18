using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raymon
{
    public class User
    {
        List<User> Users;
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<User> CreateUsers()
        {
            Users = new List<User>()
            {
                new User()
                {
                    FirstName = "Pedram",
                    LastName = "Yamini"
                },
                new User()
                {
                    FirstName = "Ali",
                    LastName = "Ahmadi"
                }
            };
            return Users;
        }

        public void GetUsers(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}");
            }
        }
    }
}
