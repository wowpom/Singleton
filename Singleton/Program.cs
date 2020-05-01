using System;
using Xceed.Wpf.Toolkit;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonExample singletonExample = SingletonExample.GetInstance();
            SingletonExample singletonExample2 = SingletonExample.GetInstance();
            if (Object.ReferenceEquals(singletonExample, singletonExample2))
                Console.WriteLine("Обе ссылки ссылаются на один объект");
        }
    }
}
