using System;

namespace Raymon
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.GetUsers(user.CreateUsers());
        }
    }
}
