namespace SoloLearn
{
    class Program
    { 
  class Device
{
    protected string Brand { get; set; }
    protected string Model { get; set; }
}
class Phone:Device
{
    public Phone (string brand,string model)
    {
        Brand = brand;
        Model = model;
    }
public void Call()
    {
        Console.WriteLine("Звонок с телефона" + Brand + " " + Model);
    }
}

static void Main(string[]args)
{
    Phone phone = new Phone("Samsung", "Galaxy A54");
}
}
}