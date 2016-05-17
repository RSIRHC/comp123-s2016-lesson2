using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 
 * Author: Christopher Ritchil 
 * Date: May 17, 2016
 * Date Modified: May 17, 2016
 * Description: Advance Method Demo for Lesson 2
 * 
 * Version: 0.0.3 - Added addXandY method and associated test
 * 
 */



namespace COMP123_S2016_Lesson2
{
    /**
    * Main driver class for Lesson 2
    * 
    * @class Program
    */
    public class Program
    {
        /**
         * 
         * Main method for our drive class 
         * 
         * @constructor Main
         * @param {string[]} args
         * 
         */
        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;

            int result = addXandY(x, y); 
            Console.WriteLine(result); 

        }

        /**
         * Simple method to add two values
         * 
         * @method addXandY
         * @param {int} fNum
         * @param {int} sNum
         * 
         */
        public static int addXandY(int fNum, int sNum)
        {
            int result = 0;
            result = fNum + sNum; 
            return result; 
        }
    }
}
