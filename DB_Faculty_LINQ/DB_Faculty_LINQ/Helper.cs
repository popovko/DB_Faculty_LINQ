using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Faculty_LINQ
{
    class Helper
    {
        public static void NameChecker(string name)
        {
            if (name.Length < 2)
                throw new Exception("Некоректне ім'я");
            
            name = name.ToLower();
            for (int i=0; i<name.Length; i++)
            {
                if (name[i] < 'а' || name[i] > 'я' || name[i] == 'і')
                    throw new Exception("Некоректне ім'я");
            }       
        }
    }
    
}
