using Models;

namespace Task01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            UserDataBase.AddUser(new User("1", "Stefan", "35"));
            UserDataBase.AddUser(new User("2", "Marko", "32"));
            UserDataBase.AddUser(new User("3", "Lence", "12"));
            UserDataBase.AddUser(new User("4", "Stefani", "21"));
            UserDataBase.AddUser(new User("5", "Aco", "23"));

            Console.WriteLine("Enter the user ID, name, or age you want to find:");
            var userSearch = Console.ReadLine().ToLower();

            List<User> searchResults = UserDataBase.Search(userSearch);

            Console.WriteLine("Search Results:");
            foreach (var user in searchResults)
            {
                Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
            }
        }
    }
}
