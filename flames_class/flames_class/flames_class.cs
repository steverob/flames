/*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-**/
/*  FLAMES - Future Calculator                                      */
/*  Perdicts your future co-ops (Lol! Seriously??)                  */
/*  Coded by: PIT_CSE_CodeMachines                                  */
/*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-**/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlamesClass
{
    public class flames_class
    {

         private string nameOne,nameTwo,result;
         private int uniqueChars;
         

        //Global Results Storage
         private string[] results_storage = new string[6];


        public flames_class(string tempName1,string tempName2)
        {
            nameOne = tempName1;
            nameTwo = tempName2;
           results_storage[0]="Friends";
           results_storage[1]="Loosers";
           results_storage[2]="Affectionate";
           results_storage[3]="Morons!!";
           results_storage[4]="Enemies";
           results_storage[5]="Siblings";
           nameOne.ToLower();
           nameTwo.ToLower();


        }

        public string FlamesMain()
        {
            
            //Call to function that returns number of unique chars
            uniqueChars =findNumber(nameOne,nameTwo);

            //Call to function that returns the remaining character in the FLAMES string
            result=flames(uniqueChars);

            //Call to function that returns the result string(your future!)
            result = resultsSender(result[1]);

            return result;
        }



        //Finds the number of unique charachters in the two names
        private int findNumber( string str1, string str2)
        {
            int number=0,i,j;
            bool flag=false;
            StringBuilder str_manip1 = new StringBuilder(str1);
            StringBuilder str_manip2 = new StringBuilder(str2);

            for (j = 0; j < str_manip1.Length;)
            {
                flag = false;
                for (i = 0; i < str_manip2.Length; i++)
                {
                    if (str_manip1[j] == str_manip2[i])
                    {
                        str_manip1.Remove(j, 1);
                        str_manip2.Remove(i, 1);
                        flag = true;
                        break;
                    }
                }
                if (i == str_manip2.Length&&!flag)
                {
                    j++;
                    number++;
                }
            }

            for (j = 0; j < str_manip2.Length;)
            {
                flag = false;
                for (i = 0; i < str_manip1.Length; i++)
                {
                    if (str_manip2[j] == str_manip1[i])
                    {
                        flag = true;
                        str_manip2.Remove(j, 1);
                        str_manip1.Remove(i, 1);
                        break;
                    }
                }
                if (i == str_manip1.Length&&!flag)
                {
                    number++;
                    j++;
                }
            }

            return number;

        }

        //Evaluates the FLAMES algorithm
        private string flames(int unique)
        {
            int n=6;
            StringBuilder flamesString=new StringBuilder("Xflames");
            int i=unique;
            
            
            while(n!=1)
            {
                while (i > n)
                    i -= n;
                flamesString.Remove(i,1);
                n--;
                i=i+unique-1;                
            }

            return flamesString.ToString();
        }

        //Function that is used to select appropriate result from Global Results Storage
        private string resultsSender(char res)
        {
            switch(res)
            {
                case 'f':
                    return results_storage[0];
                case 'l':
                    return results_storage[1];
                case 'a':
                    return results_storage[2];
                case 'm':
                    return results_storage[3];
                case 'e':
                    return results_storage[4];
                case 's':
                    return results_storage[5];

            }
            return "X";
        }

        
            

    }
}
