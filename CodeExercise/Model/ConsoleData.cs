using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise.Model
{
    public class ConsoleData : BaseData
    {
        public ConsoleData(string data)
        {
            ContentData = data;
        }

        public override void Process()
        {
            Console.WriteLine(base.ContentData);
            Console.ReadKey();
        }
    }
}
