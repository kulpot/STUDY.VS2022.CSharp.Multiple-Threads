using System;
using System.Threading;

//ref link:https://www.youtube.com/watch?v=8Ji3C_x6r1U&list=PLRwVmtr-pp06KcX24ycbC-KkmAISAFKV5&index=5
// Threading -

class MainClass
{
    static void Main()
    {
        for (int i = 0; i < 8; i++)
        {
            var thread = new Thread(DifferentMethod);
            thread.Start(i);
        }
        /*var thread = new Thread(DifferentMethod);
        thread.Start();
        while (true)
            Console.WriteLine("Hello from Main()");*/
    }
    static void DifferentMethod(object threadID)
    {
        while(true)
            Console.WriteLine("Hello from different method: " + threadID);
    }
}