using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class MainClass
    {
        static void Main(string[] args)
        {
            firstDemo();
        }
        private static void firstDemo()
        {
            int[] scores = { 67, 76, 56, 87, 58, 96, 58, 67, 86, 78 };
            //These functions were added to support LINQ operations on collections...
            Console.WriteLine("The max score is" + scores.Max());
            Console.WriteLine("The min score is" + scores.Min());
            Console.WriteLine("The avg score is" + scores.Average());
            //Get the scores greater than average....
            var greaterScores = scores.Where(s => s > scores.Average());
            foreach (var score in greaterScores)
                Console.WriteLine(score);
            Console.WriteLine("Enter the score to find");
            int findingscore = int.Parse(Console.ReadLine());
            var selectedScores = scores.Where(s => s == findingscore);
            /*All Extension methods of LINQ will return a collection, whose values
            are extracted using foreach statement....*/
            foreach (var item in selectedScores)
                Console.WriteLine(item); 
        }
    }
}