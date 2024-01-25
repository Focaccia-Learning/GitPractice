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

            //狀況一:這版是origin/master
            Console.WriteLine($"Hello World!{user.Account}，我是origin/master");
            //狀況二:這是有勾追蹤遠端分支 看有甚麼差異
            Console.WriteLine($"追蹤遠端分支 Checked!!!");
            //先Update到localmaster //差異應該就只差在後面多一段文字以後都開好了 比較好看
            
            //2024-01-25 重新送出一次
        }
    }
}
