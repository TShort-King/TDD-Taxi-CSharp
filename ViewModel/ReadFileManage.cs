using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Taxi_CSharp
{
    public class ReadFileManage
    {
        TaxiPriceManage taxiManage;
        public  ReadFileManage()
        {
            taxiManage = new TaxiPriceManage();
        }

        public List<string> Get_Results(string filePath,string fileName)
        {
            List<string> result = null;
            if (!string.IsNullOrEmpty(fileName))
            {
                result = Read_File(Path.Combine(filePath + "src\\main\\resources", fileName));
            }
            return result;
        }

        private List<string> Read_File(string filePath)
        {
            List<string> temp_List = new List<string>();
            StreamReader sr = new StreamReader(filePath, Encoding.Default);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                temp_List.Add(taxiManage.Get_Price(line));
            }
            return temp_List;
        }
    }
}
