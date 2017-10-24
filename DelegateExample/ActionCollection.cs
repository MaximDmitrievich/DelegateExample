using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    public delegate string EditString(string inputString); //указатель на функцию

    public class ActionCollection
    {
        public string RemoveDots(string inputString) // Убираем из строки точки
        {
            string result = inputString.Replace(".", "");
            return result;
        }

        public string RemoveComma(string inputString) // Убираем из строки запятые
        {
            string result = inputString.Replace(",", "");
            return result;
        }
    }
}
