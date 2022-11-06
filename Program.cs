using System;
namespace Projekcik
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playagain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playagain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    System.Console.WriteLine("guess a number between " + min + " - " + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        System.Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        System.Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;

                }
                System.Console.WriteLine("Number: " + number);
                System.Console.WriteLine("You win!");
                System.Console.WriteLine("Guesses: " + guesses);
                System.Console.WriteLine("would you like to play again Y/N: ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false;
                }
            }
            System.Console.WriteLine("thanks for playing!");






























            // string[] cars = new string[4];

            // System.Console.WriteLine("Type in four cars: ");

            // for (int i = 0; i < cars.Length; i++) // for(index czyli "i"; dopoki i jest mniejsze od ilosci elementow w tablicy CARS ;inkrementacja)
            // {
            //     cars[i] = Console.ReadLine();
            // }

            // System.Console.WriteLine("Here they are alphabetically:");

            // Array.Sort(cars);  //sortowanie alfabetycznie

            // for (int i = 0; i < cars.Length; i++)
            // {
            //     System.Console.WriteLine(cars[i]);
            // }







            // string imie = "";


            // while (imie == "")
            // {

            //     Console.Write("Podaj imie");
            //     imie = Console.ReadLine();
            // }



            // Random random = new Random();
            // int num = random.Next(1, 7);
            // System.Console.WriteLine(num);

            // string name = "Matt";
            // string username = name.Insert(0, "Mr.");
            // System.Console.WriteLine(username);

            // string phonenumber = "123-123-123";
            // phonenumber = phonenumber.Replace("-", " ");
            // System.Console.WriteLine(phonenumber);



            // car car1 = new car("blue", "ford", 1990);
            // car car2 = new car("red", "ferrari", 2003);
            // car1.drive();
            // car2.drive();





        }

    }



}
