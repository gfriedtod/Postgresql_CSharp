// See https://aka.ms/new-console-template for more information

using database;
using manager;

public class Program
{
   
    
    
    
    public static void Main()
    {
     Mydb _mydb = new Mydb(
        "6543",
        "postgres",
        "PV9zI5PEdPBMsJVV",
        "postgres.yrnugzcgcqtxcjvdggti",
        "aws-0-eu-central-1.pooler.supabase.com"
    );


    Manager _manager = new Manager(_mydb);
    View view = new View(_manager);
    
    view.start();

        
    }
}