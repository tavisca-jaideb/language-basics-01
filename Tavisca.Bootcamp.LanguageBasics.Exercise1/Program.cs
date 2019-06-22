using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1?74", 9);
            Test("4?*47=1974", 2);
            Test("42*?7=1974", 4);
            Test("?42*47=1974", -1);
            Test("2*12?=247", -1);
            Console.ReadKey(true);
        }

        private static void Test(string args, int expected)
        {
            try
            {
                var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
                Console.WriteLine($"{args} : {result}");
            }
            catch (Exception e)
            {

            }
        }

        public static int FindDigit(string equation)
        {
            // Add your code here.
            var indexofstar = equation.IndexOf('*');
            var indexofequal = equation.IndexOf('=');
            var A = "";
            var B = "";
            var C = "";
            for (var i = 0; i < equation.Length; i++)
            {
                if (i < indexofstar)
                    A += equation[i];
                if (i > indexofstar && i < indexofequal)
                    B += equation[i];
                if (i > indexofequal)
                    C += equation[i];
            }
            try
            {

                var A1 = Int32.Parse(A);

            }
            catch (FormatException e1)
            {

                var C1 = Int32.Parse(C);
                var B1 = Int32.Parse(B);
                if (C1 % B1 == 0)
                {
                    var result = C1 / B1;
                    var r1 = result.ToString();
                    var indexofquestionmark = A.IndexOf('?');
                    if (r1.Length == A.Length)
                        return (int)char.GetNumericValue(r1[indexofquestionmark]);
                    else
                        return -1;
                }

            }
            try
            {
                // statements causing exception
                var B1 = Int32.Parse(B);

            }
            catch (FormatException e1)
            {
                var C1 = Int32.Parse(C);
                var A1 = Int32.Parse(A);
                if (C1 % A1 == 0)
                {
                    var result = C1 / A1;
                    var r1 = result.ToString();
                    var indexofquestionmark = B.IndexOf('?');
                    if (r1.Length == B.Length)
                        return (int)char.GetNumericValue(r1[indexofquestionmark]);
                    else
                        return -1;
                }
            }
            try
            {
                // statements causing exception
                var C1 = Int32.Parse(C);

            }
            catch (FormatException e1)
            {
                var A1 = Int32.Parse(A);
                var B1 = Int32.Parse(B);
                var result = A1 * B1;
                var r1 = result.ToString();
                var indexofquestionmark = C.IndexOf('?');
                if (r1.Length == C.Length)
                    return (int)char.GetNumericValue(r1[indexofquestionmark]);
                else
                    return -1;
            }

            throw new NotImplementedException();
        }
    }
}