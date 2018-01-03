using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace hw11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK1");
            task1();
            Console.WriteLine("TASK2");
            task2();
            Console.WriteLine("TASK3_4");
            task3_4();           
        }

        static void task1()
        {
            string url = "http://www.kljlkj.kz";
            WebRequest request=WebRequest.Create(url);
            try
            {
                WebResponse response = request.GetResponse();               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Отработало исключение");
            }
        }
        static void task2()
        {
            int[] x = new int[5];
            for (int i = 0; i < 10; i++)
            {               
                try
                {
                    x[i]++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;                    
                }
            }
            Console.WriteLine("Code after exception call");
        }
        static void task3_4()
        {
            try
            {
                helpMethod();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Поднятое исключение");
                Console.WriteLine(ex.Message);               
            }         
        }
        static void helpMethod()
        {

            try
            {
                int y = 0;
                int x=5 / y;
                throw new Exception(); 
            }
            catch(Exception ex)
            {
                Console.WriteLine("Исключение в вызываемом методе");
                throw ex;
            }

        }
    }
}
