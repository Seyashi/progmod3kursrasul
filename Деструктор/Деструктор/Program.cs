using System.Runtime.InteropServices.Marshalling;

class Napitok
{
    public Napitok()
    {
        Console.WriteLine("Создан экземпляр класса");
    }
    ~Napitok()
    {
        Console.WriteLine("Уничтожен экземпляр класса");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Details();
        Console.ReadLine();
    }
public static void Details()
{
    //Crerated instance of the class
    Napitok user = new Napitok();
}
}
