using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();
        }
        /*
       <summary>
       Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.
       Example 1:
       Input: s = "MumaCollegeofBusiness"
       Output: "MmCllgfBsnss"
       Example 2:
       Input: s = "aeiou"
       Output: ""
       Constraints:
       • 0 <= s.length <= 10000
       s consists of uppercase and lowercase letters
       </summary>
       */

        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                String res = "";
                for (int i = 0; i < s.Length; i++) // Checking whether the vowels are present in the string 's' or not.
                {
                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'
                    || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                    {
                        res = res + ""; // If vowels are present in the string, then they are not appended to the 'res' string.
                    }
                    else
                    {
                        res = res +  s[i]; // Only consonants are appended to the 'res' string here.
                    }
                }
                return res; //Returning the final 'res' string.
            }
            catch (Exception)
            {
                throw;
            }

        }

        /*
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false
       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                // write your code here.
                string string1 = "", string2 = "";
                for (int i = 0; i < bulls_string1.Length; i++)
                {
                    string1 = string1 + bulls_string1[i]; // Appending all the characters of bulls_string1 into the single string 'string1'  
                }
                for (int j = 0; j < bulls_string2.Length; j++)
                {
                    string2 = string2 + bulls_string2[j]; //Appending all the characters of bulls_string2 into the single string 'string2'
                }
                if (string1 == string2) //checking if the two strings 'string1'and 'string2' are equivalent or not.
                {
                    return true; //Returns True if 'string1'and 'string2' are equivalent.
                }
                else 
                {
                    return false; //Returns False if 'string1'and 'string2' are not same.
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary>
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                //write your code here
                int sum = 0;
                var dict = new Dictionary<int, int>() { };
                foreach (int i in bull_bucks)
                {
                    if (dict.ContainsKey(i)) // Checking for the number whether it is present in dictionary or not.
                    {
                        dict[i] = dict[i] + 1; 

                    }
                    else
                    {
                        dict[i] = 1;
                    }
                }
                foreach (var item in dict)  // iterating over the unique elements.
                {
                    if (item.Value == 1)
                    {
                        sum = sum + item.Key; //Adding unique elements to the 'sum'
                    }
                }
                return sum; //returning final sum.

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // write your code here.
                int i = 0; //front index increment.
                int diagonal_sum = 0;
                int j = bulls_grid.GetLength(1) - 1; // back index increment
                for (int a = 0; a < bulls_grid.GetLength(0); a++)
                {
                    //a = row
                    if (i == j)
                    {
                        diagonal_sum = diagonal_sum + bulls_grid[a, i]; // diagonal sum if i == j.
                    }
                    else
                    {
                        diagonal_sum = diagonal_sum + bulls_grid[a, i] + bulls_grid[a, j]; // diagonal sum for i not equals to j.
                    }
                    i++;
                    j--;
                }
                return diagonal_sum;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                // write your code here.
                string rotated_string = "";
                string[] arr = new string[bulls_string.Length];
                for (int i = 0; i < indices.Length; i++) 
                { 
                    arr[indices[i]] = Convert.ToString(bulls_string[i]); // The value of the indices[i] is passed as the index to the 'arr' and the values of the bulls_string[i] are stored into the 'arr'.
                }
                for (int i = 0; i < arr.Length; i++)
                { 
                    rotated_string = rotated_string + arr[i]; // All the characters of the 'arr' string are passed to the rotated string.
                }
                return rotated_string; //returning the final string output.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4.
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".
        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                String prefix_string = "";
                int i = 0, j = 0;
                for (i = 0; i < bulls_string6.Length; i++)
                {
                    if (ch == bulls_string6[i]) //checking whether the character is present in the string or not.
                    {
                        j = i;                       
                    }
                }
                for (i = j; i >= 0; i--) // From the index j, Characters are appended in the reverse order to the 'prefix_String'.
                {
                    prefix_string = prefix_string + bulls_string6[i];
                }
                for (i = j + 1; i < bulls_string6.Length; i++) //Appending the remaining characters to the 'prefix_String' from the 'bulls_string6' after the index j.
                {
                    prefix_string = prefix_string + bulls_string6[i];
                }
                return prefix_string; //returning the final string.
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
