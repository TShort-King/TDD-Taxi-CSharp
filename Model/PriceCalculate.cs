using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Taxi_CSharp
{
    public class PriceCalculate
    {
        public string Get_The_Price(int run_the_distance, int wait_time)
        {
            string result = "";
            if (run_the_distance >= 0 && wait_time >= 0)
            {
                int price = Calculate_The_Price(Tools.Conver_Int_To_Double(run_the_distance),
                    Tools.Conver_Int_To_Double(wait_time));
                result = $"收费{price}元";
            }
            return result;
        }

        private int Calculate_The_Price(double distance, double time)
        {
            int result = 0;
            if (distance == 0 )
            {
                result = Tools.Conver_Object_To_Int(Math.Round(time * 0.25));
            }
            else if ((distance - 2) < 0)
            {
                result = 6;
            }
            else if ((distance - 8) < 0)
            {
                result = Tools.Conver_Object_To_Int(Math.Round((distance - 2) * 0.8 + 6 + time * 0.25));
            }
            else
            {
                result = Tools.Conver_Object_To_Int(Math.Round((distance - 8) * 0.5 + (distance - 2) * 0.8 + 6 + time * 0.25));
            }
            return result;
        }
    }
}
