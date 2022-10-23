using System;
namespace ConsoleObserverPatternExample
{
    public sealed class News
    {
        public String Title { get; }
        public String Content { get; }
        public News(String title, String content)
        {
           Title = title;
           Content = content; 
        }
    }
}