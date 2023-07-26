using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    public class Counter
    {
        public static int count;
        public void add() 
        {
            count++;
        }
        public string getCount() 
        {
            return count.ToString();
        }
    }
}
