using CodeExercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise.Helper
{
    public static class HelperClass
    {
        public static void ProcessData(string result)
        {
            BaseData resultData;

            switch (result)
            {
                case "Database":
                    // on db
                    resultData = new DatabaseData(result);
                    break;
                case "File":
                    // file
                    resultData = new FileData(result);
                    break;
                default:
                    // on Screen
                    resultData = new ConsoleData(result);
                    break;
            }

            resultData.Process();
        }
    }
}
