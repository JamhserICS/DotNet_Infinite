using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a query that returns words starting with letter 'a' and ending with letter 'm'

 Input : any collections (countries,fruits,colors,states,names etc)
 eg: {amsterdam, bloom}

Output : amsterdam*/


namespace Lambda_Queries_Solution
{
    class _2nd_Start_End_Program
    {
        public static void Main()
        {
            List<string> words = new List<string> { "amsterdam", "bloom", "abcdm", "mango" }; // creating list string type

            var query = from word in words
                        where word[0] == 'a' && word[word.Length - 1] == 'm'
                        select word;

            foreach (var word in query) //foreach loop to iterate word in query
            {
                Console.WriteLine(word);
            }
            Console.Read();
        }
    }
}
