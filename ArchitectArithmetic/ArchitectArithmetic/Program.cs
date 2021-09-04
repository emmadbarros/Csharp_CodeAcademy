using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input
            Console.WriteLine("What monument would you like to work with?");
            string user_answer = Console.ReadLine(); //.ToLower()

            //Evaluate user input
            if (user_answer.Equals("Teotihuacan", StringComparison.CurrentCultureIgnoreCase))
            {
                CalculateTotalCostTeotihuacan();
            }
            else if (user_answer.Equals("Taj Mahal", StringComparison.CurrentCultureIgnoreCase)) {
                CalculateTotalCostTajMahal();
            }
            else if (user_answer.Equals("Great Mosque of Mecca", StringComparison.CurrentCultureIgnoreCase)) {
                CalculateTotalCostMosque();
            }
            else
            {
                Console.WriteLine("Sorry, can't calculate cost for: " + user_answer);
            }
        }

        //Rectangle Area Formula
        static double Rectangle(double length, double width)
        {
            double area = length * width;
            return area;
        }

        //Circle Area Formula
        static double Circle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        //Triangle Area Formula
        static double Triangle(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }

        //Calculate cost (would usually use decimal for $$$)
        static double CalculateCost(double total_area)
        {
            double cost_total = Math.Round(180 * total_area, 2);
            return cost_total;
        }

        //Teotihuacan Project Method
        static void CalculateTotalCostTeotihuacan()
        {
            double area_triangle = Triangle(750, 500);
            double area_rectangle = Rectangle(1500, 2500);
            double area_half_circle = Circle(375 / 2) / 2;

            double total_area = area_triangle + area_rectangle + area_half_circle;

            double cost_total = CalculateCost(total_area);

            Console.WriteLine($"Teotihuacan\nThe total area is {Math.Round(total_area, 2)}m\nThe cost of the flooring material is 180 Mexican pesos per unit.\nThe total cost of the project is {cost_total} Mexian pesos.\n");
        }

        //Taj Mahal Project Method
        static void CalculateTotalCostTajMahal()
        {
            double area_triangle = Triangle(24, 24);
            double area_square = Rectangle(90.5, 90.5);
            double area_taj_mahal = area_square - (area_triangle * 4);

            double cost_total = CalculateCost(area_taj_mahal);

            Console.WriteLine($"Taj Mahal\nThe total area is {Math.Round(area_taj_mahal, 2)}m\nThe cost of the flooring material is 180 Mexican pesos per unit.\nThe total cost of the project is {cost_total} Mexian pesos.\n");
        }

        //Great Mosque of Mecca Project Method
        static void CalculateTotalCostMosque()
        {
            double area_triangle = Triangle(84, 264);

            double area_top_rectangle = Rectangle(180, 106);
            double area_middle = Rectangle(264, 284) - area_triangle;

            double total_area = area_top_rectangle + area_middle;

            double cost_total = CalculateCost(total_area);

            Console.WriteLine($"Great Mosque of Mecca\nThe total area is {Math.Round(total_area, 2)}m\nThe cost of the flooring material is 180 Mexican pesos per unit.\nThe total cost of the project is {cost_total} Mexian pesos.\n");
        }

    }
}
