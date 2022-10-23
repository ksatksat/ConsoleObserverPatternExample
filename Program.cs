using System;

namespace ConsoleObserverPatternExample
{
    class Program
    {
        public static void Main(String[] args)
        {
            //this called imperative programming
            //Int32 first = 10;
            //Int32 second = first;
            //System.Console.WriteLine($"{first} {second}");
            //first = 20;
            //System.Console.WriteLine($"{first} {second}");
            //output:
            //10 10
            //20 10

            //other type of programming called reactive programming
            NewsAggregator newsAggregator = new NewsAggregator();

            Reader steve = new Reader("Steve");
            Reader bill = new Reader("Bill");

            newsAggregator.Subscribe(steve);
            newsAggregator.Subscribe(bill);

            News news1 = new News("Title# 1", "Content# 1");
            News news2 = new News("Title# 2", "Content# 2");
            News news3 = new News("Title# 3", "Content# 3");

            newsAggregator.Notify(news1);
            Thread.Sleep(1000);
            newsAggregator.Notify(news2);
            Thread.Sleep(500);
            newsAggregator.Unsubscribe(bill);
            newsAggregator.Notify(news3);

            //output:
            //Steve
            //Title# 1
            //Content# 1
            //==================================
            //
            //Bill
            //Title# 1
            //Content# 1
            //==================================
            //
            //Steve
            //Title# 2
            //Content# 2
            //==================================
            //
            //Bill
            //Title# 2
            //Content# 2
            //==================================
            //
            //Steve
            //Title# 3
            //Content# 3
            //==================================
        }
    }
}