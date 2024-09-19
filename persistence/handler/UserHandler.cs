using database;
using Npgsql;
using persistence.entity;
using persistence.repository;

namespace Zed.persistence.handler;

public class UserHandler : IUserRepository
{
    private readonly Mydb _mydb;


    public UserHandler(Mydb mydb)
    {
        _mydb = mydb;
    }

    public void create(User user)
    {
        try
        {
            var command = new NpgsqlCommand($"INSERT INTO public.user (name) values ('${user.Name}')", _mydb.Connection);
            command.ExecuteScalar();
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine($"We encounted some error : ${e.Message} ");
        }
    }

    public List<User> read()
    {
        try
        {
         
            var command = new NpgsqlCommand("SELECT * FROM public.user",_mydb.Connection);
            var users = new List<User>();
            using (var dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    users.Add(new User(dataReader.GetInt32(0), dataReader.GetString(2)));
                }
 
            }


            return users;
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine($"We encounted some error : ${e.Message} ");
        }

        return null!;
    }

    public User readById(int id)
    {
        try
        {
            var command = new NpgsqlCommand($"SELECT * FROM public.user where id=${id}");
            var users = new List<User>();
            var dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
            }

            {
                users.Add(new User(dataReader.GetInt32(0), dataReader.GetString(1)));
            }
            return users.First();
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine($"We encounted some error : ${e.Message} ");
            return null!;
        }
    }

    public void update(User user)
    {
        try
        {
            var command = new NpgsqlCommand($"UPDATE public.user SET name=${user.Name}");
            command.ExecuteScalar();
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine($"We encounted some error : ${e.Message} ");
        }
    }

    public void delete(int id)
    {
        try
        {
            var command = new NpgsqlCommand($"DELETE FROM public.user WHERE id=${id}");
            command.ExecuteScalar();
        }
        catch (NpgsqlException e)
        {
            Console.WriteLine($"We encounted some error : ${e.Message} ");
            throw;
        }
    }
}