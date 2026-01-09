using System.Collections;

namespace FunctionCallingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling a function...");
            //RemoveDeuplicates("himmanshu,");// Calling the GreetUser function
            //Countcharacter("hello world");
            //chkPalindrome("madam");
            //ReverseString("hello");
            //ReverseEachword("Hello World There");
            //MoveNonZeroesToFrontInPlace();
            pyramidpattern();
            //findduplicateelement();
            //fibonacciseries();
            //fibonacciseries();
            //FindEvenNumberinArrayLinq();
            // FindthirdLargeInArray();
            //Add<string>("dotnet ", "funda");
            //Add<int>(5, 1);
            Console.WriteLine("Function call complete.");
        }

        // A simple function that takes a string argument and prints a greeting
        static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void chkPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");
        }

        static void ReverseString(string str)
        {

            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }

        static void RemoveDeuplicates(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine("removeduplicateresult" + result);
        }

        static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();
            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }

        static void arrayascending()
        {
            int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
        }

        static void arraydescending()
        {
            int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] < intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in descending order");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// find even number
        /// </summary>
        static void FindEvenNumberinArray()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> result = GetEvenNumbers(myArray);

            Console.WriteLine("Even numbers in the array:");
            foreach (int evenNum in result)
            {
                Console.Write(evenNum + " ");
            }
            Console.WriteLine();
        }
        public static List<int> GetEvenNumbers(int[] numbers)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }
            return evenNumbers;
        }

        static void FindEvenNumberinArrayLinq()
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> result = myArray.Where(number => number % 2 == 0);

            Console.WriteLine("Even numbers in the array using Linq:");
            int sum = 0;
            foreach (int evenNum in result)
            {
                Console.WriteLine(" even number is" + evenNum);
                /////sum = sum + evenNum;
            }
            //Console.WriteLine("sum of even number is"+sum);
        }
      

        static void FindthirdLargeInArray()
        {
            int[] myArray = { 3, 2, 1, 5, 4,7,9 };
           int resultthird= GetthirdLargeInArray(myArray);

            Console.WriteLine("Max 3 numbers:");
            Console.Write(resultthird + " ");
            Console.WriteLine();

            int resultsecond = GetSecondLargeInArray(myArray);
            Console.WriteLine("Max 2 numbers:");
            Console.Write(resultsecond + " ");
            Console.WriteLine();
        }
        public static int GetthirdLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2 && i != max1)
                {
                    max3 = max2;
                    max2 = i;
                }
                else if (i > max3 && i != max2 && i != max1)
                {
                    max3 = i;
                }
               
            }
            return max3;

        }


        public static int GetSecondLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i >= max2 && i != max1)
                {
                    max2 = i;
                }
                

            }
            return max2;

        }

        static void Add<T>(T a, T b)
        {
            Console.WriteLine((dynamic)a + (dynamic)b); 
            Console.ReadKey();
        }

        //ReverseEachword("Hello World There")
        static void ReverseEachword(string input)
        {

            // Input string with multiple words.
            //string input = "Hello World There";
            // Output string to store the final result.
            string output = "";

            // Variable to keep track of the start index of the current word.
            int wordStartIndex = 0;

            // Loop through the input string.
            for (int i = 0; i <= input.Length; i++)
            {
                // Check for a space or the end of the string.
                if (i == input.Length || input[i] == ' ')
                {
                    // This marks the end of a word.
                    int wordEndIndex = i - 1;

                    // Reverse the characters of the current word.
                    for (int j = wordEndIndex; j >= wordStartIndex; j--)
                    {
                        output += input[j];
                    }

                    // Add a space to the output after the reversed word, but not for the last word.
                    if (i < input.Length)
                    {
                        output += ' ';
                    }

                    // Update the start index for the next word.
                    wordStartIndex = i + 1;
                }
            }

            Console.WriteLine("Input: " + input);
            Console.WriteLine("Output: " + output);
        }

        static void fibonacciseries()
        {
            int count = 5;

            int a = 0;
            int b = 1;

            Console.Write("Fibonacci Series: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }
        }

        static void Factorial(int number)
        {
            int value = 1;
            for (int i = 1; i <= number; i++)
            {
                value = value * i;
            }
            Console.Write("Factorial is: "+ value); ;
        }

        static void reverseeachword()
        {
            //string inputobj = "Hello How Are You";
            //string inputobj = "Hello World there";
            string inputobj = "Hello Madam";

            string[] splitobj = inputobj.Split(" ");
            string finalResult = "";
            foreach (string word in splitobj)
            {
                string reversed = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed = reversed + word[i];
                }
                finalResult = finalResult + " " + reversed;
            }
            Console.WriteLine("Reversed value is-->" + finalResult);
            Console.ReadLine();
        }

        

        static void sumofevennumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Using LINQ to filter even numbers and then sum them
            int sumOfEvenNumbers = numbers.Where(n => n % 2 == 0).Sum();

            Console.WriteLine($"The sum of even numbers in the list is: {sumOfEvenNumbers}");

            // Example with an array
            int[] array = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int sumOfEvenMoreNumbers = array.Where(n => n % 2 == 0).Sum();

            Console.WriteLine($"The sum of even numbers in the array is: {sumOfEvenMoreNumbers}");
        }

        static void findduplicateelement()
        {
            int[] numbers = { 2, 5, 8, 2, 1, 5, 9, 8 };
            var duplicateElements = numbers.GroupBy(x => x) // Group elements by their value
                                           .Where(g => g.Count() > 1) // Filter groups with more than one element
                                           .Select(g => g.Key); // Select the key (the duplicate element)

            foreach (var num in duplicateElements)
            {
                Console.WriteLine(num);
            }
        }

       
        static void Duplicateelementarray()
        {
            int[] array = { 4, 2, 7, 4, 9, 2, 1, 7, 5 };
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();
            foreach (int num in array)
            {
                if (!seen.Add(num))
                {
                    duplicates.Add(num);
                }
            }

            Console.WriteLine("Duplicate elements:");
            foreach (int dup in duplicates)
            {
                Console.WriteLine(dup);
            }


            Console.WriteLine("Seen elements:");
            foreach (int org in seen)
            {
                Console.WriteLine(org);
            }

        }


        static void MoveNonZeroesToFrontInPlace()
        {

            int[] arr = { 0, 0, 0, 0, 1, 2, 9, 6, 8 };
            int insertPosition = 0;

            // First pass: move all non-zero elements to the front
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    // Overwrite the element at insertPosition
                    arr[insertPosition] = arr[i];
                    insertPosition++;
                }
            }

            // Second pass: fill the remaining elements from insertPosition to the end with 0
            for (int i = insertPosition; i < arr.Length; i++)
            {
                arr[i] = 0;
            }

            Console.WriteLine("Rearranged array: [" + string.Join(", ", arr) + "]");
        }


        static void MergeTwoArray()
        {
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = new int[] { 4, 5, 6 };

            int[] result = new int[array1.Length + array2.Length];

            //first array
            for (int i = 0; i < array1.Length; i++)
            {
                result[i] = array1[i];
            }

            //second array
            for (int i = 0; i < array2.Length; i++)
            {
                result[array1.Length + i] = array2[i];
            }
            Console.WriteLine("Result Array: [{0}]", string.Join(", ", result));
        }
        static void top2salarydeptwise()
        {
            List<Employee> employees = new List<Employee>
        {

                new Employee { ID = 1, Name = "Preety", Salary = 10000, Gender = "Female",Department ="HR"},
                new Employee { ID = 2, Name = "Priyanka", Salary =20000, Gender = "Female",Department ="Admin"},
                new Employee { ID = 3, Name = "Anurag", Salary = 35000, Gender = "Male",Department ="HR"},
                new Employee { ID = 4, Name = "Pranaya", Salary = 45000, Gender = "Male",Department ="Admin"},
                new Employee { ID = 5, Name = "Sambit", Salary = 15000, Gender = "Male",Department ="HR"},
                new Employee { ID = 6, Name = "Hina", Salary = 25000, Gender = "Female",Department ="HR"},
                new Employee { ID = 7, Name = "Santosh", Salary = 39000, Gender = "Male",Department ="Admin"},
                new Employee { ID = 8, Name = "Sukanta", Salary = 55000, Gender = "Male",Department ="HR"}

        };

            //Fetching First four Employees who are getting Highest Salary
            var topSalariesByDepartment = employees.GroupBy(emp => emp.Department)
                                          .Select(g => new
                                          {
                                              Department = g.Key,
                                              TopSalaries = g.OrderByDescending(emp => emp.Salary).Take(2).ToList()
                                          });

            foreach (var department in topSalariesByDepartment)
            {
                Console.WriteLine($"Department: {department.Department}");
                foreach (var emp in department.TopSalaries)
                {
                    Console.WriteLine($"Employee: {emp.Name}, Salary: {emp.Salary}");
                }
            }

        }

        public static void getcustomerdata()
        {
            var customers = new List<Customer>
        {
            new Customer
            {
                CustomerId = 1,
                Name = "Alice",
                Orders = new List<Order>
                {
                    new Order { OrderId = 101, OrderDate = new DateTime(2025, 11, 01) },
                    new Order { OrderId = 102, OrderDate = new DateTime(2025, 10, 25) }
                }
            },
            new Customer
            {
                CustomerId = 2,
                Name = "Bob",
                Orders = new List<Order>
                {
                    new Order { OrderId = 201, OrderDate = new DateTime(2025, 11, 03) },
                    new Order { OrderId = 202, OrderDate = new DateTime(2025, 10, 20) }
                }
            }
        };

            // LINQ query to filter and sort orders by date
            var filteredOrders = customers
                .SelectMany(c => c.Orders, (customer, order) => new { customer.Name, order.OrderId, order.OrderDate })
                .Where(o => o.OrderDate >= new DateTime(2025, 10, 01)) // Filter orders after a specific date
                .OrderByDescending(o => o.OrderDate); // Sort by OrderDate in descending order

            // Display results
            foreach (var order in filteredOrders)
            {
                Console.WriteLine($"Customer: {order.Name}, Order ID: {order.OrderId}, Order Date: {order.OrderDate:yyyy-MM-dd}");
            }
        }

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Salary { get; set; }
            public string Department { get; set; }

        }
        public class Order
        {
            public int OrderId { get; set; }
            public DateTime OrderDate { get; set; }
        }

        public class Customer
        {
            public int CustomerId { get; set; }
            public string Name { get; set; }
            public List<Order> Orders { get; set; }
        }

        public static void removeduplicatearrayinNumber()
        {

            int[] duplicatevalue = { 1, 2, 3, 4, 5, 6, 1, 3, 5, 5, 5, 5, 5, };

            Console.WriteLine("duplicatevaluearray" + duplicatevalue);
            List<int> arrayList = RemoveDuplicateFromarrayNumber(duplicatevalue);

            foreach (var value in arrayList)
            {
                Console.WriteLine(value);
            }

            //Console.WriteLine("orignalvaluearray" + arrayList.ToArray());
        }

        public static List<int> RemoveDuplicateFromarrayNumber(int[] inputArray)
        {
            List<int> ArrayList = new List<int>();
            foreach (int value in inputArray)
            {
                if (!ArrayList.Contains(value))
                {
                    ArrayList.Add(value);
                }
            }
            return ArrayList;
        }

        public static void removeduplicatearrayinstring()
        {

            string [] duplicatevalue = { "John", "Miller", "Raj", "Vicky", "John", "Raj" };

            Console.WriteLine("duplicatevaluearray" + duplicatevalue);
            List<string> arrayList = RemoveDuplicateFromarraystring(duplicatevalue);

            foreach (var value in arrayList)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("orignalvaluearray" + arrayList.ToArray());
        }

        public static List<string> RemoveDuplicateFromarraystring(string[] inputArray)
        {
            List<string> ArrayList = new List<string>();
            foreach (string value in inputArray)
            {
                if (!ArrayList.Contains(value))
                {
                    ArrayList.Add(value);
                }
            }
            return ArrayList;
        }

       
        /// <summary>
        /// vvimp program
        /// </summary>
        public static void MissingnumberInarray()
        {
            //int[] A = { 1, 5, 8, 10, 11, 16 };
            int[] A = { 1, 2, 4, 5 };
            for (int i = 0; i < A.Length - 1; i++)
            {
                int num = A[i + 1] - A[i];
                for (int j = 1; j < num; j++)
                {
                    Console.Write(A[i] + j +" ");
                }
            }
        }


        public static void pyramidpattern()
        {
            int rows = 5;
            ///Console.WriteLine();
            // Outer loop controls the number of rows
            for (int i = 1; i <= rows; i++)
            {
                // Inner loop for printing leading spaces to center the pyramid
                for (int space = 1; space <= (rows - i); space++)
                {
                    Console.Write(" ");
                }

                // Inner loop for printing asterisks
                // The number of stars in each row 'i' is 2*i - 1
                for (int star = 1; star <= (2 * i - 1); star++)
                {
                    Console.Write("*");
                }

                // Move to the next line after each row is complete
                Console.WriteLine();
            }
        }







    }
}