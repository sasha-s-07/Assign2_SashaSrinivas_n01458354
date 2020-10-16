using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2_SashaSrinivas_n01458354.Controllers
{
    public class J1Controller : ApiController
    { 
       /// <summary>
       /// Compute total calories of the meal 
       /// </summary>
       /// <param name="burger">Integer representing the index burger choice</param>
       /// <param name="drink">Integer representing the index drink choice</param>
       /// <param name="side">Integer representing the index side choice</param>
       /// <param name="dessert">Integer representing the index dessert choice</param>
       /// <returns>A string describing the total calorie count</returns>
       /// <example>
       /// GET : /api/J1/Menu/4/4/4/4 ->     
       /// "Your total calorie count is 0"
       /// </example>
       /// <example>
       /// GET : /api/J1/Menu/1/2/3/4 ->     
       /// "Your total calorie count is 691"
       /// </example>
       [HttpGet]
       [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")] 
       public string Menu(int burger, int drink, int side, int dessert)
       {
            int TotalCalories = 0;
            int[] arrayBurger = { 461, 431, 420, 0};
            int[] arrayDrink = { 130, 160, 118, 0};
            int[] arraySide = { 100, 57, 70, 0 };
            int[] arrayDessert = { 167, 266, 75, 0 };
            if (burger > 0 && burger <5)
            {
                TotalCalories = TotalCalories + arrayBurger[burger - 1];
            }
            if (drink > 0 && drink < 5)
            {
                TotalCalories = TotalCalories + arrayDrink[drink - 1];
            }
            if (side > 0 && side < 5)
            {
                TotalCalories = TotalCalories + arraySide[side - 1];
            }
            if (dessert > 0 && dessert < 5)
            {
                TotalCalories = TotalCalories + arrayDessert[dessert - 1];
            }
            return "Your total calorie count is" + " " + TotalCalories;
       }
    }
}
