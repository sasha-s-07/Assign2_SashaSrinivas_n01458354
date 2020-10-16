using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2_SashaSrinivas_n01458354.Controllers
{
    public class J3Controller : ApiController
    { 
        /// <summary>
        /// Output one of two statements: "deal" or "no deal" 
        /// </summary>
        /// <param name="n">positive integer between 1 and 10 that represents the dollar value of cases in an array</param>
        /// <param name="offer">positive integer representing the "Banker's" offer</param>
        /// <returns>A string describing "deal" or "no deal" based on the offer and elimated cases</returns>
        /// <example>
        /// GET : /api/J3/2/3/8/198000 ->     
        /// "no deal"
        /// </example>
        /// <example>
        /// GET : /api/J3/8/10/9/8/7/6/5/4/3/400 ->     
        /// "deal"
        /// </example>
     
        ///[HttpGet]
        ///[Route("api/J3/Deal/{n}/{offer}")]

        public string Deal(int n, int offer)
        {
            int[] arrayDollars = { 100, 500, 1000, 5000, 10000, 25000, 50000, 100000, 500000, 1000000 };
            int sum = sum + arrayDollars(n - 1);
            int avg = sum / (10 - n);
            int offer = 0;
            ///user inputs a number n(1<=n<=10) which indicates how many cases have been opened so far
            ///user inputs a list of n integers between 1 and 10 which represeants the values in the game that have been elimated
            ///user inputs the bankers offer 
            ///calculate the average amount of the cases that have been elimated 
            ///if (offer > avg){
            /// message = "deal"
            ///}
            ///else {
            /// message = "no deal"
            /// }
            /// return message
        }

    }
}
