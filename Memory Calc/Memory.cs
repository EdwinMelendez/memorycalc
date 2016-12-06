using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Memory_Calc
{
   public class Memory 
    {
        private string memStore;

        public Memory()
        {

        }

        static double memValue = 0;
        public double memorySave(double memoryValue)
        {
            memValue = memoryValue;

            return memoryValue;
        }




    }
}
