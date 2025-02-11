using System;

class Program
{
    static void Main()
    {
        // Ask the user for input
        Console.WriteLine("Enter a string to check if it's a palindrome:");
        string input = Console.ReadLine();

        // Check if the input string is a palindrome
        bool isPalindrome = IsPalindrome(input);

        // Output the result
        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    // Function to check if a string is a palindrome
    static bool IsPalindrome(string str)
    {
        // Remove spaces and convert the string to lower case for a case-insensitive check
        str = str.Replace(" ", "").ToLower();

        // Compare characters from both ends of the string
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false; // Return false if characters don't match
            }
            left++;
            right--;
        }

        return true; // Return true if all characters match
    }
}
