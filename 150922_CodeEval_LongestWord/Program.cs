using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _150922_CodeEval_LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //In this challenge you need to find the longest word in a sentence. 
            //If the sentence has more than one word of the same length you should pick the first one.

            //First split string into array of words
            
            //array with int values. sort. then if int value == array[i].length...?
            


            /*Sample code to read in test cases:
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line
        }
    }
}*/

            string line = "another line";
            
            string[] text = line.Split(' ');
            int[] lengths = new int[(text.Length)];                      
            
            //using loop to create new array with int values to match lengths
            for (int i = 0; i < text.Length; i ++)
            {
                lengths[i] = text[i].Length;
            }
            Array.Sort(lengths);
            Array.Reverse(lengths);
            
            //loop through string array
            foreach (string word in text)
            {
                if ((word.Length) != lengths[0] )
                {
                    continue;
                }
                else if ((word.Length == lengths[0]))
                {
                    Console.WriteLine(word);
                    break;
                }
            }                                                         
        }
        
       
    }
}
