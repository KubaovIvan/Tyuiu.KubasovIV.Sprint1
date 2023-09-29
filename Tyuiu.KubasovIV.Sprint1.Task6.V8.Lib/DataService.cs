using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KubasovIV.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string[] words = value.Split(' ');
            string result = "";

           
            foreach (string word in words)
            {
                string modifiedWord = word.Substring(1) + word[0];
                result += modifiedWord + " ";
            }

            return result.Trim(); 
        }
    }

}
    


