using System;

namespace Program
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var ContactA = new Contact("Viktor", "Gordeev", "Pedagogicheskaya st., ", Group.Friend, 1);

            ContactA.TelephoneNumber = "+79226356357";
            ContactA.Description = "My best friend";

            ContactA.PrintInfo();
        }
    }
}
