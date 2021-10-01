using System;
using Process_Live_Time;
namespace Process_Live_Time
{
    class Program
    {
        static void Main(string[] args)
        {

              if (args[0] != "arg1")
              {
                Process.Process_name = args[0];
                Process.Time_live = new TimeSpan(0, Convert.ToInt32(args[1]), 0);
                Process.Time_search = Convert.ToInt32(args[2])*(60000);
              }


           

            if (args[0]=="arg1"){

                Process.Process_name = "notepad";
                Process.Time_live = new TimeSpan(0, 1, 0);
                Process.Time_search = (6000);
            }

        Process.Search_Process();
            /*
                        Console.WriteLine("Для завершения работы нажмите esc.");

                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                        {
                            Environment.Exit(0);
                        }
                        */


            Console.WriteLine();

        }
    }
}
