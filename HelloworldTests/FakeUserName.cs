using Helloworld;

namespace HelloworldTests
{
    internal class FakeUserName : IUserName
    {
        public string GetUserName()
        {
            return "Toto";
        }
    }
}
