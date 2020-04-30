using GitPractice.Model;
using System;

namespace GitPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            UserAccount user = new UserAccount()
            {
                ID = 1,
                Account = "david",
                Email = "davidchiu@a123.com",
                UserName = "David",
                Password = "test"
            };

            //狀況一:這版是本機的master
            Console.WriteLine($"Hello World!{user.Account}，我是本機master");
        }
    }
}
