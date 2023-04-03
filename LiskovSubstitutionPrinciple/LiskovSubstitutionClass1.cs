using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{   
    interface IOccupation
    {
        String GetOccupation();
    }

    class Father : IOccupation
    {
        /// <summary>
        /// Get Occupation Method That returns occupation type
        /// </summary>
        /// <returns>string</returns>
        public string GetOccupation()
        {
            return "Business Man";
        }
    }

    class Son : IOccupation
    {
        /// <summary>
        /// Get Occupation Method That returns occupation type
        /// </summary>
        /// <returns>string</returns>
        public String GetOccupation()
        {
            return "Corporate ";
        }
    }
      class LiskovSubstitutionClass1  
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Occupation ");

            IOccupation occupation =new Father();
            Console.WriteLine("Father's Occupation : " + occupation.GetOccupation());

            occupation = new Son();
       
            Console.WriteLine("Son's Occupation : " + occupation.GetOccupation());

        }
    }
}
