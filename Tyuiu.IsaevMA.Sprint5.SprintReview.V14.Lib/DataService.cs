using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.IsaevMA.Sprint5.SprintReview.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V14.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExixsts = fileInfo.Exists;

            if (fileExixsts)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            string strAdd = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {

                        strAdd = Convert.ToString(line[i]);
                        strLine = strLine + strAdd.ToUpper();


                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }

    }
}



