using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cars = new List<string>();

            //var car1 = "bmv";
            //var car2 = "lada";
            //var car3 = "ferrari";
            //var car4 = "mercedes";
            //var car5 = "opel";
            //var car6 = "saab";

            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);
            //cars.Add(car4);
            //cars.Add(car5);
            //cars.Add(car6);

            //var cars = new List<string> { "bmv", "lada", "ferrari", "mercedes", "opel", "saab" };
            //for (int index = 0; index < cars.Count; index++)
            //{
            //    Console.WriteLine(cars[index]);
            //}
            //Console.WriteLine();

            //var humans1 = new List<Human>
            //{
            //    new Human(){Name="Kalle",Age=30},
            //    new Human(){Name="Malle",Age=25},
            //    new Human(){Name="Elmar",Age=27},
            //    new Human(){Name="Mart",Age=21},
            //    new Human(){Name="Mari",Age=30}
            //};
            //var human1 = new Human();
            //human1.Name = "Priit";
            //human1.Age = 25;
            //humans1.Add(human1);

            //int eh = 1;
            //while (eh == 1)
            //{
            //    var human2 = new Human();
            //    Console.WriteLine("Sisestage nimi");
            //    human2.Name = Console.ReadLine();
            //    Console.WriteLine("Sisestage vanus");
            //    human2.Age = int.Parse(Console.ReadLine());
            //    humans1.Add(human2);
            //    Console.WriteLine("Kas soovite veel lisada(yes/no)");
            //    string answer1 = Console.ReadLine();
            //    if (answer1 == "no")
            //    {
            //        eh = eh + 1;
            //    }
            //    else
            //    {

            //    }
            //}
            //Console.ReadLine();

            //foreach (var item in humans1)
            //{
            //    Console.WriteLine(item.Name+" "+item.Age);
            //}

            //Console.WriteLine();

            var openWith = new Dictionary<string, string>();
            //            key       value
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("jpg", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            openWith["rtf"] = "winword.exe";
            openWith["doc"] = "winword.exe";
            try
            {
                openWith.Add("txt", "notepad.exe");
            }
            catch (ArgumentException ex)
            {
                //throw ex;
                Console.WriteLine("If you're seeing this error,then you really fucked up\n\nbtw, an element with key \"txt\" already exists");
            }
            Console.WriteLine();
            Console.WriteLine("For key=rtf,value={0} ", openWith["txt"]);
            Console.WriteLine("For key=doc,value={0} ", openWith["doc"]);
            try
            {
                Console.WriteLine("For key=tif,value={0} ", openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key \"tif\" is not found");
            }

            string value = "";
            if (openWith.TryGetValue("tif",out value))
            {
                Console.WriteLine("For key \"tif\", value={0}",value);
            }
            else
            {
                Console.WriteLine("Key \"tif\" is not found");
            }

            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hyperterm.exe");
                Console.WriteLine("Value added for key ht:{0}",openWith["ht"]);
                
            }

            Console.ReadLine();
        }
    }
}
