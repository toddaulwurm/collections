using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] numarr = {0,1,2,3,4,5,6,7,8,9};

            string[] namearr = {"Tim", "Martin", "Nikki", "Sara"};

            List<string> boolean = new List<string>();
            for(var i=1; i<=10; i++)
            {
                if(i%2==1 || i==1)
                {
                    boolean.Add("True");
                }
                else if(i%2==0)
                {
                    boolean.Add("False");
                }
            }

            List<string> icecream = new List<string>();
            icecream.Add("Vanilla");
            icecream.Add("Raspberry");
            icecream.Add("Caramel");
            icecream.Add("Oat");
            icecream.Add("Corn");
            for(var i=0; i<icecream.Count; i++)
            {
                Console.WriteLine(icecream[i]);
            }
            Console.WriteLine(icecream.Count);
            Console.WriteLine(icecream[2]);
            icecream.RemoveAt(2);
            Console.WriteLine(icecream.Count);


            Dictionary<string,string> user = new Dictionary<string,string>();
            Random rand = new Random();
            foreach (var name in namearr)
            {
                user.Add($"{name}", $"{icecream[rand.Next(0,3)]}");
            }
            foreach (KeyValuePair<string,string> entry in user)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
