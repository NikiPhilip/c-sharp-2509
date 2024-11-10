using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ArraysandStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //1.Matrix Addition

            //    Console.Write("Enter number of rows for the matrices: ");
            //    int rows = int.Parse(Console.ReadLine());
            //    Console.Write("Enter number of columns for the matrices: ");
            //    int cols = int.Parse(Console.ReadLine());

            //    int[,] matrix1 = new int[rows, cols];
            //    int[,] matrix2 = new int[rows, cols];
            //    int[,] result = new int[rows, cols];

            //    Console.WriteLine("\nEnter elements of Matrix 1:");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write($"matrix1[{i},{j}]: ");
            //            matrix1[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }

            //    Console.WriteLine("\nEnter elements of Matrix 2:");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write($"matrix2[{i},{j}]: ");
            //            matrix2[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }

            //    // Perform matrix addition
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            result[i, j] = matrix1[i, j] + matrix2[i, j];
            //        }
            //    }

            //    Console.WriteLine("\nMatrix 1:");
            //    DisplayMatrix(matrix1, rows, cols);

            //    Console.WriteLine("\nMatrix 2:");
            //    DisplayMatrix(matrix2, rows, cols);

            //    Console.WriteLine("\nResultant Matrix (Addition):");
            //    DisplayMatrix(result, rows, cols);
            //    Console.ReadLine();
            //}

            //static void DisplayMatrix(int[,] matrix, int rows, int cols)
            //{
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write(matrix[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}


            //Matrix Multiplication

            //    Console.Write("Enter number of rows for Matrix 1: ");
            //    int rows1 = int.Parse(Console.ReadLine());
            //    Console.Write("Enter number of columns for Matrix 1 (and rows for Matrix 2): ");
            //    int cols1 = int.Parse(Console.ReadLine());
            //    Console.Write("Enter number of columns for Matrix 2: ");
            //    int cols2 = int.Parse(Console.ReadLine());

            //    int[,] matrix1 = new int[rows1, cols1];
            //    int[,] matrix2 = new int[cols1, cols2];
            //    int[,] result = new int[rows1, cols2];

            //    Console.WriteLine("\nEnter elements of Matrix 1:");
            //    for (int i = 0; i < rows1; i++)
            //    {
            //        for (int j = 0; j < cols1; j++)
            //        {
            //            Console.Write($"matrix1[{i},{j}]: ");
            //            matrix1[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }

            //    Console.WriteLine("\nEnter elements of Matrix 2:");
            //    for (int i = 0; i < cols1; i++)
            //    {
            //        for (int j = 0; j < cols2; j++)
            //        {
            //            Console.Write($"matrix2[{i},{j}]: ");
            //            matrix2[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }

            //    // Perform matrix multiplication
            //    for (int i = 0; i < rows1; i++)
            //    {
            //        for (int j = 0; j < cols2; j++)
            //        {
            //            for (int k = 0; k < cols1; k++)
            //            {
            //                result[i, j] += matrix1[i, k] * matrix2[k, j];
            //            }
            //        }
            //    }

            //    Console.WriteLine("\nMatrix 1:");
            //    DisplayMatrix(matrix1, rows1, cols1);

            //    Console.WriteLine("\nMatrix 2:");
            //    DisplayMatrix(matrix2, cols1, cols2);

            //    Console.WriteLine("\nResultant Matrix (Multiplication):");
            //    DisplayMatrix(result, rows1, cols2);
            //    Console.ReadLine();
            //}

            //static void DisplayMatrix(int[,] matrix, int rows, int cols)
            //{
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write(matrix[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //Matrix Transpose

            //    Console.Write("Enter number of rows for the matrix: ");
            //    int rows = int.Parse(Console.ReadLine());
            //    Console.Write("Enter number of columns for the matrix: ");
            //    int cols = int.Parse(Console.ReadLine());

            //    int[,] matrix = new int[rows, cols];
            //    int[,] transpose = new int[cols, rows];

            //    Console.WriteLine("\nEnter elements of the Matrix:");
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write($"matrix[{i},{j}]: ");
            //            matrix[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }

            //    // Perform matrix transpose
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            transpose[j, i] = matrix[i, j];
            //        }
            //    }

            //    Console.WriteLine("\nOriginal Matrix:");
            //    DisplayMatrix(matrix, rows, cols);

            //    Console.WriteLine("\nTransposed Matrix:");
            //    DisplayMatrix(transpose, cols, rows);
            //    Console.ReadLine();
            //}

            //static void DisplayMatrix(int[,] matrix, int rows, int cols)
            //{
            //    for (int i = 0; i < rows; i++)
            //    {
            //        for (int j = 0; j < cols; j++)
            //        {
            //            Console.Write(matrix[i, j] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //------------------------------------------------------------------------------------------------//

            //2 BubbleSort
            //    Console.WriteLine("Enter the number of elements:");
            //    int n = int.Parse(Console.ReadLine());

            //    //Initilalising array
            //    int[] array = new int[n];
            //    Console.WriteLine("Enter the elements:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //    }

            //    Console.WriteLine("Array before Bubble Sort:");
            //    PrintArray(array);

            //    BubbleSort(array);

            //    Console.WriteLine("Array after Bubble Sort:");
            //    PrintArray(array);
            //    Console.ReadLine();
            //}

            //static void BubbleSort(int[] array)
            //{
            //    int n = array.Length;
            //    for (int i = 0; i < n - 1; i++)
            //    {
            //        for (int j = 0; j < n - i - 1; j++)
            //        {
            //            if (array[j] > array[j + 1])
            //            {
            //                // Swap elements
            //                int temp = array[j];
            //                array[j] = array[j + 1];
            //                array[j + 1] = temp;
            //            }
            //        }
            //    }
            //}

            //static void PrintArray(int[] array)
            //{
            //    foreach (int element in array)
            //    {
            //        Console.Write(element + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Insertion Sort

            //    Console.WriteLine("Enter the number of elements:");
            //    int n = int.Parse(Console.ReadLine());

            //    int[] array = new int[n];
            //    Console.WriteLine("Enter the elements:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //    }

            //    Console.WriteLine("Array before Insertion Sort:");
            //    PrintArray(array);

            //    InsertionSort(array);

            //    Console.WriteLine("Array after Insertion Sort:");
            //    PrintArray(array);
            //    Console.ReadLine();
            //}

            //static void InsertionSort(int[] array)
            //{
            //    int n = array.Length;
            //    for (int i = 1; i < n; i++)
            //    {
            //        int key = array[i];
            //        int j = i - 1;

            //        // Move elements of array that are greater than key
            //        // to one position ahead of their current position
            //        while (j >= 0 && array[j] > key)
            //        {
            //            array[j + 1] = array[j];
            //            j--;
            //        }
            //        array[j + 1] = key;
            //    }
            //}

            //static void PrintArray(int[] array)
            //{
            //    foreach (int element in array)
            //    {
            //        Console.Write(element + " ");
            //    }
            //    Console.WriteLine();
            //}

            //------------------------------------------------------------------------------------------------//


            //3-Linear Search


            //    Console.WriteLine("Enter the number of elements:");
            //    int n = int.Parse(Console.ReadLine());

            //    int[] array = new int[n];
            //    Console.WriteLine("Enter the elements:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //    }

            //    Console.WriteLine("Enter the element to search for:");
            //    int target = int.Parse(Console.ReadLine());

            //    int index = LinearSearch(array, target);

            //    if (index != -1)
            //        Console.WriteLine($"Element found at index {index}.");
            //    else
            //        Console.WriteLine("Element not found.");
            //    Console.ReadLine();
            //}

            //static int LinearSearch(int[] array, int target)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] == target)
            //            return i; // Return the index of the target element
            //    }
            //    return -1; // Return -1 if the target is not found


            //}

            //Binary Search


            //    int[] arr = { 23, 5, 8, 12, 7, 15, 3 };  // Unsorted array
            //    Console.Write("Enter the element to search for: ");
            //    int target = int.Parse(Console.ReadLine());

            //    // Step 1: Sort the array
            //    Array.Sort(arr);
            //    Console.WriteLine("Sorted Array: " + string.Join(", ", arr));

            //    // Step 2: Perform binary search
            //    int index = BinarySearch(arr, target);

            //    if (index != -1)
            //        Console.WriteLine($"Element {target} found at index {index} in the sorted array.");
            //    else
            //        Console.WriteLine($"Element {target} not found in the array.");
            //    Console.ReadLine();
            //}

            //static int BinarySearch(int[] arr, int target)
            //{
            //    int left = 0;
            //    int right = arr.Length - 1;

            //    while (left <= right)
            //    {
            //        int mid = left + (right - left) / 2;

            //        if (arr[mid] == target)
            //            return mid;
            //        else if (arr[mid] < target)
            //            left = mid + 1;
            //        else
            //            right = mid - 1;
            //    }

            //    return -1;  // Target not found
            //}

            //------------------------------------------------------------------------------------------------//

            //4. Median 
            //    Console.WriteLine("Enter the number of elements:");
            //    int n = int.Parse(Console.ReadLine());

            //    int[] array = new int[n];
            //    Console.WriteLine("Enter the elements:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //    }

            //    Array.Sort(array);
            //    Array_Calculations arr4 = new Array_Calculations();
            //    double median = arr4.FindMedian(array);

            //    Console.WriteLine($"Median: {median}");
            //    Console.ReadLine();
            //}



            ////Mode
            //    Console.WriteLine("Enter the number of elements:");
            //    int n = int.Parse(Console.ReadLine());

            //    int[] array = new int[n];
            //    Console.WriteLine("Enter the elements:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //    }

            //    Array_Calculations arr3 = new Array_Calculations();
            //    int mode = arr3.FindMode(array);
            //    Console.WriteLine($"Mode: {mode}");
            //    Console.ReadLine();
            //}



            //Highest and second highest element

            //Asking user to input number of elements
            //    Console.WriteLine("Enter the number of elements:");
            //    int n = int.Parse(Console.ReadLine());

            //    //Initilaising array
            //    int[] array = new int[n];
            //    //Entering the array elements
            //    Console.WriteLine("Enter the elements:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //    }

            //    int highest, secondHighest;
            //    //Calling the FindHighestAndSecondHighest method
            //    Array_Calculations arr = new Array_Calculations();
            //    arr.FindHighestAndSecondHighest(array, out highest, out secondHighest);

            //    Console.WriteLine($"Highest: {highest}");
            //    Console.WriteLine($"Second Highest: {secondHighest}");
            //    Console.ReadLine();
            //}



            //Duplicate elements
            //    Console.WriteLine("Enter the number of elements:");
            //    int n = int.Parse(Console.ReadLine());

            //    int[] array = new int[n];
            //    Console.WriteLine("Enter the elements:");
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //    }
            //    //List to add the elements having duplicates
            //    Array_Calculations arr2 = new Array_Calculations();
            //    List<int> duplicates = arr2.FindDuplicates(array);

            //    if (duplicates.Count > 0)
            //    {
            //        Console.WriteLine("Duplicate elements: " + string.Join(", ", duplicates));
            //    }
            //    else
            //    {
            //        Console.WriteLine("No duplicates found.");
            //    }
            //    Console.ReadLine();
            //}


            //-----------------------------------------------------------------------------------//
            //5. Write a C# programs to count vowels, consonants and special characters.

            //    Console.WriteLine("Enter a string:");
            //    string input = Console.ReadLine();

            //    int vowelCount = 0;
            //    int consonantCount = 0;
            //    int specialCharCount = 0;

            //    // Loop through each character in the input string
            //    foreach (char ch in input)
            //    {
            //        // Check if the character is a letter
            //        if (char.IsLetter(ch))
            //        {
            //            // Check if it is a vowel
            //            if ("AEIOUaeiou".Contains(ch))
            //            {
            //                vowelCount++;
            //            }
            //            else
            //            {
            //                consonantCount++;
            //            }
            //        }
            //        // Check if the character is a special character
            //        else if (!char.IsWhiteSpace(ch) && !char.IsDigit(ch))
            //        {
            //            specialCharCount++;
            //        }
            //    }
            //    Console.WriteLine("Number of vowels: " + vowelCount);
            //    Console.WriteLine("Number of consonants: " + consonantCount);
            //    Console.WriteLine("Number of special characters: " + specialCharCount);
            //    Console.ReadLine();
            //}


            //5.Reverse string
            //    Console.WriteLine("Enter a string to reverse:");
            //    string input = Console.ReadLine();

            //    string reversedString = ReverseString(input);

            //    Console.WriteLine("Reversed string: " + reversedString);
            //    Console.ReadLine();
            //}

            //static string ReverseString(string str)
            //{
            //    char[] charArray = new char[str.Length]; // Create a new character array
            //    int j = 0;

            //    // Loop from the end of the string to the beginning
            //    for (int i = str.Length - 1; i >= 0; i--)
            //    {
            //        charArray[j] = str[i]; // Assign characters in reverse order
            //        j++;
            //    }

            //    return new string(charArray); // Convert character array back to string
            //}

            //7.Write a C# program to find substring occurrence within a main string. 

            // Input main string and substring
            //    Console.Write("Enter the main string: ");
            //    string mainString = Console.ReadLine();

            //    Console.Write("Enter the substring to find: ");
            //    string substring = Console.ReadLine();

            //    // Find the occurrences of the substring
            //    int count = FindSubstringOccurrences(mainString, substring);

            //    // Output the result
            //    Console.WriteLine($"\nThe substring '{substring}' appears {count} times in the main string.");
            //    Console.ReadLine();
            //}

            //static int FindSubstringOccurrences(string mainString, string substring)
            //{
            //    int count = 0;
            //    int index = 0;

            //    // Loop through the main string to find all occurrences of the substring
            //    while ((index = mainString.IndexOf(substring, index)) != -1)
            //    {
            //        count++;
            //        index += substring.Length;  // Move past the last found substring
            //    }

            //    return count;
            //}



            //8.. Write a C# program to convert string to uppercase, lowercase, and title case.
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Convert to Uppercase
            string upperCase = input.ToUpper();
            Console.WriteLine($"Uppercase: {upperCase}");

            // Convert to Lowercase
            string lowerCase = input.ToLower();
            Console.WriteLine($"Lowercase: {lowerCase}");

            // Convert to Title Case
            string titleCase = ToTitleCase(input);
            Console.WriteLine($"Title Case: {titleCase}");

            Console.ReadLine();

        }

        // Custom method to convert string to Title Case
        static string ToTitleCase(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    // Capitalize the first letter and make the rest of the letters lowercase
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                }
            }
            return string.Join(" ", words);
        }

        
            //9 Write a C# program to remove whitespace from a string. 
            //Console.WriteLine("Enter a string with white spaces");
            //string input = Console.ReadLine();
            //string result = input.Replace(" ", "");
            //Console.WriteLine($"String without whitespaces {result}");
            //Console.ReadLine();


            //10.Write a C# program to replace all occurrences of a substring.


            //Console.Write("Enter the main string: ");
            //string mainString = Console.ReadLine();

            //// Substring to replace
            //Console.Write("Enter the substring to replace: ");
            //string oldSubstring = Console.ReadLine();

            //// Replacement substring
            //Console.Write("Enter the new substring: ");
            //string newSubstring = Console.ReadLine();

            //// Replace all occurrences
            //string result = mainString.Replace(oldSubstring, newSubstring);

            //// Output result
            //Console.WriteLine("\nResulting string:");
            //Console.WriteLine(result);

            //Console.ReadLine();

            //11. Write a C# program to find the longest word in a sentence. 

            //Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();

            //// Split the sentence into words
            //string[] words = sentence.Split(' ');

            //// Find the longest word
            //string longestWord = "";
            //foreach (string word in words)
            //{
            //    if (word.Length > longestWord.Length)
            //    {
            //        longestWord = word;
            //    }
            //}

            //// Display the longest word
            //Console.WriteLine("The longest word is: " + longestWord);
            //Console.ReadLine();



            //12. Write a C# program to count words in a sentence.
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //// Split the sentence into words and count them
            //string[] words = sentence.Split(' ');
            //int wordCount = words.Length;

            //// Output result
            //Console.WriteLine("\nThe number of words in the sentence is: " + wordCount);
            //Console.ReadLine();

            //13.Write a C# program to remove duplicate characters from a string. 

            //    Console.Write("Enter a string: ");
            //    string input = Console.ReadLine();

            //    // Remove duplicate characters
            //    string result = RemoveDuplicates(input);

            //    // Output result
            //    Console.WriteLine("\nString after removing duplicates: " + result);
            //    Console.ReadLine();
            //}

            //static string RemoveDuplicates(string input)
            //{
            //    StringBuilder result = new StringBuilder();
            //    HashSet<char> seenCharacters = new HashSet<char>();

            //    foreach (char c in input)
            //    {
            //        if (!seenCharacters.Contains(c))
            //        {
            //            seenCharacters.Add(c);
            //            result.Append(c);
            //        }
            //    }

            //    return result.ToString();



            //14. Write a C# program to check if two strings are anagrams. 
            // Input strings
            //    Console.Write("Enter the first string: ");
            //    string str1 = Console.ReadLine();

            //    Console.Write("Enter the second string: ");
            //    string str2 = Console.ReadLine();

            //    // Check if the strings are anagrams
            //    bool areAnagrams = AreAnagrams(str1, str2);

            //    // Output result
            //    if (areAnagrams)
            //    {
            //        Console.WriteLine("\nThe strings are anagrams.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nThe strings are not anagrams.");
            //    }
            //    Console.ReadLine();
            //}

            //static bool AreAnagrams(string str1, string str2)
            //{
            //    // Convert strings to character arrays, sort them, and compare
            //    char[] arr1 = str1.ToLower().ToCharArray();
            //    char[] arr2 = str2.ToLower().ToCharArray();

            //    Array.Sort(arr1);
            //    Array.Sort(arr2);

            //    return new string(arr1) == new string(arr2);



            //15. Write a C# program to find the frequency of each character in a string.
            // Input string
            //    Console.Write("Enter a string: ");
            //    string input = Console.ReadLine();

            //    // Find and display character frequencies
            //    Dictionary<char, int> frequencies = GetCharacterFrequencies(input);

            //    Console.WriteLine("\nCharacter frequencies:");
            //    foreach (var pair in frequencies)
            //    {
            //        Console.WriteLine($"{pair.Key}: {pair.Value}");
            //    }
            //    Console.ReadLine();
            //}

            //static Dictionary<char, int> GetCharacterFrequencies(string input)
            //{
            //    Dictionary<char, int> frequencyDict = new Dictionary<char, int>();

            //    foreach (char c in input)
            //    {
            //        if (frequencyDict.ContainsKey(c))
            //        {
            //            frequencyDict[c]++;
            //        }
            //        else
            //        {
            //            frequencyDict[c] = 1;
            //        }
            //    }

            //    return frequencyDict;


            //16.Write a C# program to find the first non-repeating character in a string. 
            // Input string
            //Input string
            //    Console.Write("Enter a string: ");
            //    string input = Console.ReadLine();

            //    // Find and display the first non-repeating character
            //    char firstNonRepeatingChar = FindFirstNonRepeatingCharacter(input);

            //    if (firstNonRepeatingChar != '\0')
            //    {
            //        Console.WriteLine($"\nThe first non-repeating character is: {firstNonRepeatingChar}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nNo non-repeating character found.");
            //    }

            //    Console.ReadLine();
            //}

            //static char FindFirstNonRepeatingCharacter(string input)
            //{
            //    // Create a dictionary to store character frequencies
            //    Dictionary<char, int> frequencyDict = GetCharacterFrequencies(input);

            //    // Find the first non-repeating character
            //    foreach (char c in input)
            //    {
            //        if (frequencyDict[c] == 1)
            //        {
            //            return c;  // Return the first non-repeating character
            //        }
            //    }

            //    return '\0';  // Return null character if no non-repeating character is found
            //}

            //static Dictionary<char, int> GetCharacterFrequencies(string input)
            //{
            //    Dictionary<char, int> frequencyDict = new Dictionary<char, int>();

            //    foreach (char c in input)
            //    {
            //        if (frequencyDict.ContainsKey(c))
            //        {
            //            frequencyDict[c]++;
            //        }
            //        else
            //        {
            //            frequencyDict[c] = 1;
            //        }
            //    }

            //    return frequencyDict;


            //17.Write a C# program to reverse words in a sentence.

            // Input sentence
            //    Console.Write("Enter a sentence: ");
            //    string sentence = Console.ReadLine();

            //    // Reverse the words
            //    string reversedSentence = ReverseWords(sentence);

            //    // Output result
            //    Console.WriteLine("\nReversed sentence:");
            //    Console.WriteLine(reversedSentence);
            //    Console.ReadLine();
            //}

            //static string ReverseWords(string sentence)
            //{
            //    // Split the sentence into words
            //    string[] words = sentence.Split(' ');

            //    // Reverse the array of words
            //    Array.Reverse(words);

            //    // Join the reversed words back into a sentence
            //    return string.Join(" ", words);


            //18.Write a C# program to check if a string contains only digits.
            //    Console.Write("Enter a string: ");
            //    string input = Console.ReadLine();

            //    // Check if the string contains only digits
            //    bool isOnlyDigits = IsDigitsOnly(input);

            //    // Output result
            //    if (isOnlyDigits)
            //    {
            //        Console.WriteLine("\nThe string contains only digits.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nThe string contains characters other than digits.");
            //    }
            //    Console.ReadLine();
            //}

            //static bool IsDigitsOnly(string input)
            //{
            //    // Check if all characters in the string are digits
            //    foreach (char c in input)
            //    {
            //        if (!char.IsDigit(c))
            //        {
            //            return false; // If any character is not a digit, return false
            //        }
            //    }
            //    return true; // If all characters are digits, return true
            //}

        }




}

       


