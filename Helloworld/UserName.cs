using System;

namespace Helloworld
{
    internal class UserName : IUserName
    {
        public string GetUserName()
        {
            return Environment.UserName.Replace(".", " ");
        }
    }
}
