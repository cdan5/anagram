using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the file name: ");
            string file = Console.ReadLine();
            string[] words = File.ReadAllLines(file);


            Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
            
            foreach (string word in words){
                char[] c = word.ToCharArray();
                Array.Sort(c);
                string s = new string(c);

                if (!anagrams.ContainsKey(s))
                {
                    anagrams[s] = new List<string>();
                }
                anagrams[s].Add(word);
            }

            foreach (var w in anagrams.Values)
            {
                string line = "";
                int length = w.Count;
                for (int x = 0; x < length; x++)
                {
                    if (x == length - 1)
                    {
                        line += w[x];
                    }
                    else
                    {
                        line += w[x] + ", ";
                    }
                }
                Console.WriteLine(line);
            }


            //Dictionary<int[], List<string>> anagrams = new Dictionary<int[], List<string>>();
            //foreach (string word in words){
            //    int[] letterCount = new int[26];
            //    foreach (int letter in word){
            //        letterCount[letter - (int)'a'] += 1;
            //    }

            //    if (!anagrams.ContainsKey(letterCount)){
            //        anagrams[letterCount] = new List<string>();
            //    }
            //    anagrams[letterCount].Add(word);
            //}

            Console.ReadLine();
        }
    }
}