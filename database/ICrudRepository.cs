namespace database;

/*
 * creation d'une interface generique pour la gestion d'operation crud au
 * seins de notre application
 */
public interface ICrudRepository<T, Entity>
{
    void create(Entity obj);
    List<Entity> read();
    Entity readById(T id);
    void update(Entity obj);
    void delete(T id);
}