using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            submarine mySubmarine = new submarine();
            var instructions = File.ReadAllLines("input.txt");

            foreach(string instruction in instructions)
            {
                var splitInstruction = instruction.Split(" ");
                
                switch (splitInstruction[0])
                {
                    case "forward":
                        mySubmarine.forward(int.Parse(splitInstruction[1]));
                        break;
                    case "up":
                        mySubmarine.up(int.Parse(splitInstruction[1]));
                        break;
                    case "down":
                        mySubmarine.down(int.Parse(splitInstruction[1]));
                        break;
                }

            }

            Console.WriteLine("Depth of the submarine is " + mySubmarine.depth + "and the horizontal position is " + mySubmarine.horizontal + ".");


        }
            public class submarine
        {
            public int depth = 0;
            public int horizontal = 0;

            public void forward(int unit)
            {
                horizontal += unit;
            }
            public void up(int unit)
            {
                if (unit > depth)
                {
                    depth = 0;
                }
                else
                {
                    depth -= unit;
                }
            }
            public void down(int unit)
            {
                depth += unit;
            }
        }
    }
}

