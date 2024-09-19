using database;
using persistence.entity;

namespace persistence.repository;

public interface IUserRepository: ICrudRepository<int,User>
{
    
}