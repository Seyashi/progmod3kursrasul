using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    class Collection
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public Collection(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public override string ToString() => $"Коллекция: {Name}, Год: {Year}";
    }

    class Album : Collection
    {
        public string Artist { get; set; }

        public Album(string name, int year, string artist) : base(name, year)
        {
            Artist = artist;
        }

        public override string ToString() => $"{base.ToString()}, Исполнитель: {Artist}";
    }

    class MusicalWork
    {
        public string Title { get; set; }
        public int Duration { get; set; }

        public MusicalWork(string title, int duration)
        {
            Title = title;
            Duration = duration;
        }

        public override string ToString() => $"Произведение: {Title}, Длительность: {Duration} мин.";
    }

    class Song : MusicalWork
    {
        public string Singer { get; set; }

        public Song(string title, int duration, string singer) : base(title, duration)
        {
            Singer = singer;
        }

        public override string ToString() => $"Песня: {Title}, Длительность: {Duration} мин., Певец: {Singer}";
    }

    class InstrumentalWork : MusicalWork
    {
        public string Instrument { get; set; }

        public InstrumentalWork(string title, int duration, string instrument) : base(title, duration)
        {
            Instrument = instrument;
        }

        public override string ToString() => $"Инструментальное: {Title}, Длительность: {Duration} мин., Инструмент: {Instrument}";
    }

    class Program
    {
        static void Main()
        {
            Collection collection = new Collection("Моя коллекция", 2024);
            Album album = new Album("Гармония", 2023, "Мияги");
            MusicalWork work = new MusicalWork("Музыка", 4);
            Song song = new Song("I Got Love", 3, "Мияги");
            InstrumentalWork instrumental = new InstrumentalWork("Мелодия", 5, "Пианино");

            Console.WriteLine(collection);
            Console.WriteLine(album);
            Console.WriteLine(work);
            Console.WriteLine(song);
            Console.WriteLine(instrumental);
            Console.ReadKey();
        }
    }
}
