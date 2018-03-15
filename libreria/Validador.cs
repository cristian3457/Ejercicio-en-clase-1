using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreria
{
    public class Validador
    {
        public Boolean entero(String a)
        {
            int num=int.Parse(a);
            
            if (num>0&&num<=110)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
    
}
