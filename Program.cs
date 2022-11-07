using System;
namespace Projekcik
{
    class Program
    {
        static void Main(string[] args)
        {

            string response;
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }


                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                System.Console.WriteLine("Player: " + player);
                System.Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            System.Console.WriteLine("Thats a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            System.Console.WriteLine("You lose!");
                        }
                        else
                        {
                            System.Console.WriteLine("You win!");
                        }
                        break;

                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            System.Console.WriteLine("Thats a draw!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            System.Console.WriteLine("You lose!");
                        }
                        else
                        {
                            System.Console.WriteLine("You win!");
                        }
                        break;

                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            System.Console.WriteLine("Thats a draw!");
                        }
                        else if (computer == "ROCK")
                        {
                            System.Console.WriteLine("You lose!");
                        }
                        else
                        {
                            System.Console.WriteLine("You win!");
                        }
                        break;
                }

                System.Console.WriteLine("Would you like to play again? Y/N");
                response = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                    System.Console.WriteLine("Thanks for playing!");
                }



































                // Random random = new Random();
                // bool playagain = true;
                // string person = "";
                // string computer= "";

                // while (playagain)
                // {
                //     person = "";
                //     computer = "";

                //     while(person != "ROCK" && person != "PAPER" && person != "SCISSORS")
                //     {
                //     System.Console.Write("Enter rock, paper or scissors: ");
                //     person = Console.ReadLine();
                //     person = person.ToUpper();
                //     }

                //     switch(random.Next(1,4))
                //     {
                //         case 1:
                //             computer = "ROCK";
                //             break;
                //         case 2:
                //             computer = "PAPER";
                //             break;
                //     }

                // }




























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
}
