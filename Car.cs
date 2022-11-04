
namespace Projekcik
{
    class car
    {
        string color;
        string company;
        int year;


        public car(string color, string company, int year)
        {
            this.color = color;
            this.company = company;
            this.year = year;


        }

        public void drive()
        {
            System.Console.WriteLine($"You are driving {year} {color} {company}");

        }



    }







}