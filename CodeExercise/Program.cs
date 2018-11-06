using CodeExercise.Helper;
using System.Configuration;
using WebAPI.Controllers;

namespace CodeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string targetData = ConfigurationManager.AppSettings["TargetData"];

            string result = new helloworldController().Get();

            HelperClass.ProcessData(result);

        }
    }
}
