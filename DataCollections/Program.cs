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
            #region List<>
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
            #endregion

            #region Dictionary
            //var openWith = new Dictionary<string, string>();
            ////            key       value
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("jpg", "paint.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //openWith["rtf"] = "winword.exe";
            //openWith["doc"] = "winword.exe";
            //try
            //{
            //    openWith.Add("txt", "notepad.exe");
            //}
            //catch (ArgumentException ex)
            //{
            //    //throw ex;
            //    Console.WriteLine("If you're seeing this error,then you really fucked up\n\nbtw, an element with key \"txt\" already exists");
            //}
            //Console.WriteLine();
            //Console.WriteLine("For key=rtf,value={0} ", openWith["txt"]);
            //Console.WriteLine("For key=doc,value={0} ", openWith["doc"]);
            //try
            //{
            //    Console.WriteLine("For key=tif,value={0} ", openWith["tif"]);
            //}
            //catch (KeyNotFoundException)
            //{
            //    Console.WriteLine("Key \"tif\" is not found");
            //}

            //string value = "";
            //if (openWith.TryGetValue("tif",out value))
            //{
            //    Console.WriteLine("For key \"tif\", value={0}",value);
            //}
            //else
            //{
            //    Console.WriteLine("Key \"tif\" is not found");
            //}

            ////vaatame kas ht võti on olemas,kui ei ole,lisame selle
            //if (!openWith.ContainsKey("ht"))
            //{
            //    openWith.Add("ht", "hyperterm.exe");
            //    Console.WriteLine("Value added for key ht:{0}",openWith["ht"]);

            //}
            //Console.WriteLine();
            ////küsime võtmed ja väärtused kasutades foreach tsüklit
            //foreach (KeyValuePair<string,string> kvp in openWith)
            //{
            //    Console.WriteLine("Key = {0},Value ={1}", kvp.Key,kvp.Value);
            //}

            ////küsime väärtused
            //Dictionary<string, string>.ValueCollection valueCollection = openWith.Values;

            //foreach (string item in valueCollection)
            //{
            //    Console.WriteLine("Value={0}",item);
            //}

            ////küsime võtmed
            //Dictionary<string, string>.KeyCollection keyCollection = openWith.Keys;
            //foreach (var item in keyCollection)
            //{
            //    Console.WriteLine("Key={0}",item);
            //}

            ////kustutame võtme/väärtuse
            //openWith.Remove("doc");
            //if (!openWith.ContainsKey("doc"))
            //{
            //    Console.WriteLine("Key\"doc\" not found");
            //}
            #endregion

            #region Queue - First in first out(FIFO)
            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("one");
            //numbers.Enqueue("two");
            //numbers.Enqueue("three");
            //numbers.Enqueue("four");
            //numbers.Enqueue("five");

            ////küsime elemendid järjekorras
            //foreach(string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            ////võtame välja esimese elemendi
            //Console.WriteLine("\nDequeuing '{0}'",numbers.Dequeue());

            ////piilume järgmist elementi
            //Console.WriteLine("Peek at next item to dequeue:{0}", numbers.Peek());

            ////võtame välja järgmise
            //Console.WriteLine("Dequeuing '{0}'",numbers.Dequeue());

            ////teeme koopia järjekorrast
            //Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            //Console.WriteLine("\nContents of the first Copy:");
            //foreach (var number in queueCopy)
            //{
            //    Console.WriteLine(number);
            //}

            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);
            //foreach (var item in array2)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<string> queueCopy2 = new Queue<string>(array2);
            //Console.WriteLine("\nContents of the second Copy, with duplicates and nulls:");
            //foreach (string number in queueCopy2)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine("\nqueueCopy contains 'four'={0}",queueCopy.Contains("four"));
            ////tühjendame järjekorra
            //queueCopy.Clear();
            //Console.WriteLine("\nqueueCopy count is:{0}",queueCopy.Count);
            #endregion

            #region Stack- Last in first out

            //Stack<string> numbers = new Stack<string>();
            //numbers.Push("");
            //numbers.Push("two");
            //numbers.Push("three");
            //numbers.Push("four");
            //numbers.Push("five");

            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nPopping '{0}'",numbers.Pop());
            //Console.WriteLine("Peek at next item to destack: {0}",numbers.Peek());
            //Console.WriteLine("Popping '{0}'", numbers.Pop());

            #endregion

            #region LINQ
            //Andmekogum
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //loome päringu
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;
            foreach (int number in numbers)
            {
                Console.WriteLine("{0,1}",number);
            }

                           #endregion
            Console.ReadLine();
        }
    }
}
