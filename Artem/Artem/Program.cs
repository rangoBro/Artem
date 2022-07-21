using System;

namespace Artem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Normal Humans
            Console.WriteLine("Normal Humans\n-------------");

            Human h1 = new Human();
            h1.Name = "Max";
            h1.SetAge(12);
            

            Human h2 = new Human();
            h2.Name = "Linus";
            h2.SetAge(5);

            Human h3 = new Human();
            h3.Name = "Bernd";
            h3.SetAge(70);


            h1.WriteInformation();
            h2.WriteInformation();
            h3.WriteInformation();


            // Static Humans
            Console.WriteLine("\n\nStatic Humans\n-------------");

            HumanStatic sh1 = new HumanStatic();
            sh1.Name = "Mustafa";
            sh1.SetAge(12);


            HumanStatic sh2 = new HumanStatic();
            sh2.Name = "Tim";
            sh2.SetAge(5);

            HumanStatic sh3 = new HumanStatic();
            sh3.Name = "Rüdiger";
            sh3.SetAge(70);


            sh1.WriteInformation();
            sh2.WriteInformation();
            sh3.WriteInformation();

            Console.ReadLine();
        }
    }



    class Human
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void SetAge(int newAge)
        {
            Age = newAge;
        }

        public void WriteInformation()
        {
            Console.WriteLine(this.Name + " ist " + Age + " Jahre alt!");
        }
    }



    class HumanStatic
    {
        public string Name { get; set; }

        public static int Age { get; set; }

        public void SetAge(int newAge)
        {
            Age = newAge;
        }

        public void WriteInformation()
        {
            Console.WriteLine(this.Name + " ist " + Age + " Jahre alt!");
        }
    }
}
