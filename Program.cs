using System;
namespace Projekcik
{
    class Program
    {
        static void Main(string[] args)
        {

            string imie = "";


            while (imie == "")
            {

                Console.Write("Podaj imie");
                imie = Console.ReadLine();
            }



            Random random = new Random();
            int num = random.Next(1, 7);
            System.Console.WriteLine(num);

            string name = "Matt";
            string username = name.Insert(0, "Mr.");
            System.Console.WriteLine(username);

            string phonenumber = "123-123-123";
            phonenumber = phonenumber.Replace("-", " ");
            System.Console.WriteLine(phonenumber);



            car car1 = new car("blue", "ford", 1990);
            car car2 = new car("red", "ferrari", 2003);
            car1.drive();
            car2.drive();





        }

    }



}
