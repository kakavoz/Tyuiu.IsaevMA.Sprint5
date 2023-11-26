using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.IsaevMA.Sprint5.Task4.v5.Lib
{
    public class DataService : ISprint5Task4v5
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX);
            double res = Math.Round((4.26 * x / Math.Sin(x)), 3);
            return res;
        }
    }
}