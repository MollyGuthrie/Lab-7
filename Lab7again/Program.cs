using System;
using System.Collections.Generic;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class.");
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Which student would you like to learn more about? (enter a number 1-12):");
                int input = int.Parse(Console.ReadLine());
                List<string> firstname = new List<string>();
                firstname.Add("");
                firstname.Add("Anel");
                firstname.Add("Brianna");
                firstname.Add("Jonaca");
                firstname.Add("Karina");
                firstname.Add("Lauren");
                firstname.Add("Lisa");
                firstname.Add("Michelle");
                firstname.Add("Molly");
                firstname.Add("Rebecca");
                firstname.Add("Tammy");
                firstname.Add("Tanvi");
                firstname.Add("Tommy");

                List<string> hometowns = new List<string>();
                hometowns.Add("");
                hometowns.Add("Grand Rapids, MI ");
                hometowns.Add("Fairfield, CA");
                hometowns.Add("Lansing, MI");
                hometowns.Add("Holland, MI");
                hometowns.Add("Plainwell, MI");
                hometowns.Add("L.A, CA");
                hometowns.Add("Ecuador");
                hometowns.Add("Rockford, MI");
                hometowns.Add("Charlevoix, MI");
                hometowns.Add("Grand Rapids, MI");
                hometowns.Add("India");
                hometowns.Add("Raleigh, NC ");

                List<string> favfoods = new List<string>();
                favfoods.Add("");
                favfoods.Add("Pizza");
                favfoods.Add("Gumbo");
                favfoods.Add("Sushi");
                favfoods.Add("Tacos");
                favfoods.Add("Cheeseburgers");
                favfoods.Add("Mushroom Masala Dosa");
                favfoods.Add("Spaghetti");
                favfoods.Add("Noodles");
                favfoods.Add("Pizza");
                favfoods.Add("Maru Sushi");
                favfoods.Add("Chicken Biryani");
                favfoods.Add("Indian red curry");

                if (input >= 1 && input <= 12)
                {
                    Console.WriteLine($"Student {input} is {firstname[input]}.");
                }
                else
                {
                    Console.WriteLine("That student does not exist. Please try again. (enter a number 1-12):");
                }

                Console.WriteLine($"Student " + input + $" is {firstname[input]}. What would you like to know about {firstname[input]} (enter 'hometown' or 'favorite food'):");
                string moreinfo = Console.ReadLine();
                moreinfo = moreinfo.ToLower();

                if (moreinfo == "hometown")
                {
                    Console.WriteLine($"{firstname[input]} is from {hometowns[input]}.");
                }
                else if (moreinfo == "favorite food")
                {
                    Console.WriteLine($"{firstname[input]}'s favorite food is {favfoods[input]}.");
                }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again. (enter hometown or favorite food):");
                }

                run = Continue();
            }
        }
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Get to know anoter C# student? (y/n):");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")
            {
                run = true;
            }
            else if (answer == "n" || answer == "N")
            {
                run = false;
                Console.WriteLine("Thanks!");
            }
            else
            {
                Console.WriteLine("I am unsure of what you said, please try again.");
                run = Continue();
            }
            return run;
        }
    }
}