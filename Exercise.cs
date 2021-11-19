using System;
using System.Collections.Generic;

namespace MathGame2
{
    static class Exercise
    {
        private static readonly Random rnd = new Random();

        private static readonly List<int[]> numbers = new List<int[]>();
        private static readonly List<char> operators = new List<char>();

        private static string _exercise;
        private static double _answer;

        public static void GenerateExercise()
        {
            // clean before use
            numbers.Clear();
            operators.Clear();

            // set numbers according the settings
            if (Properties.Settings.Default.OneNum)
                numbers.Add(new int[] { 0, 9 });
            if (Properties.Settings.Default.TwoNum)
                numbers.Add(new int[] { 10, 99 });
            if (Properties.Settings.Default.ThreeNum)
                numbers.Add(new int[] { 100, 9999 });

            // set operators according the settings
            if (Properties.Settings.Default.Plus)
                operators.Add('+');
            if (Properties.Settings.Default.Minus)
                operators.Add('-');
            if (Properties.Settings.Default.Divide)
                operators.Add('/');
            if (Properties.Settings.Default.Multiply)
                operators.Add('*');

            // creates the numbers and the operator of the exercise
            int[] numberType1 = numbers[rnd.Next(0, numbers.Count)];
            int randomized_number1 = rnd.Next(numberType1[0], numberType1[1]);

            char randomized_operator = operators[rnd.Next(0, operators.Count)];

            int[] numberType2 = numbers[rnd.Next(0, numbers.Count)];
            int randomized_number2 = rnd.Next(numberType2[0], numberType2[1]);

            // get the final exercise (string) and his answer.
            _exercise = $"{randomized_number1} {randomized_operator} {randomized_number2}";
            _answer = CalculateAnswer(randomized_number1, randomized_operator, randomized_number2);

        }

        private static double CalculateAnswer(int num1, char oper, int num2)
        {
            switch (oper)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '/':
                    if (num2 == 0)
                        return 0;
                    return Math.Round((double)num1 / num2, 2);
                case '*':
                    return num1 * num2;
                default:
                    return 0;
            }
        }

        public static double Answer
        {
            get
            {
                return _answer;
            }
        }

        public static string TheExercise
        {
            get
            {
                return _exercise;
            }
        }

        public static bool OKSettings
        {
            get
            {
                return (Properties.Settings.Default.OneNum
                    || Properties.Settings.Default.TwoNum
                    || Properties.Settings.Default.ThreeNum)
                    &&
                    (Properties.Settings.Default.Plus
                    || Properties.Settings.Default.Minus
                    || Properties.Settings.Default.Divide
                    || Properties.Settings.Default.Multiply);
            }
        }
    }
}