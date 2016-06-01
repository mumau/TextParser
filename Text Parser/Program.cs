using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
           //Console.WriteLine("Place a .txt file of the text you want to parse on your desktop ");
           //string BlockofText = Console.ReadLine();
            Console.WriteLine("Enter the word you want to find:");
            string SearchTerm = Console.ReadLine();


            string text = System.IO.File.ReadAllText(@"C:\Users\mmmumau\Desktop\GettysburgAddress.txt");
            Console.WriteLine("Contents of GettysburgAddress.txt = {0}", text);

            int index = text.IndexOf(SearchTerm);

            while (index != -1)
            {

                Console.WriteLine("The thing you searched is in the text!  It is at {0}", index);
                index = text.IndexOf(SearchTerm, index + 1);
            }
            //for (int i = 0; i < text.Length; i++)
            //{
            //    int j = 0;
            //    while (j < SearchTerm.Length && SearchTerm[j] == text[i+j] )
            //    {
            //        j++;
                    
            //    }
            //    if ( j == SearchTerm.Length )
            //    {
            //        Console.WriteLine("The thing you searched is in the text!  It is at {0}", i);
            //    }
            //}
                    
            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }
}

//C:\Users\mmmumau\Desktop\GettysburgAddress.txt
//

//homework: //next step will be doing this smarter (refactor).  take advantage of string features