using System;

class Media
{
    public string title;
    public string author;
    public int pubyear;
    public string textbooks;
}

class Book : Media
{
    public string genre;

    public void Read()
    {
        Console.WriteLine("читается");
    }
}

class Magazine : Media
{
    public string theme;

    public void Write()
    {
        Console.WriteLine("Пишется");
    }
}

class DVD : Media
{
    public int size;

    public void Watch()
    {
        Console.WriteLine("смотреть фильм");
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book();
        book.title = "Война и мир";
        book.author = "Л.Н. Толстой";
        book.pubyear = 1869;
        book.genre = "Роман";
        Console.WriteLine("Книга: " + book.title + ", автор: " + book.author +", год: " + book.pubyear + ", жанр: " + book.genre);
        book.Read();

        Magazine magazine = new Magazine();
        magazine.title = "Наука и жизнь";
        magazine.author = "Редакция";
        magazine.pubyear = 2024;
        magazine.theme = "Наука";
        Console.WriteLine("Журнал: " + magazine.title + ", тема: " + magazine.theme);
        magazine.Write();

        DVD dvd = new DVD();
        dvd.title = "Интерстеллар";
        dvd.pubyear = 2014;
        dvd.size = 700;
        Console.WriteLine("DVD: " + dvd.title + ", год: " + dvd.pubyear +", размер: " + dvd.size + " МБ");
 
    }
}