using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AgafonovKS.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int previousMonth = 0;
            int previousDay = n - 1;

            switch (m)
            {
                case 1:  
                    previousMonth = 12;  
                    break;
                case 2: 
                    previousMonth = 1;  
                    if (n == 1)
                    {
                        previousDay = 31; 
                    }
                    break;
                case 3:  
                case 5: 
                case 7:  
                case 8:  
                case 10: 
                case 12: 
                    previousMonth = m;  
                    break;
                case 4:  
                case 6:  
                case 9: 
                case 11: 
                    previousMonth = m; 
                    if (n == 1)
                    {
                        previousDay = 31;
                    }
                    break;
                default:
                    return "Некорректный месяц";
            }

            return $"{previousDay}.{previousMonth}"; 
        }

    }
    
}
