using System;
using CookComputing.XmlRpc;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = XmlRpcProxyGen.Create<IIsEven>();
            
            var x = proxy.is_even(4);
            Console.WriteLine(x);

            var y = proxy.add(4,5);
            Console.WriteLine(y);


            Console.ReadLine();
        }
    }
}
