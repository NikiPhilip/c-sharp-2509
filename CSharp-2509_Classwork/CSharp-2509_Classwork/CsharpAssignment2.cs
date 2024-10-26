using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C_sharpLabAssignmentsPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab1.Multiplication table of a given number
            //Console.WriteLine("Enter the number for the multiplication table");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"{number} x {i} = {number * i}");

            //}
            //Console.ReadLine();

            //Lab2 Display a right-angled triangle
            //Console.WriteLine("Enter number of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //for(int i=0;i<rows;i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();

            //Sum of all even numbers between 1 and 100 using while
            //int i = 1; int evensum = 0;
            //while(i<=100)
            //{
            //    if(i%2==0)
            //    {
            //        evensum += i;
            //    }
            //    i++;

            //}
            //Console.WriteLine($"The even sum is {evensum}");
            //Console.ReadLine();

            //qn 4 Write a C# program to print a multiplication table from 1 to 5 using nested while loops.
            //int i = 1;
            //while (i < 6)
            //{
            //    int j = 1;
            //    Console.WriteLine($"Multiplication table of {i} ");
            //    while (j <= 10)
            //    {

            //        Console.WriteLine($"{i} * {j}={i * j}");
            //        j++;
            //    }
            //    i++;
            //}
            //Console.ReadLine();

            //qn5 Write a C# program to keep asking the user to enter a positive number and print it. The program
            //should stop when the user enters a negative number.
            //Console.WriteLine("Enter a positive number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //while (number > 0)
            //{
            //    Console.WriteLine("Enter a number");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    number = num2;
            //}
            //Console.WriteLine("Negative number entered");
            //Console.ReadLine();

            //qn 6 Write a C# program to create a basic menu-driven calculator using nested do-while loops. The
            //calculator should continue to ask the user for two numbers and an operation(+, -, *, /) until the
            //user chooses to exit.


            //Console.ReadLine();


            //    char option;
            //    do
            //    {
            //        int choice;
            //        do
            //        {
            //            // Display the menu to the user
            //            Console.WriteLine("\nBasic Calculator Menu:");
            //            Console.WriteLine("1. Addition (+)");
            //            Console.WriteLine("2. Subtraction (-)");
            //            Console.WriteLine("3. Multiplication (*)");
            //            Console.WriteLine("4. Division (/)");
            //            Console.WriteLine("5. Exit");
            //            Console.Write("Enter your choice (1-5): ");

            //            // Read the user's choice
            //            choice = Convert.ToInt32(Console.ReadLine());

            //            // Check if the user chose a valid option
            //            if (choice < 1 || choice > 5)
            //            {
            //                Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
            //            }

            //        } while (choice < 1 || choice > 5); // Repeat until a valid option (1-5) is chosen

            //        // Exit if the user selects option 5
            //        if (choice == 5)
            //        {
            //            Console.WriteLine("Exiting the calculator. Goodbye!");
            //            break;
            //        }

            //        // Input two numbers from the user
            //        Console.Write("Enter the first number: ");
            //        double num1 = Convert.ToDouble(Console.ReadLine());

            //        Console.Write("Enter the second number: ");
            //        double num2 = Convert.ToDouble(Console.ReadLine());

            //        // Perform the chosen operation using a switch statement
            //        double result = 0;
            //        bool validOperation = true;

            //        switch (choice)
            //        {
            //            case 1:
            //                result = num1 + num2;
            //                Console.WriteLine($"Result: {num1} + {num2} = {result}");
            //                break;
            //            case 2:
            //                result = num1 - num2;
            //                Console.WriteLine($"Result: {num1} - {num2} = {result}");
            //                break;
            //            case 3:
            //                result = num1 * num2;
            //                Console.WriteLine($"Result: {num1} * {num2} = {result}");
            //                break;
            //            case 4:
            //                if (num2 != 0)
            //                {
            //                    result = num1 / num2;
            //                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Error: Division by zero is not allowed.");
            //                    validOperation = false;
            //                }
            //                break;
            //        }

            //        if (validOperation)
            //        {
            //            Console.WriteLine("Operation successful.");
            //        }

            //        // Ask the user if they want to perform another calculation
            //        Console.Write("Do you want to perform another calculation? (y/n): ");
            //        option = Convert.ToChar(Console.ReadLine().ToLower());

            //    } while (option == 'y'); // Outer loop continues until the user enters 'n'

            //    Console.WriteLine("Thank you for using the calculator.");

            //}




            //qn7Write a C# program to print all numbers from 1 to 100. Use the continue statement to skip
            //numbers that are divisible by 3, and use the break statement to stop the loop if the number
            //exceeds 50.

            //for (int i = 0; i < 101; i +=1)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;

            //    }


            //    else if(i>50)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //lab 8 
            // Write a C# program to calculate the sum of all odd numbers between 1 and 100 using a for loop.
            //int sum = 0;
            //for(int i=1;i<101; i++)
            //{
            //   if(i%2!=0)
            //    {
            //        sum = sum + i;
            //    }

            //}
            //Console.WriteLine($"Sum of odd numbers is {sum}");
            //Console.ReadLine();


            //lab 9 Write a C# program to calculate the factorial of a given number using a while loop.
            //Console.WriteLine("Enter number to find factorial");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int fact = 1;
            //while(num>0)
            //{
            //    fact = fact*(num);
            //    num--;
            //}
            //Console.WriteLine($"Factorial is {fact}");
            //Console.ReadLine();


            //lab 10 Write a C# program to print a number pyramid using a nested while loop. Example for 5 rows:
            //1
            //2 2
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5

            //Console.Write("Enter the number of rows for the pyramid: ");
            //int rows = Convert.ToInt32(Console.ReadLine()); // Read and convert the input to an integer

            //int i = 1;

            //while (i <= rows)
            //{
            //    int j = 1;

            //    while (j <= i)
            //    {
            //        Console.Write(i + " ");
            //        j++;
            //    }

            //    Console.WriteLine(); // Move to the next line after each row
            //    i++; // Move to the next row
            //}
            //Console.ReadLine();

            //lab 11
            Random random = new Random();  // Create a Random object to generate random numbers
            string playAgain;

            do
            {
                int randomNumber = random.Next(1, 101);  // Generate a random number between 1 and 100
                int userGuess = 0;  // Initialize user's guess
                int attempts = 0;    // Track the number of attempts

                Console.WriteLine("\nI have generated a random number between 1 and 100. Try to guess it!");

                // Guessing loop: keep asking for a guess until the correct number is guessed
                do
                {
                    Console.Write("Enter your guess: ");
                    bool isValid = Int32.TryParse(Console.ReadLine(), out userGuess);

                    // Validate the user's input
                    if (!isValid || userGuess < 1 || userGuess > 100)
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 100.");
                        continue;
                    }

                    attempts++;  // Increment the number of attempts

                    // Provide hints to the user
                    if (userGuess > randomNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else if (userGuess < randomNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You've guessed the number {randomNumber} correctly in {attempts} attempts.");
                    }

                } while (userGuess != randomNumber);  // Continue until the user guesses correctly

                // Ask if the user wants to play another round
                Console.Write("Do you want to play again? (y/n): ");
                playAgain = Console.ReadLine().ToLower();

            } while (playAgain == "y");  // Continue the game if the user chooses 'y'

            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();


            //lab12 Write a C# program to create a simple calculator using a switch-case statement. The program
            //should handle addition, subtraction, multiplication, and division.


            //double num1, num2, result;
            //char operation;
            //char continueChoice;

            //do
            //{
            //    Console.WriteLine("Enter the first number:");
            //    num1 = Double.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the second number:");
            //    num2 = Double.Parse(Console.ReadLine());

            //    do
            //    {
            //        Console.WriteLine("Choose an operation (+, -, *, /):");
            //        operation = Console.ReadKey().KeyChar;
            //        Console.WriteLine(); // Move to the next line

            //        switch (operation)
            //        {
            //            case '+':
            //                result = num1 + num2;
            //                Console.WriteLine($"Result: {num1} + {num2} = {result}");
            //                break;
            //            case '-':
            //                result = num1 - num2;
            //                Console.WriteLine($"Result: {num1} - {num2} = {result}");
            //                break;
            //            case '*':
            //                result = num1 * num2;
            //                Console.WriteLine($"Result: {num1} * {num2} = {result}");
            //                break;
            //            case '/':
            //                if (num2 != 0)
            //                {
            //                    result = num1 / num2;
            //                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Error: Division by zero is not allowed.");
            //                }
            //                break;
            //            default:
            //                Console.WriteLine("Invalid operation. Please choose a valid operation.");
            //                continue; // Continue asking for a valid operation
            //        }

            //    } while (operation != '+' && operation != '-' && operation != '*' && operation != '/');

            //    Console.WriteLine("Continue (y/n):");
            //    continueChoice = Console.ReadKey().KeyChar;
            //    //Console.WriteLine(); // Move to the next line

            //} while (continueChoice == 'y' || continueChoice == 'Y');

            //Console.WriteLine("*END*");

            //qn13 Write a C# program that accepts a number from the user and calculates the sum of its digits using 
            //a do-while loop. 

            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //do
            //{
            //    int dig = number % 10;
            //    sum = sum+ dig;
            //    number = number / 10;


            //}
            //while (number > 0);
            //Console.WriteLine($"Sum of digits is {sum}");
            //Console.ReadLine();

            //qn14
            // Write a C# program that accepts 10 numbers from the user and finds the largest number using a 
            //for loop.
            //Console.WriteLine("Enter 10 numbers");
            //int[] nums= new int[10]; int largest=nums[0];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Enter number {i + 1}");
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=0;i<10;i++)
            //{
            //    if (nums[i] > largest)
            //    {
            //         largest = nums[i];
            //    }

            //}
            //Console.WriteLine($"The largest number is {largest}");
            //Console.ReadLine();

            //qn15 Write a C# program to calculate the sum of squares of all numbers from 1 to a user-provided 
            //number using a while loop.
            //Console.WriteLine("Enter a number till to find the sum of squares");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while(num>0)
            //{
            //    sum = sum + (num * num);
            //    num--;
            //}

            //Console.WriteLine($"Sum of numbers is {sum}");
            //Console.ReadLine();

            //qn 16
            //Write a C# program to simulate a countdown timer from 10 to 1 using a do-while loop, 
            //displaying each second.
            //int i = 10;
            //do
            //{
            //    Console.WriteLine(i);
            //    i--;
            //    Thread.Sleep(1000);
            //}
            //while (i > 0);
            //Console.WriteLine("Countdown complete");
            //Console.ReadLine();

            //qn17 Write a C# program to find and print the first multiple of 5 in a given list of numbers. Use the 
            //break statement to exit the loop once a multiple of 5 is found.

            //Console.WriteLine("Enter size of list");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr= new int[size];
            //for(int i=0;i<size; i++)
            //{
            //    Console.WriteLine($"Enter number {i + 1} ");
            //    arr[i]= Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=0;i<size;i++)
            //{
            //    if (arr[i]%5==0)
            //    {
            //        Console.WriteLine($"First multiple of 5 is {arr[i]}");
            //        break;
            //    }
            //}


            //Console.ReadLine();

            //qn 18
            //            Write a C# program to print numbers from 1 to 20, but skip numbers that are divisible by 3 using 
            //the continue statement.

            //for(int i=1;i<=20;i++)
            //{
            //    if(i%3==0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();

            //qn19 Write a C# program to check if a given number is a palindrome using a while loop.
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int rev = 0;
            //int num = number;
            //while (num>0)
            //{
            //    int dig = num % 10;
            //    num /=10;
            //    rev = (rev * 10) + dig;
            //}
            //Console.WriteLine(rev);
            //if(number==rev)
            //{
            //    Console.WriteLine($"{number} is a palindrome");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a palindrome");
            //}
            //Console.ReadLine();

            //qn 20 Write a C# program to calculate the average of positive numbers entered by the user. The 
            // program should stop when the user enters a negative number using a do -while loop.


            //int sum = 0;    // Variable to store the sum of positive numbers
            //int count = 0;  // Variable to count how many positive numbers were entered
            //int number;     // Variable to store user input

            //// Use a do-while loop to repeatedly ask for input
            //do
            //{
            //    Console.Write("Enter a positive number (or a negative number to stop): ");
            //    number = Convert.ToInt32(Console.ReadLine());

            //    // If the number is positive, add it to the sum and increment the count
            //    if (number >= 0)
            //    {
            //        sum += number;
            //        count++;
            //    }
            //} while (number >= 0);  // The loop continues as long as the input is non-negative

            //// Calculate the average if at least one positive number was entered
            //if (count > 0)
            //{
            //    double average = (double)sum / count;
            //    Console.WriteLine("The average of the positive numbers is: " + average);
            //}
            //else
            //{
            //    Console.WriteLine("No positive numbers were entered.");
            //}
            //Console.ReadLine();

            //qn21 Write a C# program to reverse a given number using a do-while loop.

            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int num=number; int rev=0;
            //do
            //{
            //    int dig = num % 10;
            //    rev = (rev * 10) + dig;
            //    num /= 10;
            //}
            //while (num > 0);
            //Console.WriteLine($"Reverse of {number} is {rev}");
            //Console.ReadLine();

            //qn22 Write a C# program that presents a menu to the user for various string operations: 
            //            1.Reverse the string
            //2.Convert to uppercase
            //3.Convert to lowercase
            //4.Find the length of the string
            //Use a switch-case statement to implement this.
            //string input;
            //int choice;

            //Console.WriteLine("Enter a string: ");
            //input = Console.ReadLine();  // Take input string from the user

            //do
            //{
            //    // Display the menu
            //    Console.WriteLine("\nChoose an operation:");
            //    Console.WriteLine("1. Reverse the string");
            //    Console.WriteLine("2. Convert to uppercase");
            //    Console.WriteLine("3. Convert to lowercase");
            //    Console.WriteLine("4. Find the length of the string");
            //    Console.WriteLine("5. Exit");
            //    Console.Write("Enter your choice (1-5): ");

            //    // Take the user's choice and convert to an integer
            //    bool validChoice = Int32.TryParse(Console.ReadLine(), out choice);

            //    // Perform the operation based on user's choice
            //    if (validChoice)
            //    {
            //        switch (choice)
            //        {
            //            case 1:
            //                // Reverse the string
            //                char[] charArray = input.ToCharArray();
            //                Array.Reverse(charArray);
            //                string reversedString = new string(charArray);
            //                Console.WriteLine($"Reversed string: {reversedString}");
            //                break;

            //            case 2:
            //                // Convert to uppercase
            //                string upperString = input.ToUpper();
            //                Console.WriteLine($"Uppercase string: {upperString}");
            //                break;

            //            case 3:
            //                // Convert to lowercase
            //                string lowerString = input.ToLower();
            //                Console.WriteLine($"Lowercase string: {lowerString}");
            //                break;

            //            case 4:
            //                // Find the length of the string
            //                int length = input.Length;
            //                Console.WriteLine($"Length of the string: {length}");
            //                break;

            //            case 5:
            //                // Exit
            //                Console.WriteLine("Exiting the program...");
            //                break;

            //            default:
            //                // If an invalid choice is entered
            //                Console.WriteLine("Invalid choice! Please enter a number between 1 and 5.");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        // Handle invalid input (not a number)
            //        Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
            //    }

            //} while (choice != 5);  // Continue until the user chooses to exit (option 5)


            //qn23  Write a C# program to print numbers from 1 to 50 but skip numbers that are divisible by 4 using 
            //the continue statement.
            //for (int i = 1; i <= 50; i++)
            //{
            //    // If the number is divisible by 4, skip it
            //    if (i % 4 == 0)
            //    {
            //        continue; // Skip the current iteration
            //    }

            //    // Print the number if it's not divisible by 4
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //qn 24 Write a C# program to print the first 10 numbers in the Fibonacci sequence using a for loop. 
            // Variables to hold the first two numbers of the Fibonacci sequence
            //int firstNumber = 0, secondNumber = 1, nextNumber;

            //Console.WriteLine("The first 10 numbers in the Fibonacci sequence are:");

            //// Print the first two numbers
            //Console.WriteLine(firstNumber);
            //Console.WriteLine(secondNumber);

            //// Use a for loop to generate the next 8 numbers (since first two are already printed)
            //for (int i = 2; i < 10; i++) // Start from index 2 since 0 and 1 are already printed
            //{
            //    nextNumber = firstNumber + secondNumber;  // Calculate the next Fibonacci number
            //    Console.WriteLine(nextNumber);            // Print the next Fibonacci number

            //    // Update the first and second numbers
            //    firstNumber = secondNumber;
            //    secondNumber = nextNumber;
            //}
            //Console.ReadLine();


            //qn25Write a C# program to find all Armstrong numbers between 1 and 500 using a while loop. (An 
            //Armstrong number is a number that is equal to the sum of the cubes of its digits)
            //int number = 1;

            //Console.WriteLine("Armstrong numbers between 1 and 500 are:");

            //// Use a while loop to check each number between 1 and 500
            //while (number <= 500)
            //{
            //    int sum = 0;
            //    int temp = number;  // Store the current number in a temporary variable
            //    int digits;

            //    // Calculate the sum of the cubes of the digits of the number
            //    while (temp > 0)
            //    {
            //        digits = temp % 10;     // Extract the last digit
            //        sum += digits * digits * digits;  // Add the cube of the digit to sum
            //        temp /= 10;             // Remove the last digit
            //    }

            //    // If the sum of the cubes of the digits equals the original number, it is an Armstrong number
            //    if (sum == number)
            //    {
            //        Console.WriteLine(number);  // Print the Armstrong number
            //    }

            //    number++;  // Increment the number for the next iteration
            //}
            //Console.ReadLine();

            //qn26 Write a C# program to create a menu-driven system for number conversions: 
            //            1.Binary to Decimal
            //2.Decimal to Binary
            //3.Decimal to Hexadecimal
            //Use a switch-case statement to implement this.
            //int choice;

            //do
            //{
            //    // Display the menu
            //    Console.WriteLine("\nChoose a conversion:");
            //    Console.WriteLine("1. Binary to Decimal");
            //    Console.WriteLine("2. Decimal to Binary");
            //    Console.WriteLine("3. Decimal to Hexadecimal");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Enter your choice (1-4): ");

            //    // Read the user's choice and convert to an integer
            //    bool validChoice = Int32.TryParse(Console.ReadLine(), out choice);

            //    if (validChoice)
            //    {
            //        switch (choice)
            //        {
            //            case 1:
            //                // Binary to Decimal Conversion
            //                Console.Write("Enter a binary number: ");
            //                string binaryInput = Console.ReadLine();

            //                try
            //                {
            //                    // Convert binary to decimal
            //                    int decimalResult = Convert.ToInt32(binaryInput, 2);
            //                    Console.WriteLine($"Binary {binaryInput} in decimal is {decimalResult}");
            //                }
            //                catch (FormatException)
            //                {
            //                    Console.WriteLine("Invalid binary number format.");
            //                }
            //                break;

            //            case 2:
            //                // Decimal to Binary Conversion
            //                Console.Write("Enter a decimal number: ");
            //                int decimalInput;
            //                if (Int32.TryParse(Console.ReadLine(), out decimalInput))
            //                {
            //                    // Convert decimal to binary
            //                    string binaryResult = Convert.ToString(decimalInput, 2);
            //                    Console.WriteLine($"Decimal {decimalInput} in binary is {binaryResult}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid decimal number.");
            //                }
            //                break;

            //            case 3:
            //                // Decimal to Hexadecimal Conversion
            //                Console.Write("Enter a decimal number: ");
            //                if (Int32.TryParse(Console.ReadLine(), out decimalInput))
            //                {
            //                    // Convert decimal to hexadecimal
            //                    string hexResult = Convert.ToString(decimalInput, 16).ToUpper();
            //                    Console.WriteLine($"Decimal {decimalInput} in hexadecimal is {hexResult}");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Invalid decimal number.");
            //                }
            //                break;

            //            case 4:
            //                // Exit the program
            //                Console.WriteLine("Exiting the program...");
            //                break;

            //            default:
            //                // Handle invalid choice
            //                Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        // Handle invalid input (not a number)
            //        Console.WriteLine("Invalid input! Please enter a number between 1 and 4.");
            //    }

            //} while (choice != 4);  // Continue until the user chooses to exit (option 4)

            //qn 27Write a C# program to reverse a given string using a for loop.
            // Ask the user to input a string
            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();

            //// Initialize an empty string to store the reversed string
            //string reversedString = "";

            //// Use a for loop to reverse the string
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversedString += input[i];  // Append characters from the end to the beginning
            //}

            //// Display the reversed string
            //Console.WriteLine($"Reversed string: {reversedString}");
            //Console.ReadLine();

            //qn 28 Write a C# program to count the number of vowels and consonants in a given string using a for 
            //loop.

            //// Ask the user to input a string
            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();

            //// Convert the input string to lowercase to make comparison easier
            //input = input.ToLower();

            //// Variables to hold counts of vowels and consonants
            //int vowelCount = 0;
            //int consonantCount = 0;

            //// Use a for loop to iterate through each character in the string
            //for (int i = 0; i < input.Length; i++)
            //{
            //    char ch = input[i];  // Current character

            //    // Check if the character is a vowel
            //    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //    {
            //        vowelCount++;  // Increment vowel count
            //    }
            //    // Check if the character is a consonant (a letter that's not a vowel)
            //    else if (ch >= 'a' && ch <= 'z')
            //    {
            //        consonantCount++;  // Increment consonant count
            //    }
            //}

            //// Display the counts
            //Console.WriteLine($"Number of vowels: {vowelCount}");
            //Console.WriteLine($"Number of consonants: {consonantCount}");
            //Console.ReadLine();

            //qn 29 Write a C# program to find the maximum and minimum of 5 numbers entered by the user using a 
            //for loop.
            //int max = int.MinValue;  // Initialize max to the smallest possible integer value
            //int min = int.MaxValue;  // Initialize min to the largest possible integer value

            //// Ask the user to enter 5 numbers
            //Console.WriteLine("Enter 5 numbers:");

            //// Use a for loop to read 5 numbers from the user
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"Enter number {i}: ");
            //    int num = Convert.ToInt32(Console.ReadLine());  // Read and convert the input to an integer

            //    // Update the maximum value if the current number is greater than the current max
            //    if (num > max)
            //    {
            //        max = num;
            //    }

            //    // Update the minimum value if the current number is smaller than the current min
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //}

            // Display the maximum and minimum numbers
            //Console.WriteLine($"Maximum number: {max}");
            //Console.WriteLine($"Minimum number: {min}");
            //Console.ReadLine();

            //qn 30 Write a C# program to count the number of digits in a given number using a while loop.
            //Console.WriteLine("Enter the number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int num = number;int count = 0;
            //while (num > 0)
            //{
            //    int dig = num % 10;
            //    count++;
            //    num /= 10;
            //}
            //Console.WriteLine($"Number of digits of {number} are {count}");
            //Console.ReadLine();
        }
    }
}


