using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace Assign2_SashaSrinivas_n01458354.Controllers
{
    public class J2Controller : ApiController
    { 
        /// <summary>
        /// Determine how many ways to roll the value of 10 
        /// </summary>
        /// <param name="m">positive integer representing the number of sides on the first die</param>
        /// <param name="n">- positive integer representing the number of sides on the second die</param>
        /// <returns>A string describing the total ways to roll the value of 10</returns>
        /// <example>
        /// GET : /api/J2/DiceGame/6/8 ->     
        /// "There are 5 ways to get the sum 10."
        /// </example>
        /// <example>
        /// GET : /api/J2/DiceGame/12/4 ->     
        /// "There are 4 ways to get the sum 10"
        /// </example>
        /// GET : /api/J2/DiceGame/3/3 ->     
        /// "There are 0 ways to get the sum 10."
        /// </example>
        /// GET : /api/J2/Dicegame/5/5  ->     
        /// "There is 1 way to get the sum 10."
        /// </example>

        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            string message = "";
            int totalWays = 0;
            int sum = 10;

            for (int i=1; i<=m; i++)
            {
                for (int j= 1; j<=n; j++)
                {
                    if (i+j==sum)
                    {
                        totalWays = totalWays + 1;
                    }
                }
            }
            message = "There are" + " " + totalWays + " " + "ways to get the sum 10.";
            return message;
        }
    }
}
