using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Taxi_CSharp
{
    class Tools
    {
        public static int Conver_Object_To_Int(object value)
        {
            int returnValue = -1;
            if (!string.IsNullOrEmpty(value.ToString()))
            {
                if (int.TryParse(value.ToString(), out int resultValue))
                {
                    returnValue = resultValue;
                }
            }
            return returnValue;
        }

        public static double Conver_Int_To_Double(int value)
        {
            double returnValue = -1;
            if (double.TryParse(value.ToString(), out double resultValue))
            {
                returnValue = resultValue;
            }
            return returnValue;
        }

        public static string[] Delete_Empty_Elements(string[] stringArray)
        {
            List<string> temp_list = stringArray.ToList();
            if (temp_list.Count > 0)
            {
                string result = temp_list.FirstOrDefault(item => item == "");
                if (result != null)
                {
                    temp_list.Remove(result);
                }
            }
            return temp_list.ToArray();
        }
    }
}
