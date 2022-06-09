using System;

namespace deliverable_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool restart = true;
            while (restart == true)
            {
                Console.Write("How many people are we making PB&J sandwiches for?\n");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nYou want " + input1 + " sandwiches?\n");

                Console.WriteLine("Ok, you will need: \n");
                float slices = input1 * 2;
                float pb = input1 * 2;
                float j = input1 * 4;
                float loafs = slices / 28;
                float JarP = pb / 32;
                float JarJ = j / 48;
                float loafstotal = (int)Math.Ceiling(loafs);
                float JarPtotal = (int)Math.Ceiling(JarP);
                float JarJtotal = (int)Math.Ceiling(JarJ);
                Console.WriteLine(slices + " slices of bread\n" + pb + " tablespoons of peanutbutter\n" + "and " + j + " teaspoons of jelly.\n");


                Console.WriteLine("which is:\n");
                if (loafstotal < 2)
                {
                    Console.WriteLine(loafstotal + " loaf of bread");
                }
                else
                {
                    Console.WriteLine(loafstotal + " loaves of bread");
                }
                if (JarPtotal < 2)
                {
                    Console.WriteLine(JarPtotal + " jar of peanutbutter");
                }
                else
                    Console.WriteLine(JarPtotal + " jars of peanutbutter");
                if (JarJtotal < 2)
                {
                    Console.WriteLine(JarJtotal + " jar of jelly");
                }
                else
                {
                    Console.WriteLine(JarJtotal + " jars of jelly");
                }
                Console.WriteLine("\nWould you like to restart?");
                string input2 = Console.ReadLine();
                if (input2 == "yes" || input2 == "y")
                { }
                else restart = false;
                { 
                    Console.WriteLine("\nGoodbye"); 
                }
            }    
        }
    }
}
