using Shared;
using System;
using System.Linq;

namespace LINQTut14.StandardMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunAvg();
            Console.ReadKey();
        }

        private static void RunCount()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            Console.WriteLine($"Total Questions: {quiz.Count()}");         
            Console.WriteLine($"Total Questions With One Mark : {quiz.Count(x => x.Marks == 1)}");
            Console.WriteLine($"Total Questions With One Mark : {quiz.Where(x => x.Marks == 1).Count()}");
            Console.WriteLine($"Total Questions With One Mark Using LongCount : {quiz.Where(x => x.Marks == 1).LongCount()}");
        }

        private static void RunMax()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            var maximumMark = quiz.Max(x => x.Marks);
            //var maximumMark = quiz.Where(x => x.Choices.Count < 3).Max(x => x.Marks);
            Console.WriteLine($"Maximum Mark: {maximumMark}");
        }
        private static void RunMaxBy()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            var maximumQuestionMark = quiz.MaxBy(x => x.Marks);
            //var maximumMark = quiz.Where(x => x.Choices.Count < 3).Max(x => x.Marks);
            Console.WriteLine($"{maximumQuestionMark}");
        }
        private static void RunMin()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            var maximumMark = quiz.Min(x => x.Marks);
            //var minimumMark = quiz.Where(x => x.Choices.Count < 3).Min(x => x.Marks);
            Console.WriteLine($"Minimum Mark: {maximumMark}");
        }
        private static void RunMinBy()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            var minimumQuestionMark = quiz.MinBy(x => x.Marks);
            //var minimumMark = quiz.Where(x => x.Choices.Count < 3).MinBy(x => x.Marks);
            Console.WriteLine($"{minimumQuestionMark}");
        }

        private static void RunSum()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            var total = quiz.Sum(x => x.Marks);
            Console.WriteLine($"total: {total}");
        }

        private static void RunAvg()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(1, 200));
            var average = quiz.Average(x => x.Marks);
            Console.WriteLine($"average: {average.ToString("#.##")}");
        }
    }
}
