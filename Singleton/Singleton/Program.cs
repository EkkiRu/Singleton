using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.CreateOrGetInstance();
            singleton.ToString();
            singleton = Singleton.CreateOrGetInstance();
            singleton.ToString();
            singleton.ToString();
        }
    }
}
