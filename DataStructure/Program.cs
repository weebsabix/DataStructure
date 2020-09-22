using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack a = new Stack(10);

            try
            {
                a.Pop();
            }
            catch
            { }
        }
    }
}

