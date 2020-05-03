using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDD_Taxi_CSharp
{
    public class TaxiPriceManage
    {
        PriceCalculate calculate_instance = null;

        public string Get_Price(string distanceAndTime)
        {
            string result = "收费0元";
            if (!string.IsNullOrEmpty(distanceAndTime))
            {
                result = Analytic_Input_String(distanceAndTime);
                if (string.IsNullOrEmpty(result)) 
                { 
                    result = "收费0元"; 
                }
            }
            return result;
        }

        private string Analytic_Input_String(string str)
        {
            string result = "";
            string[] strArray = Tools.Delete_Empty_Elements(Regex.Split(str, @"\D+"));
            if (strArray.Length > 1)
            {
                calculate_instance = new PriceCalculate();
                result = calculate_instance.Get_The_Price(
                    Tools.Conver_Object_To_Int(strArray[0]), 
                    Tools.Conver_Object_To_Int(strArray[1])
                    );
            }
            return result;
        }
    }
}
