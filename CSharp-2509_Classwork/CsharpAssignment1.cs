using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignmentconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello,World!");
            //Console.WriteLine("Enter username");
            //string username = Console.ReadLine();
            //Console.WriteLine($"Hello how are you,{username}");
            //Console.ReadLine();

            //Console.WriteLine("Enter your full name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your favourite colour");
            //string color = Console.ReadLine();
            //Console.WriteLine($"Hello, {name}! You are {age} years old and favourite colour is {color}");
            //Console.ReadLine();


            //Console.WriteLine("Enter first number");
            //double num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Sum is {num1 + num2}");
            //Console.WriteLine($"Difference is {num1 - num2} ");
            //Console.WriteLine($"Multiplication is {num1 * num2} ");
            //double div = 0;
            //if (num2 != 0)
            //{
            //    div = (double)(num1 / num2);
            //    Console.WriteLine($"Division is {div}");
            //}
            //else
            //{
            //    Console.WriteLine("Division not possible");
            //}

            //Console.ReadLine();

            //qn4
            //Console.WriteLine("Enter temperature");
            //double temp = Double.Parse(Console.ReadLine());

            //double fahr = (temp * 9 / 5) + 32;
            //Console.WriteLine($"Fahrenheit temperature is {fahr}");
            //Console.ReadLine();


            //qn5
            //Console.WriteLine("Enter principal amount");
            //double principal = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter rate");
            //double rate = Double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter time in years");
            //double time = Double.Parse(Console.ReadLine());
            //double interest = (principal * rate * time / 100);
            ////calculating simple interest
            //Console.WriteLine("Simple Interest is " + interest);
            //Console.ReadLine();


            //qn6
            //Console.WriteLine("Enter radius");
            //double radius =Double.Parse(Console.ReadLine());
            //const double PI = 3.14;
            //double area = PI * radius*radius;
            //Console.WriteLine("Area is " + area);
            //Console.ReadLine();


            //qn7
            //Console.WriteLine("Enter time in seconds");
            //int totalSeconds = Convert.ToInt32(Console.ReadLine());
            //int hours = totalSeconds / 3600;
            //int minutes = (totalSeconds % 3600) / 60;
            //int seconds = totalSeconds % 60;
            //Console.WriteLine($"Time in hours {hours}");
            //Console.WriteLine($"Time in minutes {minutes}");
            //Console.WriteLine($"Time in seconds {seconds}");
            //Console.ReadLine();

            //qn8
            //Console.WriteLine("Enter string");
            //string input = Console.ReadLine();
            //string trimmedInput = input.Replace(" ", "");
            //int length = trimmedInput.Length;
            //Console.WriteLine($"Output is {trimmedInput} and Length is {length}");
            //Console.ReadLine();

            //qn9
            //Console.WriteLine("Enter weight and height");
            //double weight = Double.Parse( Console.ReadLine());
            //double height = Double.Parse( Console.ReadLine());
            //double BMI = weight/(height*height);
            //Console.WriteLine($"BMI is {BMI}");
            //Console.ReadLine();

            //qn10

            //int Integer = 23;
            //float Floatnumber = 23.3444f;
            //double Doublenum = 12.732;
            //char letter = 'a';
            //string input = "School";
            //bool Boolean = false;
            //Console.WriteLine($"Int is {Integer}");
            //Console.WriteLine($"Double is {Doublenum}");
            //Console.WriteLine($"Character is {letter}");
            //Console.WriteLine($"String is {input}");
            //Console.WriteLine($"Float is {Floatnumber}");
            //Console.WriteLine($"Boolean is {Boolean}");
            //Console.ReadLine();


            //qn11

            //Console.WriteLine("Enter radius");
            //double radius = Double.Parse(Console.ReadLine());
            //const double PI = 3.1415;
            //double circlearea = PI * radius * radius;
            //Console.WriteLine("Enter Length and Breadth");
            //double length = Double.Parse(Console.ReadLine());
            //double breadth = Double.Parse(Console.ReadLine());
            //double rectanglearea = length * breadth;

            //Console.WriteLine($"Circle area is {circlearea}");
            //Console.WriteLine($"Rectangle Area is {rectanglearea}");
            //Console.ReadLine();


            //qn12
            //const double PI = 3.14159;
            //const int DAYS_IN_WEEK = 7;
            //Console.WriteLine("Enter Radius");
            //double radius = Double.Parse(Console.ReadLine());
            //double circumference = 2 * PI * radius;
            //Console.WriteLine($"Circumeference of circle is {circumference} and days in a week are {DAYS_IN_WEEK}");
            //Console.ReadLine();

            //qn13Declare two variables width and height for the dimensions of a rectangle. Calculate the area 
            //using the formula Area = width * height.Use constants to define conversion factors, for
            //example, inches to centimeters.Print the area in both square inches and square centimeters.

            //Console.WriteLine("Enter weight and height in inches");
            //double width = Double.Parse( Console.ReadLine() );
            //double height = Double.Parse( Console.ReadLine() );
            //const double centimetres = 6.45;
            //double area = width * height;
            //double areacentimetres = area * centimetres;
            //Console.WriteLine($"Area is inches is {area} and area in centimtres is {areacentimetres}");
            //Console.ReadLine();


            //qn14 Write a simple C# program to accept an employee’s name, age and monthly salary and display 
            //them on the screen. The code should be written following the coding standards, including proper
            //naming conventions, indentation, comments, and meaningful variable names.

            //Asking user to input employee name
            //Console.WriteLine("Enter employee name");
            //string employee_name = Console.ReadLine();
            //Asling user to input employee age
            //Console.WriteLine("Enter age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Asking user to input monthly salary
            //Console.WriteLine("Enter monthly salary");
            //int salary = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The employee name is {employee_name} and employee age is {age} " +
            //                    $"and employee's monthly salary is {salary}");
            //Console.ReadLine();

            //qn15
            //Refactor a provided C# program to follow proper coding standards (naming conventions, 
            //comments, etc.).

            //Declaring 2 numbers
            //    int number1 = 5;
            //    int number2 = 3;
            ////Taking the sum of two numbers and displaying it
            //    Console.WriteLine($"The sum of two numbers are {number1 + number2}");
            //    Console.ReadLine();

            //qn 16 Write a program demonstrating the use of the assignment operator = to assign values to variables. 
            // Declare variables
            //int num1, num2;
            //double num3;
            //string text;

            //// Assign values using the assignment operator
            //num1 = 10;  // Assign an integer value to num1
            //num2 = 20;  // Assign an integer value to num2
            //num3 = 15.5;  // Assign a double value to num3
            //text = "Hello, World!";  // Assign a string value to text

            //qn 16Display the assigned values
            //Console.WriteLine("Value of num1: " + num1);
            //Console.WriteLine("Value of num2: " + num2);
            //Console.WriteLine("Value of num3: " + num3);
            //Console.WriteLine("Value of text: " + text);
            //Console.ReadLine();

            //qn17 Write a C# program that calculates the power of a number using the math.pow
            //Console.Write("Enter the base number: ");
            //double baseNumber = Convert.ToDouble(Console.ReadLine());

            //// Ask the user to input the exponent
            //Console.Write("Enter the exponent: ");
            //double exponent = Convert.ToDouble(Console.ReadLine());

            //// Calculate the power using Math.Pow()
            //double result = Math.Pow(baseNumber, exponent);

            //// Display the result
            //Console.WriteLine($"{baseNumber} raised to the power of {exponent} is: {result}");
            //Console.ReadLine();

            //qn 18 Write a C# program that checks if a person is eligible to vote. The eligibility criteria are: 
            // The person must be at least 18 years old. 
            // The person must be a citizen. 
            //The program should take the age and citizenship status as input from the user.
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //// Ask the user to input their citizenship status (Y for Yes, N for No)
            //Console.Write("Are you a citizen? (Y/N): ");
            //string isCitizen = Console.ReadLine().ToUpper();

            //// Check if the person is eligible to vote
            //if (age >= 18 && isCitizen == "Y")
            //{
            //    Console.WriteLine("You are eligible to vote.");
            //}
            //else if (age < 18)
            //{
            //    Console.WriteLine("You are not eligible to vote because you are under 18.");
            //}
            //else if (isCitizen != "Y")
            //{
            //    Console.WriteLine("You are not eligible to vote because you are not a citizen.");
            //}
            //Console.ReadLine();
            //     qn 19      Write a C# program to check if a person is eligible for a loan. The eligibility criteria are: 
            // The person must be at least 21 years old. 
            // The person must earn at least $30,000 per year. 
            // The person must not have any outstanding loans. 
            //The program should take the age, income, and loan status(yes/ no) as input.
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //// Ask the user to input their annual income
            //Console.Write("Enter your annual income: ");
            //double income = Convert.ToDouble(Console.ReadLine());

            //// Ask the user if they have any outstanding loans (Y for Yes, N for No)
            //Console.Write("Do you have any outstanding loans? (Y/N): ");
            //string hasOutstandingLoans = Console.ReadLine().ToUpper();

            //// Check the eligibility for the loan
            //if (age >= 21 && income >= 30000 && hasOutstandingLoans == "N")
            //{
            //    Console.WriteLine("You are eligible for a loan.");
            //}
            //else
            //{
            //    if (age < 21)
            //    {
            //        Console.WriteLine("You are not eligible for a loan because you are under 21.");
            //    }
            //    if (income < 30000)
            //    {
            //        Console.WriteLine("You are not eligible for a loan because your income is less than $30,000.");
            //    }
            //    if (hasOutstandingLoans == "Y")
            //    {
            //        Console.WriteLine("You are not eligible for a loan because you have outstanding loans.");
            //    }

            //}
            //Console.ReadLine();

            //qn 20Write a C# program that checks whether a person is eligible to apply for a job based on the 
            //            following criteria: 
            //1.The person must be between 18 and 35 years old. 
            //2.The person must have at least 2 years of work experience. 
            //3.The person must either have a college degree or 5 years of work experience.

            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //// Prompt the user to enter their years of work experience
            //Console.Write("Enter your work experience (in years): ");
            //int workExperience = Convert.ToInt32(Console.ReadLine());

            //// Prompt the user to enter if they have a college degree (Y for Yes, N for No)
            //Console.Write("Do you have a college degree? (Y/N): ");
            //string hasCollegeDegree = Console.ReadLine().ToUpper();

            //// Check eligibility based on the provided conditions
            //if (age >= 18 && age <= 35 && workExperience >= 2 &&
            //   (hasCollegeDegree == "Y" || workExperience >= 5))
            //{
            //    Console.WriteLine("You are eligible to apply for the job.");
            //}
            //else
            //{
            //    // Display the specific reason for ineligibility
            //    if (age < 18 || age > 35)
            //    {
            //        Console.WriteLine("You are not eligible because your age is not between 18 and 35.");
            //    }

            //    if (workExperience < 2)
            //    {
            //        Console.WriteLine("You are not eligible because you have less than 2 years of work experience.");
            //    }

            //    if (hasCollegeDegree != "Y" && workExperience < 5)
            //    {
            //        Console.WriteLine("You are not eligible because you need either a college degree or at least 5 years of work experience.");
            //    }
            //}
            //Console.ReadLine();

            //qn 21 Write a C# program that takes a character as input and checks if the character is a vowel or 
            //consonant using relational and logical operators.
            //Console.Write("Enter a character: ");
            //char inputChar = Console.ReadLine()[0]; // Read the first character from the input

            //// Convert the character to lowercase for uniformity
            //char lowerChar = char.ToLower(inputChar);

            //// Check if the character is a vowel
            //if (lowerChar >= 'a' && lowerChar <= 'z') // Check if it's a valid alphabet character
            //{
            //    if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
            //    {
            //        Console.WriteLine($"{inputChar} is a vowel.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{inputChar} is a consonant.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{inputChar} is not a valid alphabet character.");
            //}
            //Console.ReadLine();

            //qn 22Write a C# program that takes a number as input and checks whether the number is positive, 
            //negative, or zero using relational and logical operators. 
            //Console.Write("Enter a number: ");
            //double number = Convert.ToDouble(Console.ReadLine());

            //// Check if the number is positive, negative, or zero
            //if (number > 0)
            //{
            //    Console.WriteLine($"{number} is positive.");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine($"{number} is negative.");
            //}
            //else // This means number == 0
            //{
            //    Console.WriteLine("The number is zero.");
            //}
            //Console.ReadLine();

            //qn23 Write a C# program that checks if a number is divisible by both 5 and 11. 
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //// Check if the number is divisible by both 5 and 11
            //if (number % 5 == 0 && number % 11 == 0)
            //{
            //    Console.WriteLine($"{number} is divisible by both 5 and 11.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not divisible by both 5 and 11.");
            //}
            //Console.ReadLine();

            //qn 24 Write a C# program that takes two numbers and an operator (+, -, *, /) as input, and performs the 
            //orresponding operation. Use an if-else statement to determine which operation to perform

            //Console.Write("Enter the first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //// Prompt the user to enter the second number
            //Console.Write("Enter the second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //// Prompt the user to enter an operator
            //Console.Write("Enter an operator (+, -, *, /): ");
            //char operatorChoice = Console.ReadLine()[0]; // Read the first character

            //// Variable to store the result
            //double result = 0;

            //// Determine the operation based on the operator choice
            //if (operatorChoice == '+')
            //{
            //    result = num1 + num2;
            //    Console.WriteLine($"{num1} + {num2} = {result}");
            //}
            //else if (operatorChoice == '-')
            //{
            //    result = num1 - num2;
            //    Console.WriteLine($"{num1} - {num2} = {result}");
            //}
            //else if (operatorChoice == '*')
            //{
            //    result = num1 * num2;
            //    Console.WriteLine($"{num1} * {num2} = {result}");
            //}
            //else if (operatorChoice == '/')
            //{
            //    // Check for division by zero
            //    if (num2 != 0)
            //    {
            //        result = num1 / num2;
            //        Console.WriteLine($"{num1} / {num2} = {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Division by zero is not allowed.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid operator entered.");
            //}
            //Console.ReadLine();

            //qn 25 Write a C# program that accepts the marks of a student in a subject and assigns a grade based on 
            //the following criteria:
            // Prompt the user to enter the marks
            //Console.Write("Enter the marks (out of 100): ");
            //int marks = Convert.ToInt32(Console.ReadLine());

            //// Determine the grade using nested if statements
            //if (marks >= 90)
            //{
            //    Console.WriteLine("Grade: A");
            //}
            //else if (marks >= 80 && marks < 90)
            //{
            //    Console.WriteLine("Grade: B");
            //}
            //else if (marks >= 70 && marks < 80)
            //{
            //    Console.WriteLine("Grade: C");
            //}
            //else if (marks >= 60 && marks < 70)
            //{
            //    Console.WriteLine("Grade: D");
            //}
            //else if (marks < 60)
            //{
            //    Console.WriteLine("Grade: F");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid marks entered. Please enter a number between 0 and 100.");
            //}
            //Console.ReadLine();
            //qn 26 Write a program that swaps the values of two variables using a third variable and without using a 
            //third variable. 
            // Declare and initialize two variables
            //int a, b, temp;

            //// Input values for the variables
            //Console.Write("Enter the value of a: ");
            //a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the value of b: ");
            //b = Convert.ToInt32(Console.ReadLine());

            //// Display the original values
            //Console.WriteLine($"Original values: a = {a}, b = {b}");

            //// Swapping using a third variable
            //temp = a; // Step 1: Store the value of a in temp
            //a = b;    // Step 2: Assign the value of b to a
            //b = temp; // Step 3: Assign the value of temp (original a) to b

            //// Display swapped values
            //Console.WriteLine($"After swapping using a third variable: a = {a}, b = {b}");

            //// Re-initialize the variables for the second method
            //Console.WriteLine("Enter the value of a again: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the value of a again: ");
            //b = Convert.ToInt32(Console.ReadLine());

            //// Swapping without using a third variable
            //a = a + b; // Step 1: Add both values and store in a
            //b = a - b; // Step 2: Subtract new b from new a to get original a
            //a = a - b; // Step 3: Subtract new b from new a to get original b

            //// Display swapped values
            //Console.WriteLine($"After swapping without a third variable: a = {a}, b = {b}");
            //Console.ReadLine();

            //qn 27 Write a program that takes two numbers as input and performs all arithmetic operations on them 
            //(addition, subtraction, multiplication, division, modulus, increment, and decrement).
            //Console.Write("Enter the first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //// Prompt the user to enter the second number
            //Console.Write("Enter the second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //// Perform arithmetic operations
            //double addition = num1 + num2;
            //double subtraction = num1 - num2;
            //double multiplication = num1 * num2;
            //double division = num2 != 0 ? num1 / num2 : 0; // Prevent division by zero
            //double modulus = num2 != 0 ? num1 % num2 : 0; // Prevent modulus by zero

            //// Increment and decrement (operating on num1)
            //num1++; // Increment
            //double increment = num1;

            //num1--; // Decrement to original value
            //num1--; // Decrement again for clarity in output
            //double decrement = num1;

            //// Output results
            //Console.WriteLine($"Addition: {addition}");
            //Console.WriteLine($"Subtraction: {subtraction}");
            //Console.WriteLine($"Multiplication: {multiplication}");
            //if (num2 != 0)
            //{
            //    Console.WriteLine($"Division: {division}");
            //    Console.WriteLine($"Modulus: {modulus}");
            //}
            //else
            //{
            //    Console.WriteLine("Division: Undefined (division by zero)");
            //    Console.WriteLine("Modulus: Undefined (division by zero)");
            //}
            //Console.WriteLine($"Increment (original num1): {increment}");
            //Console.WriteLine($"Decrement (current num1): {decrement}");
            //Console.ReadLine();
            //qn 28 Write a C# program that takes three numbers as input from the user and calculates the average of 
            //those numbers. The result should be displayed with two decimal places
            // Prompt the user to enter three numbers
            //Console.Write("Enter the first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the third number: ");
            //double num3 = Convert.ToDouble(Console.ReadLine());

            //// Calculate the average
            //double average = (num1 + num2 + num3) / 3;

            //// Display the result formatted to two decimal places
            //Console.WriteLine($"The average of {num1}, {num2}, and {num3} is: {average:F2}");
            //Console.ReadLine();
            //qn 29 Write a C# program to convert a given amount of money from USD to another currency (e.g., 
            //EUR). Assume a conversion rate, for example, 1 USD = 0.85 EUR.The program should take the
            //amount in USD as input and display the equivalent amount in EUR.
            //const double conversionRate = 0.85;

            //// Prompt the user to enter the amount in USD
            //Console.Write("Enter the amount in USD: ");
            //double amountInUSD = Convert.ToDouble(Console.ReadLine());

            //// Convert USD to EUR
            //double amountInEUR = amountInUSD * conversionRate;

            //// Display the equivalent amount in EUR
            //Console.WriteLine($"{amountInUSD} USD is equivalent to {amountInEUR:F2} EUR.");
            //Console.ReadLine();
            //qn 30 Write a program that checks if the input number is within a certain range (e.g., between 1 and 
            //100) and also checks if it is even or odd using relational and logical operators.
            // Prompt the user to enter a number
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //// Check if the number is within the range 1 to 100
            //bool isInRange = number >= 1 && number <= 100;

            //// Check if the number is even or odd
            //bool isEven = number % 2 == 0;

            //// Display results
            //if (isInRange)
            //{
            //    Console.WriteLine($"{number} is within the range of 1 to 100.");
            //    if (isEven)
            //    {
            //        Console.WriteLine($"{number} is an even number.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is an odd number.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not within the range of 1 to 100.");
            //}
            //Console.ReadLine();
            //qn 31 Write a program to check whether a number is divisible by both 3 and 5 using an if statement.
            // Prompt the user to enter a number
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //// Check if the number is divisible by both 3 and 5
            //if (number % 3 == 0 && number % 5 == 0)
            //{
            //    Console.WriteLine($"{number} is divisible by both 3 and 5.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not divisible by both 3 and 5.");
            //}
            //Console.ReadLine();
            //qn 32 leap year
            //Console.Write("Enter a year: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //// Check if the year is a leap year
            //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //{
            //    Console.WriteLine($"{year} is a leap year.");
            //}
            //else
            //{
            //    Console.WriteLine($"{year} is not a leap year.");
            //}
            //Console.ReadLine();
            //qn 33 Write a program that checks whether an input number is positive, even, and greater than 50 using 
            //nested if statements
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //// Check if the number is positive
            //if (number > 0)
            //{
            //    // Check if the number is greater than 50
            //    if (number > 50)
            //    {
            //        // Check if the number is even
            //        if (number % 2 == 0)
            //        {
            //            Console.WriteLine($"{number} is positive, even, and greater than 50.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{number} is positive and greater than 50, but it is not even.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is positive but not greater than 50.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not positive.");
            //}
            //Console.ReadLine();
            //qn 34 student grade
            //int subject1, subject2, subject3;

            //// Prompt the user to enter grades for three subjects
            //Console.Write("Enter the marks for Subject 1: ");
            //subject1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the marks for Subject 2: ");
            //subject2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the marks for Subject 3: ");
            //subject3 = Convert.ToInt32(Console.ReadLine());

            //// Check if the student has passed all subjects
            //int passingMark = 40;
            //bool passedAll = subject1 >= passingMark && subject2 >= passingMark && subject3 >= passingMark;

            //// If passed all, check average for distinction
            //if (passedAll)
            //{
            //    double average = (subject1 + subject2 + subject3) / 3.0; // Calculate average
            //    Console.WriteLine($"Average grade: {average:F2}");

            //    if (average >= 70)
            //    {
            //        Console.WriteLine("Distinction");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Passed but no distinction.");
            //    }
            //}
            //else
            //{
            //    // Count the number of subjects failed
            //    int failedSubjects = 0;

            //    if (subject1 < passingMark) failedSubjects++;
            //    if (subject2 < passingMark) failedSubjects++;
            //    if (subject3 < passingMark) failedSubjects++;

            //    Console.WriteLine($"The student has failed {failedSubjects} subjects.");
            //}
            //Console.ReadLine();
            //qn 35 salary range tax
            Console.Write("Enter your annual salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Initialize tax amount
            double tax = 0;

            // Check for senior citizen exemption
            if (age >= 60)
            {
                salary -= 5000; // Apply additional exemption for senior citizens
            }

            // Calculate tax based on the adjusted salary
            if (salary < 10000)
            {
                tax = 0; // No tax for salary less than $10,000
            }
            else if (salary >= 10000 && salary <= 50000)
            {
                tax = salary * 0.10; // 10% tax for salary between $10,000 and $50,000
            }
            else
            {
                tax = salary * 0.20; // 20% tax for salary above $50,000
            }

            // Print the tax amount to be paid
            Console.WriteLine($"The tax to be paid is: ${tax:F2}");
            Console.ReadLine();
        }
    }

}

