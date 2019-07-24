using System;

namespace Stealer
{
    public class Program
    {
        static void Main(string[] args)
        {

            Spy spy = new Spy();
            string res = spy.CollectGettersAndSetters("Hacker");
            Console.WriteLine(res);
        }
    }
}
