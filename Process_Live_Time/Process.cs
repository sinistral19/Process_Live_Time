using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Process_Live_Time
{
    class Process
    {
        public static string Process_name { get; set; }
        public static TimeSpan? Time_live { get; set; }
        public static int? Time_search { get; set; }




        


       public  static void Search_Process()
         {
            Console.WriteLine($"Начало поиска {Process_name}");
            Boolean prod_poisk = true;

             while (prod_poisk == true)
             {
                 System.Diagnostics.Process[] arry = System.Diagnostics.Process.GetProcesses();

                 foreach (System.Diagnostics.Process pr in arry)
                 {
                     if (pr.ProcessName == Process_name)
                     {

                         TimeSpan time = DateTime.Now - pr.StartTime;

                         //   pr.Close();

                         if (time > Time_live)
                         {
                             pr.Kill();

                            Thread.Sleep(2000);

                            if (System.Diagnostics.Process.GetProcessesByName(Process_name).Length> 0)
                            {
                                Console.WriteLine($"Один процесс {Process_name} завершен.В системе есть еще процессы с именем {Process_name}. Продолжить поиск?(да/нет)");
                                string con = Console.ReadLine();
                                if (con == "да")
                                {
                                    goto m1;
                                }
                                else if (con == "нет")
                                {
                                    prod_poisk = false;
                                    break;
                                }
                            }
                            else 
                            {
                                prod_poisk = false;
                                break;
                            }
                             





                        


                             //goto m1;
                         }

                     }


                     //   m1:;
                 }
           






                if (System.Diagnostics.Process.GetProcessesByName(Process_name).Length == 0)
                {
                    Console.WriteLine($"В системе нет  процессов с именем {Process_name}. Продолжить поиск?(да/нет)");
                    string con = Console.ReadLine();
                    if (con == "да")
                    {
                        goto m1;
                    }
                    else if (con == "нет")
                    {
                        prod_poisk = false;
                        
                    }
                }


            m1:;
                if (prod_poisk == true)
                {
                    //Task.Delay((int)Time_search);

                    Thread.Sleep((int)Time_search);
                }



            }
         //  res= "Проложение завершило поиск.";
            Console.WriteLine("Проложение завершило поиск.");
        }

     /*   public static async void Poisk()
            {
            string res = "";
                Console.WriteLine($"Начало поиска {Process_name}");
                await Task.Run(() => Search_Process());
         

        }*/
        }
    } 
