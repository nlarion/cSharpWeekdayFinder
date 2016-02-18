using System.Collections.Generic;
using System;
using System.Linq;

namespace LeapYearNS.Objects
{
  public class WeekdayFinder
    {
        private int _month;
        private int _day;

        public WeekdayFinder (int month, int day)
        {
          _month = month;
          _day = day;
        }

        public int FindNumberFromDate()
        {
          int[] monthArray = new int[] {0,31,59,90,120,151,181,212,243,273,304,334};
          return _day+monthArray[_month-1];
        }
  }
}
