using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise.Model
{
    public class FileData : BaseData
    {
        public FileData(string data)
        {
            ContentData = data;
        }

        public override void Process()
        {
            //Write ContentData to a file
        }
    }
}
