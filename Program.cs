using System;
namespace Projekcik
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double number1 = 0;
                double number2 = 0;
                double result = 0;




                System.Console.WriteLine("--------------");
                System.Console.WriteLine("CALCULATOR PROGRAM");
                System.Console.WriteLine("--------------");

                System.Console.Write("Enter first number: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                System.Console.Write("Enter second number: ");
                number2 = Convert.ToDouble(Console.ReadLine());



                System.Console.WriteLine(@"Choose an option: 
                                        + : Add 
                                        - : Substract
                                        / : Divide
                                        * : Multiply");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = number1 + number2;
                        System.Console.WriteLine($"Your result: {number1} + {number2} = {result}");
                        break;

                    case "-":
                        result = number1 - number2;
                        System.Console.WriteLine($"Your result: {number1} - {number2} = {result}");
                        break;

                    case "/":
                        result = number1 / number2;
                        System.Console.WriteLine($"Your result: {number1} / {number2} = {result}");
                        break;

                    case "*":
                        result = number1 * number2;
                        System.Console.WriteLine($"Your result: {number1} * {number2} = {result}");
                        break;
                    default:
                        System.Console.WriteLine("that is not valid option");
                        break;

                }
                System.Console.WriteLine("Would you like to countinue? Y/N");

            } while (Console.ReadLine().ToUpper() == "Y");
            System.Console.WriteLine("I hope i helped you, bye!");









































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

