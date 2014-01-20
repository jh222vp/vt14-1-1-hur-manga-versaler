using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1._1_Hur_många_versaler.Model
{
    static class TextAnalyzer
    {
        public static int GetNumberOfCaptials(string text){

            var count = 0;
                foreach (Char inputString in text)
                {
                    if(Char.IsUpper(inputString))
                    {
                        count++;
                    }
                }

                return count;

        }
        
    }
}