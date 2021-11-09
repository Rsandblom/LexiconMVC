using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC.Models
{
    public static class TemperatureEvaluator
    {
        public static string GetBodyTemperatureStatus(Temperature temp)
        {
            if (temp.CurrentTemp == 0)
                return "";


            double fever, hypothermia;

            if (temp.IsCelsius)
            {
                fever = 38;
                hypothermia = 35;
            }
            else
            {
                fever = 100.4;
                hypothermia = 95;
            }

            if(temp.CurrentTemp < hypothermia)
            {
                return "You have hypothermia";
            }
            if (temp.CurrentTemp > fever)
            {
                return "You have e fever";
            }
            else
            {
                return "Your body temperature is ok";
            }
           
        }
    }
}
