using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAssignments.Logical
{
    internal class LogicTest
    {
        [Test]
        public void reverseString()
        {
            string str = "HelloT";
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                
                charArray[j] = str[i];
                charArray[i] = str[j];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
        [Test]
        public void PalindromCheck()
        {
            string str = "step on no pets"; 
            Boolean flag = false; 
            for (int i = 0, j = str.Length - 1; i < j/2; i++, j--)
            {

                if (str[i] != str[j])
                {
                    flag=false; 
                    break;
                }
                else
                {
                    flag = true;
                }
            }
            if(flag)
            {
                Console.WriteLine("Palindronme");
            }
            else
            {
                Console.WriteLine("Not Palindronme");
            }
        }
        [Test]
        public void ReverseWords()
        {
            string str = "Welcome to Csharp corner"; 
            string[] words = str.Split(' ');
            // Using Array Reverse
            /*
            Array.Reverse(words);
            Console.WriteLine(String.Join(" ", words));
            */
            for(int i = 0,j=words.Length-1;i< j; i++, j--)
            {
                string temp = words[i];
                words[i] = words[j];
                words[j] = temp;
            }
            Console.WriteLine(String.Join("  ", words));

        }
    }
}
