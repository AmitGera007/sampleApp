using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Program
    {
        static List<int> numberList;
        static List<List<int>> linesList;
        static void Main(string[] args)
        {
            var sampleData = new SampleData();
            numberList = sampleData.GetNumberList();
            linesList = sampleData.GetLinesList();
        }
    }

    public class SampleData
    {
        string sampleResults =

        "18 - 28 - 31 - 32 - 44 - 51 * " +

        "11 - 19 - 20 - 30 - 35 - 49  * " +

        "3 - 37 - 42 - 47 - 55 - 58   * " +

        "18 - 36 - 48 - 57 - 58 - 59  * " +

        "20 - 32 - 36 - 44 - 47 - 56  * " +

        "10 - 20 - 28 - 38 - 41 - 46  * " +

        "22 - 25 - 35 - 45 - 46 - 57  * " +

        "06 - 14 - 23 - 24 - 43 - 58  * " +

        "02 - 32 - 37 - 39 - 46 - 54  * " +

        "03 - 19 - 24 - 31 - 50 - 52  * " +

        "04 - 09 - 13 - 32 - 46 - 50  * " +

        "20 - 32 - 42 - 43 - 53 - 58  * " +

        "04 - 07 - 29 - 45 - 54 - 56  * " +

        "02 - 16 - 17 - 27 - 36 - 37  * " +

        "01 - 20 - 24 - 36 - 54 - 58  * " +

        "02 - 11 - 22 - 36 - 51 - 59  * " +

        "04 - 16 - 27 - 30 - 41 - 49  * " +

        "02 - 17 - 25 - 32 - 42 - 49  * " +

        "06 - 20 - 23 - 29 - 35 - 53  * " +

        "13 - 14 - 18 - 19 - 21 - 36  * " +

        "08 - 15 - 33 - 42 - 55 - 58  * " +

        "01 - 03 - 11 - 37 - 49 - 58  * " +

        "03 - 31 - 37 - 41 - 44 - 59  * " +

        "11 - 12 - 15 - 22 - 27 - 44  * " +

        "06 - 22 - 40 - 43 - 47 - 58  * " +

        "17 - 38 - 49 - 54 - 55 - 56  * " +

        "15 - 20 - 30 - 37 - 47 - 51  * " +

        "12 - 20 - 32 - 38 - 48 - 54  * " +

        "13 - 18 - 21 - 30 - 50 - 54  * " +

        "30 - 35 - 45 - 47 - 52 - 55  * " +

        "17 - 18 - 26 - 39 - 54 - 56  * " +

        "08 - 20 - 25 - 50 - 51 - 58  * " +

        "01 - 06 - 31 - 37 - 49 - 50  * " +

        "04 - 11 - 14 - 21 - 29 - 56  * " +

        "04 - 07 - 13 - 49 - 56 - 58  * " +

        "16 - 30 - 34 - 50 - 52 - 53  * " +

        "30 - 33 - 35 - 40 - 41 - 5";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<List<int>> GetLinesList()
        {
            var strArray = sampleResults.Replace(" - ", "-").Replace(" ", "").Split('*');
            var lineList = new List<List<int>>();

            foreach (var line in strArray)
            {
                var lineArray = line.Split('-');
                lineList.Add(GetLine(lineArray));
            }

            return lineList;
        }

        public List<int> GetNumberList()
        {
            var strArray = sampleResults.Replace(" - ", "-").Replace(" ", "").Split('*');

            return GetLine(strArray);
        }

        private static List<int> GetLine(string[] strArray)
        {
            List<int> numbereList = new List<int>();
            foreach (var line in strArray)
            {
                var intArray = line.Split('-');
                foreach (var num in intArray)
                {
                    numbereList.Add(Convert.ToInt32(num));
                }
            }
            return numbereList;
        }
    }
}                   
                               