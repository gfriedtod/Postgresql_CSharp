using System.Security.Principal;
using database;

namespace persistence.entity;

public class User : IEntity
{
    private long id;

    public long Id
    {
        get => id;
        set => id = value;
    }

    private String name;

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }


    public User(long id, string name)
    {
        this.id = id;
        this.name = name;
    }
}