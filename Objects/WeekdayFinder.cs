using System.Collections.Generic;
using System;
using System.Linq;

namespace LeapYearNS.Objects
{
  public class WeekdayFinder
    {
        private int _month;
        private int _day;
        private int _year;
        private int _totalNumber;
        private int _TotalLeapYears;

        public WeekdayFinder (int month, int day, int year)
        {
          _month = month;
          _day = day;
          _year = year;
        }

        public int NumberOfLeapYears()
        {
          int leapYear = 0;
          for(var i = 1; i<=_year;i++)
          {
            if(i % 4==0)
            {
              leapYear++;
              if(i%100==0&&i%400!=0)
              // if(i%100==0)
              {
                leapYear--;
              }
            }
          }
          _TotalLeapYears = leapYear;
          return leapYear;
        }

        public int FindNumberFromDate()
        {
          int[] monthArray = new int[] {0,31,59,90,120,151,181,212,243,273,304,334};
          _totalNumber = _day+monthArray[_month-1]+((_year-1)*365) + _TotalLeapYears;
          Console.WriteLine(_totalNumber);
          Console.WriteLine(_TotalLeapYears);

          return _totalNumber;
        }

        public string FindDayOfWeek()
        {

          string[] daysArray = new string[]{"Saturday","Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
          // _dayOfWeek = daysArray;

          int remainder = (_totalNumber) % 7;
          Console.WriteLine("remainder:"+remainder);
          return daysArray[remainder];
        }
  }
}
