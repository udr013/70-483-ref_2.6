using System;

namespace GarbageCollection
{
    class Person
    {
        long[] personArray = new long[10000];

        ~Person()
        {
            // this is the finalizer method This method gets control and can release any resources
            // that are used by the object.
            Console.WriteLine("Finalizer called");

            // this will break the garbage collection process as it slows it down so that it can't
            // complete faster than the objects are being created.
            System.Threading.Thread.Sleep(100);


        }
    }

    class Program
    {
        //run to see behavior of the garbagecollector on the memory use
        static void Main(string[] args)
        {
            for (long i = 0; 1 < 100000; i++)
            {
                Person p = new Person();
                System.Threading.Thread.Sleep(3);

                // force garbage collection
                GC.Collect();
                //GC.WaitForPendingFinalizers();

            }
            
        }
    }
}
