using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Something");
            try
            {
                StartSequence();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program is done");
            }
        }
        /// <summary>
        /// Runs the Populate, GetSum, GetProduct, and GetQuotient methods and writes to the console how they were created. 
        /// </summary>
        public static void StartSequence()
        {
            try
            {
            Console.WriteLine("Enter a number greater than zero");
            string inputString = Console.ReadLine();
            int input = Convert.ToInt32(inputString);
            int[] startarr = new int[input];
            int[] pop = Populate(startarr);
            int sum = GetSum(pop);
            int product = GetProduct(pop, sum);
            decimal quo = GetQuotient(product);

            Console.WriteLine($"Your array size is: {pop.Length} ");
            Console.WriteLine($"The numbers in the array are {String.Join(", ", pop) }");
            Console.WriteLine($"{sum} * {product / sum} = {product} ");
            Console.WriteLine($"{product} / {product / quo}  = {quo} ");


            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception )
            {

                throw;
            }
        }
        /// <summary>
        /// The Populate method is taking an input from the number entered and returning an array for the request number that is a long as the number entered.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1}/{arr.Length}");
                string input = Console.ReadLine();
                arr[i] = Convert.ToInt32(input);
            }
            return arr;
        }
        /// <summary>
        /// Iterates through the an array and adds to the sum the different values that were inputed.
        /// </summary>
        /// <param name="sumArr"></param>
        /// <returns>returns the variable sum</returns>
        public static int GetSum(int[] sumArr)
        {
            int sum = 0;

            for (int i = 0; i < sumArr.Length; i++)
            {
                sum += sumArr[i];
            }
            if (sum < 20)
            {
                throw (new Exception($"Value of {sum} is too low"));
            }
            Console.WriteLine($"The sum of the arr is {sum}");
            return sum;

        }
        /// <summary>
        /// Multiples the specific index of the array to the number the user entered.
        /// </summary>
        /// <param name="productArr"></param>
        /// <param name="productSum"></param>
        /// <returns>returns the product of the two numbers</returns>
        public static int GetProduct(int[] productArr, int productSum)
        {
            try
            {
                Console.WriteLine($"Select a random number between 1 and {productArr.Length} ");
                string inputString = Console.ReadLine();
                int input = Convert.ToInt32(inputString);
                int product = productSum * productArr[input - 1];
                return product;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        /// <summary>
        /// Uses the input of the user to divide the number that was chosen in the prior method.
        /// </summary>
        /// <param name="product"></param>
        /// <returns>returns 0 if the the catch is enabled</returns>
        public static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine("Enter a number to divide by. ");
                string inputString = Console.ReadLine();
                int input = Convert.ToInt32(inputString);
                decimal quotient = Decimal.Divide(product, input);

                return quotient;


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
