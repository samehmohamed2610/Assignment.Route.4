using System;

namespace Route._4
{
    internal class Program
    {
        public static void Swap(int x , int y)
        {
            int Temp = x;
            x = y ;
            y = Temp ;
        }
        public static void Swap( ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }
        public static int[] sumsub(int x, int y, ref int sum, ref int sub)
        {
            sum = x + y;
            sub = x - y;
            return new[] { sum, sub };
        }
        public static int sumdigits(int x)
        {
            int sum = 0;
            while (x > 0)
            {
                sum += x%10;
                x /= 10;
            }
            return sum;
        }
        static bool isPrime(int x)
        {
            if (x <= 1) return false;


            for (int i = 2; i * i <= x; i++)  
            {
                if (x % i == 0) return false;
            }
            return true;

        }
        static int[] minMax(int[] arr)
        {
            int max = int.MinValue;//20   20
            int min = int.MaxValue;//10   10
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];

            }
            int [] result = { min, max };
            return result;
        }
        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return (result);
        }
        static string ChangeChar(string str, int pos, char newChar)
        {
            if (pos < 0 || pos > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(pos), "position is out of range");
            }

            char[] chars = str.ToCharArray();
            chars[pos] = newChar;// a h m h d
            return new string(chars);
        }

        static void Main(string[] args)
        {

            #region Demo
            #region casting [boxing_unboxing]
            /* refrence type => from reference to reference */
            /*boxing casting => from value type to refrence {safe casting}*/
            /*unboxing casting => from refrence type to value  {unsafe casting}*/

            //object obj = new object();
            //obj = "mostafa"; /*refrence type */
            //obj = 2; /*boxing casting*/

            //int x = 10;
            //object obj01 = new object();  /*boxing*/
            // obj01 = x ;

            //int x = 10; 
            //object obj01 = new object();    /*unboxing*/
            //int x = obj01;        /*not valid */
            /*we can fix it by typing int x = (int)obj01; but not safe */




            #endregion

            #region nullable data type 

            #region value type 
            //int x = null;  /* number only so we cant say that */
            //int ? x = null; /*works on number and allow null too */

            //Nullable<int> number; /*we can write as that but not usable now days */

            //int x = 10;
            //int? y = /*(int?)*/x;

            //int? x = null;
            //int y; 

            //if (x != null)
            //{
            //    y = (int)x; 
            //}
            //else
            //{
            //    y = 0;
            //}

            //y = x.HasValue ? X.Value : 0; 


            //Console.WriteLine(y);
            #endregion

            #region reference type
            //string? name = null;

            //Console.WriteLine("");

            #endregion

            #endregion

            #region Null propagation operator 
            //int[] numbers = null; 

            //if (numbers != null )
            //{
            //    for (int i = 0; i < numbers?.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //} 



            // i < numbers?.length 
            // numbers  => object [length]
            // numbers => null [null]

            //int length = numbers?.length ?? 0;

            //Console.WriteLine(length);

            //Employee Emp = new Employee();

            //Emp.Department = new Department();

            //if (name != null)
            //{
            //    if (Emp.Department != null)
            //    {
            //        Console.WriteLine(Emp.Department.Name);

            //    }
            //}

            //Console.WriteLine(Emp.Department?.Name ?? "Not found");

            #endregion

            #region Functions 

            //Class2.PrintShape(10 , "(*-*)");

            //Class2.PrintShape(count:10 , pattern:"fkdsm");

            //Console.WriteLine("hello \n ahmed "); /*new line*/ 
            //Console.WriteLine("hello \t ahmed "); /*four spaces */
            //Console.WriteLine("hello \\ ahmed "); /*print \ */

            #endregion

            #region value Type parameters 
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Class3.Swap(A , B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion

            #region by refrences 
            //int A = 5;
            //int B = 10;
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Class3.Swap01( ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);
            #endregion

            #region refrence type 

            #region value
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(Class3.SumArr(numbers));
            //Console.WriteLine(numbers[0]);
            #endregion
            #region reference
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(Class3.SumArr1(ref numbers));
            //Console.WriteLine(numbers[0]);
            #endregion

            #endregion

            #region Functions - parsing by out 
            //int A = 10; 
            //int B = 20;
            //int sum = 0;
            //int mul = 0;

            //Class3.SumMul (A , B , out sum, out mul);

            //Console.WriteLine(sum);            /* value */
            //Console.WriteLine(mul);

            //int A = 10; 
            //int B = 20;
            //int sum = 0;
            //int mul = 0;

            //Class3.SumMul01 (A , B , ref sum, ref mul);

            //Console.WriteLine(sum);            /* refrence */
            //Console.WriteLine(mul);

            #endregion

            #region function params 
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(Class3.SumArr(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            //int a = 12 , b = 13 , c = 14 ;
            //Console.WriteLine("A : {0} , b: {1} , c :  {2} " , a , b, c);


            #endregion

            #endregion

            #region Assignment4

            #region Q1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //int a =  10 , b = 20 ;
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            //Swap(a, b);
            //Console.WriteLine("After Swaping");
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            #endregion

            #region Q2.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //int a = 10, b = 20;
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            //Swap(ref a , ref b);
            //Console.WriteLine("After Swaping");
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            #endregion

            #region Q3.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int sum = 0;
            //int sub = 0;
            //int[] result = sumsub(1, 2, ref sum, ref sub);
            //Console.WriteLine("sum = {0} ,sub = {1}", result[0], result[1]); 
            #endregion

            #region Q4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //int num;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter the number");
            //    flag = int.TryParse(Console.ReadLine(), out num);

            //} while (!flag);
            //int result = sumdigits(num);
            //Console.WriteLine(result);
            #endregion

            #region Q5.Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //int num = int.Parse(Console.ReadLine());
            //bool prime = isPrime(num);
            //if (prime)
            //{
            //    Console.WriteLine("prime");
            //}
            //else
            //{
            //    Console.WriteLine("not prime");
            //}

            #endregion

            #region Q6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] arr = { 10,20,30,40,50,60,70};
            //int[] result = minMax(arr);
            //Console.WriteLine(result[0]);
            //Console.WriteLine(result[1]);
            #endregion

            #region Q7.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.WriteLine(Factorial(4));
            #endregion

            #region Q8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.WriteLine(ChangeChar("ahmed", 3, 'h'));
            #endregion

            #endregion
        }
    }
}
