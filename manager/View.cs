using persistence.entity;

namespace manager;

public class View
{
    private Manager _manager;

    public View(Manager manager)
    {
        _manager = manager;
    }

    public void start()
    {
        Console.WriteLine("Hello Zed welcome to this beta of db test ");
        while (true)
        {
           
            Console.WriteLine("--------------------- MENU ------------------------");
            Console.WriteLine("1. show all users");
            Console.WriteLine("2. add user");
            string? choice = Console.In.ReadLine();
            switch (choice)
            {  
                case "1":
                    _manager.showAllUser();
                    break;
                case "2":
                    Console.WriteLine("enter name");
                    string? name = Console.ReadLine();
                    
                    _manager.addUser(new User(0,name));
                    break;
                default:
                    Console.WriteLine("Bad Number");
                    break;
                
            }
        }
       
    }
}