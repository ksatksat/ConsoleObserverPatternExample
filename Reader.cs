using System;
namespace ConsoleObserverPatternExample
{
    public sealed class Reader : IObserver<News>
    {
        public String Name {get; set;}
        public Reader(String name)
        {
            Name = name;
        }
        public void Update(News news)
        {
            System.Console.WriteLine(Name);
            System.Console.WriteLine(news.Title);
            System.Console.WriteLine(news.Content);
            System.Console.WriteLine("==================================");
            System.Console.WriteLine();
        }
    }
}