using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input1 = "I am an automation tester and my name is kala";
                //Length of a string
                int lengthOfinput = input1.Length;
                Console.WriteLine("Input String is : " + input1 +" and length of string is : "+lengthOfinput);

                //Substring methods
                string subString = input1.Substring(3);
                Console.WriteLine("Substring String with start index : " + subString);
                string subString2 = subString.Substring(3,7);
                Console.WriteLine("Substring String with start and end index : " + subString2);

                //Replace method
                string afterReplacementString = input1.Replace("a", "z");
                Console.WriteLine("String replace all \'a\' with \'e\':" + afterReplacementString);

                //Convert string to char Array
                char[] array = afterReplacementString.ToCharArray();
                Console.WriteLine("Converted string to chararray");
                foreach(var i in array)
                {
                    Console.WriteLine(i);
                }

                //Check startswith and endswith
                Console.WriteLine("Check if string starts with prefix \'name\'----"+ afterReplacementString.StartsWith("I"));

                Console.WriteLine("Check if string ends with sufix \'kala\' ---"+ afterReplacementString.EndsWith("kala"));

                //clone
                string clonedString =(string) afterReplacementString.Clone();
                Console.WriteLine("Cloned \'afterReplacementString\' in \'clonedString\' " + clonedString);

                //CompareTo()
                string input3 = "I am an automation tester and my name is kala";

                Console.WriteLine("Comparing input1 and input2 --"+input1.CompareTo(input3));

                String input2 = "I work for <EPAM> systems";

                //ToUpper() and ToLower()

                Console.WriteLine(input1.ToLower());
                Console.WriteLine(input2.ToUpper());

                //Insert
                Console.WriteLine("Inserting a string at the end of input 2: "+input2.Insert(input2.Length, " \'Inserted Value\'"));

                //concat
               
                Console.WriteLine("Concating input1 and input2 using String.concat() method:"+ string.Concat(input1, input2));
                Console.WriteLine("Concating input1 and input2 using \'+\' operator:" + input1+ input2);


                //Remove
                Console.WriteLine("Removing chars after index 12 : "+input2.Remove(12));
                Console.WriteLine("Printing strings in split Array");
                //split
                string[] splitArray = input2.Split(' ');

                foreach(string j in splitArray)
                {
                    Console.WriteLine(j);
                }

                //indexOf

                int firstIndex = input1.IndexOf("a");
                Console.WriteLine("First Index of a in input1 : "+ firstIndex);

                int lastIndex = input1.LastIndexOf("a");
                Console.WriteLine("Last Index of a in input1 : " + lastIndex);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
