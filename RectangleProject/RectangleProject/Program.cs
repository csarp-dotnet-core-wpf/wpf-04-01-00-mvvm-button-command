using System;
using RectangleProject.Models;

namespace RectangleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(2, 4);
            Rectangle r2 = new Rectangle(1, 3);

            if(r1.Area > r2.Area)
            {
                Console.WriteLine($"Az első téglalap területe a nagyobb! Területe: {r1.Area}");
            }
            else if(r2.Area > r1.Area)
            {
                Console.WriteLine($"A második téglalap területe a nagyobb! Területe: {r2.Area}");
            }
            else
            {
                Console.WriteLine($"A két téglalap területe egyenlő! Területük: {r1.Area}");
            }
        }
    }
}
