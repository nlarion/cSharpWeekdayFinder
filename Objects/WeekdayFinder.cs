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
        if(IsLeapYear(i))
        {
          leapYear++;
        }
      }
      _TotalLeapYears = leapYear;
      return leapYear;
    }

    public bool IsLeapYear(int year)
    {
      if(year % 400 == 0 )
      {
        return true;
      }
      else if (year % 4 == 0 && year % 100 !=0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public int FindNumberFromDate()
    {
      int[] monthArray;
      if(IsLeapYear(_year))
      {
        monthArray = new int[] {0,31,60,91,121,152,182,213,244,274,305,335};
        _totalNumber = _day + monthArray[_month-1] + ((_year-1)*365) + _TotalLeapYears;
      }
      else
      {
        monthArray = new int[] {0,31,59,90,120,151,181,212,243,273,304,334};
        _totalNumber = _day + monthArray[_month-1] + ((_year-1)*365) + _TotalLeapYears+1;
      }
      return _totalNumber;
    }

    public string FindDayOfWeek()
    {
      string[] daysArray = new string[]{"Saturday","Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
      int remainder = (_totalNumber) % 7;
      return daysArray[remainder];
    }
  }
}
