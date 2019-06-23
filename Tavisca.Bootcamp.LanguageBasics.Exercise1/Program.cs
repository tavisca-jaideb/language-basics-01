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
        
            var result = FindDigit(args).Equals(expected) ? "PASS" : "FAIL";
            Console.WriteLine($"{args} : {result}");
      
        }

        public static int FindDigit(string equation)
        {
            // Add your code here.
            //throw new NotImplementedException();
            string[] digits = equation.Split(new char[] { '*', '=' });
            if(digits[0].Contains('?'))
            {
                int b = int.Parse(digits[1]);
                int c = int.Parse(digits[2]);

                if (c % b != 0)
                    return -1;
                int a = c / b;
                string x = a.ToString();
                string A = digits[0];
                var indexofquestionmark = A.IndexOf('?');
                if (x.Length == A.Length)
                    return (int)char.GetNumericValue(x[indexofquestionmark]);
                else
                    return -1;

            }
            if(digits[1].Contains('?'))
            {
                int a = int.Parse(digits[0]);
                int c = int.Parse(digits[2]);
                if (c % a != 0)
                    return -1;
                int b = c / a;
                string x = b.ToString();
                string B = digits[1];
                var indexofquestionmark = B.IndexOf('?');
                if (x.Length == B.Length)
                    return (int)char.GetNumericValue(x[indexofquestionmark]);
                else
                    return -1;
            }
            if(digits[2].Contains('?'))
            {
                int a = int.Parse(digits[0]);
                int b = int.Parse(digits[1]);
                int c = a * b;
                string x = c.ToString();
                string C = digits[2];
                var indexofquestionmark = C.IndexOf('?');
                if (x.Length == C.Length)
                    return (int)char.GetNumericValue(x[indexofquestionmark]);
                else
                    return -1;
            }
            return 1;

        }
        
    }
}
