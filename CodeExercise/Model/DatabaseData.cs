using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise.Model
{
    public class DatabaseData : BaseData
    {
        public DatabaseData(string data)
        {
            ContentData = data;
        }

        public override void Process()
        {
            //Store ContentData into a database
        }
    }
}
