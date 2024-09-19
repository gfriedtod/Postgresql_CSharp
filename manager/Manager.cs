using database;
using persistence.entity;
using Zed.persistence.handler;

namespace manager;

public class Manager
{
    private UserHandler _userHandler;

    public Manager(Mydb mydb)
    {
        _userHandler = new UserHandler(mydb);
    }

    public void showAllUser()
    {
        Console.WriteLine("Id | Name");
        foreach (var user in _userHandler.read())
        {
            Console.WriteLine($" ${user.Id} | ${user.Name}");
        } 
    }

    public void addUser(User user)
    {
        _userHandler.create(user);
        Console.WriteLine("User Created successfully");
    }
}