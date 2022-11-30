using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User_NN_Lib
{
    public class Calculations
    {
        /*
         * ●	список занятых промежутков времени (в двух массивах: startTimes - начало, durations - длительность), 
●	            минимальное необходимое время для работы менеджера (consultationTime),
●	            рабочий день сотрудника (начало - beginWorkingTime и завершение - endWorkingTime)
                Выход:
●	                    список подходящих свободных временных промежутков (в массив строк формата HH:mm-HH:mm)

         */
        public string AvailablePeriods(TimeSpan[] startTime, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            string str = "12";
            return  str;
        }
        
        private void Main()
        {
            TimeSpan ts1 = new TimeSpan(10,0,0);
            int[] dlit = new int[5] {30, 20, 10 ,15,40};
            TimeSpan begin = new TimeSpan(8, 0, 0);
            TimeSpan end = new TimeSpan(19, 0, 0);
            int consul = 30;

            //AvailablePeriods(ts1, dlit, begin, end, consul);
        }
    }

    
}
