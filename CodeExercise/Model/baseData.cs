using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercise.Model
{
    public abstract class BaseData
    {
        public string ContentData { get; set; }

        public abstract void Process();
    }
}
