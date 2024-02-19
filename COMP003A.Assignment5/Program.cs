using System.Data;
using System.Net.Http.Headers;

/// <summary><
/// Author: Matthew Hudson
/// Course: COMP003A-L01
/// Purpose: Methods & XLM Comments Assignment
/// </summary>
namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator("Triangle");

            Console.Write("Enter a character: ");
            char inputCharacter = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a positive whole number: ");
            int size = Convert.ToInt32(Console.ReadLine());

            IsoscelesTriangleBuilder(inputCharacter, size);

            PrintSeparator("Favorite Characters");

            CharacterInfo("Superman", 1938);
            CharacterInfo("Batman", 1939);
            CharacterInfo("Spider-Man", 1962);
            CharacterInfo("Wonder Woman", 1941);
            CharacterInfo("Iron Man", 1963);

        }
       
        /// <summary>
        /// Outputs 50 asterisks in the console
        /// </summary>
        static void PrintSeparator()
        {
            Console.WriteLine(new string('*', 50));
        }

        /// <summary>
        /// Outputs the specified string and 50 asterisks
        /// </summary>
        /// <param name="output">String to be output.</param>'
        static void PrintSeparator(string output)
        {
            PrintSeparator();
            Console.WriteLine(output);
            PrintSeparator();
        }
        /// <summary>
        /// This builds the isosceles triangele by using the specified character & size
        /// </summary>
        /// <param name="inputCharacter">The character that's used for making the triangle</param>
        /// <param name="size"> this is the size of the triangle</parame>
        /// <remarks>XML comments for IsosclesTriangleBuidler(char inputCharacter, int size).</remarks>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i =1; i <= size; i++)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }
            for (int i = size -1; i >= 0; i--)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }
        }

        ///<summary>
        /// This calculates the age based on the year that is specified
        /// <summary>
        /// <param name="year"> The birth year</param>
        /// <returns> The calculated age </returns>
        /// <remarks> XML comments for AgeCalculator(int year)</remarks>
        static int AgeCalculator(int year)
        {
            return DateTime.Now.Year - year;
        }
        
        /// <summary>
        /// Outputs name and calculated age based upon birth year
        /// <summary>
        /// <param name="name"> the name of the character </param>
        /// <param name="birthYear"> The birth year or first appearance year </param>
        /// <remarks> XML comments for ChracterInto(string name, int birthYearO </remarks>
        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name}: Age - {age} years");
        }
    }
}
